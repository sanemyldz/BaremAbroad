using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.DTOs
{
    public class BlogArticleDTO
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int? BlogCategoryId { get; set; }
        public int? ProgramId { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
        public string Content { get; set; }
        public string Lang { get; set; }

    }
}
