﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTOs
{
    public class IngredientDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Unit { get; set; }
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
    }
}
