using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proiect_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RecipeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("recipeById/{id}")]
        public async Task<IActionResult> GetRecipeById([FromRoute] Guid id)
        {
            var recipeById = from recipe in _context.Recipes
                             where recipe.Id == id
                             select recipe;
            return Ok(recipeById);
        }
    }
}
