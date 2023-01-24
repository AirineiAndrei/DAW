using DAL.Data;
using DAL.Models;
using Demo.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.RecipeRepository
{
    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(AppDbContext context) : base(context) { }

        public async Task<List<Recipe>> FindRange(List<Guid> recipeIds)
        {
            return await _table.Where(x => recipeIds.Contains(x.Id)).ToListAsync();
        }
    }
}
