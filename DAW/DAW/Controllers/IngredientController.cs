using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAW.Services.IngredientService;
using DAW.Services.RecipeService;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService) 
        {
            _ingredientService = ingredientService; 
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllIngredients()
        {
            return Ok(await _ingredientService.GetAllIngredients());
        }
        [HttpGet("{recipeId}")]
        public async Task<IActionResult> GetIngredientsForRecipe([FromRoute] Guid recipeId)
        {
            return Ok(await _ingredientService.GetIngredientsForRecipe(recipeId));
        }
    }
}
