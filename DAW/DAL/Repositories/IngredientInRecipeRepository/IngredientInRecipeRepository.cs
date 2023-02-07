using DAL.Data;
using DAL.Models;
using Demo.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IngredientInRecipeRepository
{
    public class IngredientInRecipeRepository : GenericRepository<IngredientInRecipe> , IIngredientInRecipeRepository
    {
        public IngredientInRecipeRepository(AppDbContext context) : base(context) { }
        public void DeleteIngredientForRecipe(Recipe recipe)
        {
            var toDelete = from elem in _context.IngredientInRecipes
                           where elem.RecipeId == recipe.Id
                           select elem;
            _context.IngredientInRecipes.RemoveRange(toDelete);
        }
    }
}
