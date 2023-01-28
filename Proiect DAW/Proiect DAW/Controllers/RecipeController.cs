using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_DAW.Services.RecipeService;

namespace Proiect_DAW.Controllers
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

        [HttpGet("all")]
        public async Task<IActionResult> GetAllRecipes()
        {
            return Ok(await _recipeService.GetAllRecipes());
        }
    }
}
