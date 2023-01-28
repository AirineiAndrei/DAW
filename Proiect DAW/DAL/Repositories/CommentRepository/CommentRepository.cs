using DAL.Data;
using DAL.Models;
using Demo.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.CommentRepository
{
    public class CommentRepository : GenericRepository<Comment> , ICommentRepository
    {
        public CommentRepository (AppDbContext context) : base(context) { } 
    }
}
