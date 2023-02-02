using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Comment : BaseEntity
    {
        public string CommentText { get; set; }
        public Guid RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; } 
    }
}
