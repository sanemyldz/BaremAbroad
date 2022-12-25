using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class UserComment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BlogArticleId { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public bool IsSuspended { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual BlogArticle BlogArticle { get; set; }
        public virtual List<UserCommentLog> UserCommentLogs { get; set; }
        public virtual User User { get; set; }
    }
}
