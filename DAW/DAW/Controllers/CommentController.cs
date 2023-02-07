using DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAW.Services.CommentService;

namespace DAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(await _commentService.GetAllComments());
        }
    }
}
