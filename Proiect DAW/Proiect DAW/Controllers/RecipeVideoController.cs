using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proiect_DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeVideoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RecipeVideoController(AppDbContext context) { _context = context; }

        [HttpGet]
        public async Task<IActionResult> GetVideos()
        {
            var Videos = from recipe in _context.Recipes
                         join video in _context.RecipeVideos
                         on recipe equals video.Recipe into reci
                         from vid in reci.DefaultIfEmpty()
                         select new
                         {
                             recipe.Title,
                             url = vid.VideoUrl,
                         };
            //var Videos = from video in _context.RecipeVideos
            //             where video != null
            //             select video;
            return Ok(Videos);
        }
    }
}
