using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAW.Services.RecipeService;
using DAL.Models.DTOs;
using DAL.Models.Enums;
using DAW.Helpers.Attributes;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [Authorization(Role.Admin)]
        [HttpGet]
        public async Task<IActionResult> GetAllRecipes()
        {
            return Ok(await _recipeService.GetAllRecipes());
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(RecipeDTO newRecipe)
        {
            await _recipeService.AddRecipe(newRecipe);
            return Ok();
        }

        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> DeleteRecipe([FromRoute] Guid recipeId)
        {
            await this._recipeService.DeleteRecipe(recipeId);
            return Ok(await _recipeService.GetAllRecipes());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRecipe(RecipeDTO newRecipe)
        {
            await this._recipeService.UpdateRecipe(newRecipe);
            return Ok();
        }
    }
}
