﻿using DAL.Data;
using DAL.Models;
using Demo.Repository.GenericRepository;
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
    }
}
