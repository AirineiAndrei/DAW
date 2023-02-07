using DAL.Models.DTOs;

namespace DAW.Services.CommentService
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetAllComments();
    }
}
