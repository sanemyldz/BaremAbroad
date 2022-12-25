﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class UserCommentLog
    {
        public int Id { get; set; }
        public int UserCommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public UserComment UserComment { get; set; }
    }
}