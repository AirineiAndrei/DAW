using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class IngredientInRecipe
    {
        public Guid RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
        public Guid IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
