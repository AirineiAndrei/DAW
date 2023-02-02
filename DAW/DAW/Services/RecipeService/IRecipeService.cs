using DAL.Models.DTOs;

namespace DAW.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<List<RecipeDTO>> GetAllRecipes();
        public Task DeleteRecipe(Guid recipeId);
    }
}
