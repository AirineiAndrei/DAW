using DAL.Models;
using Demo.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IngredientInRecipeRepository
{
    public interface IIngredientInRecipeRepository : IGenericRepository<IngredientInRecipe>
    {
        void DeleteIngredientForRecipe(Recipe recipe);
    }
}
