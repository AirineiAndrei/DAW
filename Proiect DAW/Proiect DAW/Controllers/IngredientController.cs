﻿using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proiect_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IngredientController(AppDbContext context) { _context = context; }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var ans = from rela in _context.IngredientInRecipes
                      select new {rela.Recipe,rela.Ingredient}; 
            return Ok(ans);
        }
    }
}
