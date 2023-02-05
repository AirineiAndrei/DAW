using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;
using DAL.Repositories.IngredientInRecipeRepository;
using DAL.Repositories.RecipeRepository;

namespace DAW.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        public IRecipeRepository _recipeRepository;
        public IIngredientInRecipeRepository _ingredientInRecipeRepository;
        public IMapper _mapper;

        public RecipeService(IRecipeRepository recipeRepository, IIngredientInRecipeRepository ingredientInRecipeRepository, IMapper mapper)
        {
            _recipeRepository = recipeRepository;
            _ingredientInRecipeRepository= ingredientInRecipeRepository;
            _mapper = mapper;
        }

        public async Task<List<RecipeDTO>> GetAllRecipes()
        {
            var recipes = await _recipeRepository.GetAll();
            List<RecipeDTO> result = _mapper.Map<List<RecipeDTO>>(recipes);

            return result;
        }
        public async Task AddRecipe(RecipeDTO newRecipe)
        {
            var newDbRecipe = _mapper.Map<Recipe>(newRecipe);
            await _recipeRepository.CreateAsync(newDbRecipe);
            await _recipeRepository.SaveAsync();
        }
        public async Task UpdateRecipe(RecipeDTO newRecipe)
        {
            var DbRecipe = _mapper.Map<Recipe>(newRecipe);
            _recipeRepository.Update(DbRecipe);
            await _recipeRepository.SaveAsync();
        }

        public async Task DeleteRecipe(Guid recipeId)
        {
            var recipeToDelete = await _recipeRepository.FindByIdAsync(recipeId);

            _ingredientInRecipeRepository.DeleteIngredientForRecipe(recipeToDelete);
            _recipeRepository.Delete(recipeToDelete);
            await _recipeRepository.SaveAsync();
        }

    }
}
