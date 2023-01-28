using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_DAW.Services.IngredientService;

namespace Proiect_DAW.Controllers
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
    }
}
