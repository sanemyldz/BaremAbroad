using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class BlogArticle : BaseEntity
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
        public virtual BlogCategory? BlogCategory { get; set; }
        public virtual Program? Program { get; set; }
        public virtual ICollection<UserComment>? UserComments { get; set; }
        public virtual User? User { get; set; }
    }
}
