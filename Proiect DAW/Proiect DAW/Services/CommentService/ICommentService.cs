using DAL.Models.DTOs;

namespace Proiect_DAW.Services.CommentService
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetAllComments();
    }
}
