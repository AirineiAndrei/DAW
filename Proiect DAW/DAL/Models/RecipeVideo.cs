﻿using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class RecipeVideo : BaseEntity
    {
        public Guid RecipeId { get; set; }  
        public string VideoUrl { get; set; }    
        public virtual Recipe Recipe { get; set; }
    }
}
