using DAL.Models;
using DAL.Models.DTOs;

namespace DAW.Services.IngredientService
{
    public interface IIngredientService
    {
        Task<List<IngredientDTO>> GetAllIngredients();
        Task<List<IngredientDTO>> GetIngredientsForRecipe(Guid recipeId);
    }
}
