using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTOs
{
    public class RecipeDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public TimeSpan CookTime { get; set; } = TimeSpan.Zero;
        public TimeSpan TotalTime { get; set; } = TimeSpan.Zero;

    }
}
