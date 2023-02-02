using DAL.Models;
using Demo.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.RecipeRepository
{
    public interface IRecipeRepository : IGenericRepository<Recipe>
    {
        public Task<List<Recipe>> FindRange(List<Guid> recipeIds);
        public Task<List<Recipe>> GetRecipesWithComments();
    }
}
