using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;
using DAL.Repositories.IngredientInRecipeRepository;
using DAL.Repositories.RecipeRepository;
using DAW.Helpers.UnitOfWork;

namespace DAW.Services.RecipeService
{
    public class RecipeService : IRecipeService
    {
        private readonly IUoW _Uow;
        public IMapper _mapper;

        public RecipeService(IMapper mapper,IUoW Uow)
        {
            _Uow = Uow;
            _mapper = mapper;
        }

        public async Task<List<RecipeDTO>> GetAllRecipes()
        {
            var recipes = await _Uow.RecipeRepo.GetAll();
            List<RecipeDTO> result = _mapper.Map<List<RecipeDTO>>(recipes);

            return result;
        }
        public async Task AddRecipe(RecipeDTO newRecipe)
        {
            var newDbRecipe = _mapper.Map<Recipe>(newRecipe);
            await _Uow.RecipeRepo.CreateAsync(newDbRecipe);
            await _Uow.RecipeRepo.SaveAsync();
        }
        public async Task UpdateRecipe(RecipeDTO newRecipe)
        {
            var DbRecipe = _mapper.Map<Recipe>(newRecipe);
            _Uow.RecipeRepo.Update(DbRecipe);
            await _Uow.RecipeRepo.SaveAsync();
        }

        public async Task DeleteRecipe(Guid recipeId)
        {
            var recipeToDelete = await _Uow.RecipeRepo.FindByIdAsync(recipeId);

            _Uow.IngredientInRecipeRepo.DeleteIngredientForRecipe(recipeToDelete);
            _Uow.RecipeRepo.Delete(recipeToDelete);
            await _Uow.RecipeRepo.SaveAsync();
        }

    }
}
