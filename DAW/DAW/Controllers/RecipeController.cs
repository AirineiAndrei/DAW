using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAW.Services.RecipeService;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService= recipeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecipes()
        {
            return Ok(await _recipeService.GetAllRecipes());
        }
        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> DeleteRecipe([FromRoute] Guid recipeId)
        {
            await this._recipeService.DeleteRecipe(recipeId);
            return Ok(await _recipeService.GetAllRecipes());
        }
    }
}
