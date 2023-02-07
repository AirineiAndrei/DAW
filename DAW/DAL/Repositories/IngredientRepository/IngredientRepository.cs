using DAL.Data;
using DAL.Models;
using Demo.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IngredientRepository
{
    public class IngredientRepository : GenericRepository<Ingredient> , IIngredientRepository
    {
        public IngredientRepository(AppDbContext context) : base(context) { }
        public async Task<List<Ingredient>> GetIngredientsForRecipe(Recipe recipe)
        {
            return await (from ingredient in _context.Ingredients
                          join inginrec in _context.IngredientInRecipes on ingredient equals inginrec.Ingredient
                          where inginrec.Recipe == recipe
                          select ingredient).ToListAsync();
        }
    }
}
