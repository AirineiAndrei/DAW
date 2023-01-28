﻿using AutoMapper;
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
        
    }
}
