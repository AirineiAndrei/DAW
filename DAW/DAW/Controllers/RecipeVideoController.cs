using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAW.Controllers
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
            var Videos = _context.Recipes.GroupBy(x => x.Title)
                                         .Select(group => new
                                         {
                                             title = group.Key,
                                             cnt = group.Count()
                                         });
                         
            //var Videos = from video in _context.RecipeVideos
            //             where video != null
            //             select video;
            return Ok(Videos);
        }
    }
}
