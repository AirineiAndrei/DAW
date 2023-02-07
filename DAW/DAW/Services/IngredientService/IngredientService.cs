using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;
using DAL.Repositories.IngredientInRecipeRepository;
using DAL.Repositories.IngredientRepository;
using DAL.Repositories.RecipeRepository;
using System.Reflection.Metadata.Ecma335;

namespace DAW.Services.IngredientService
{
    public class IngredientService : IIngredientService
    {
        public IIngredientRepository _ingredientRepository;
        public IIngredientInRecipeRepository _ingredientInRecipeRepository;
        public IRecipeRepository _recipeRepository;
        public IMapper _mapper;
        public IngredientService(IIngredientRepository ingredientRepository, IIngredientInRecipeRepository ingredientInRecipeRepository, IRecipeRepository recipeRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _recipeRepository = recipeRepository;
            _ingredientInRecipeRepository= ingredientInRecipeRepository;
            _mapper = mapper;
        }

        public async Task<List<IngredientDTO>> GetAllIngredients()
        {
            var ingredients = await _ingredientRepository.GetAll();
            List<IngredientDTO> result = _mapper.Map<List<IngredientDTO>>(ingredients);
            return result;
        }
        public async Task<List<IngredientDTO>> GetIngredientsForRecipe(Guid recipeId)
        {
            var recipe = _recipeRepository.FindById(recipeId);
            var ingredients = await _ingredientRepository.GetIngredientsForRecipe(recipe);
            List<IngredientDTO> result = _mapper.Map<List<IngredientDTO>>(ingredients);
            return result;
        }

    }
}
