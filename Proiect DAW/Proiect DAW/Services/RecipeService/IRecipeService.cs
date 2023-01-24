using DAL.Models.DTOs;

namespace Proiect_DAW.Services.RecipeService
{
    public interface IRecipeService
    {
        Task<List<RecipeDTO>> GetAllRecipes();
        public Task DeleteRecipe(Guid recipeId);
    }
}
