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
    }
}
