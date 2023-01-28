using AutoMapper;
using DAL.Models.DTOs;
using DAL.Repositories.CommentRepository;

namespace Proiect_DAW.Services.CommentService
{
    public class CommentService : ICommentService
    {
        public ICommentRepository _commentRepository;
        public IMapper _mapper;
        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }
        public async Task<List<CommentDTO>> GetAllComments()
        {
            var comments = await _commentRepository.GetAll();
            List<CommentDTO> result = _mapper.Map<List<CommentDTO>>(comments);

            return result;
        }
    }
}
