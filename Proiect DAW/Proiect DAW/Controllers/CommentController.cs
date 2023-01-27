using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proiect_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CommentController(AppDbContext context) { _context = context; }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var ans = from recipe in _context.Recipes
            //          join com in _context.Comments
            //          on recipe equals com.Recipe
            //          select new
            //          {
            //              recipe.Id,
            //              com
            //          };
            var ans = from ceva in _context.Recipes
                      select ceva.Comments;
            return Ok(ans);
        }
    }
}
