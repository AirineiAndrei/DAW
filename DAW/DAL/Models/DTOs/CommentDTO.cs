﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTOs
{
    public class CommentDTO
    {
        public Guid Id { get; set; }
        public string CommentText { get; set; }
    }
}
