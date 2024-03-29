﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models.Base;

namespace DAL.Models
{
    public class Recipe : BaseEntity
    {
        public string Title { get; set; }
        public string? Instructions { get; set; }
        public TimeSpan? CookTime { get; set; }
        public TimeSpan? TotalTime { get; set; }
        public virtual RecipeVideo Video { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<IngredientInRecipe> Ingredients { get; set;}
    }
}
