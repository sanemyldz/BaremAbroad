using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string AdminLevel { get; set; }
        public string SocialRef { get; set; }
        public string Sub { get;set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual List<BlogArticle> BlogArticles { get; set; }
        public virtual List<UserComment> UserComments { get; set; }
        public virtual UserPassword UserPassword { get; set; }
        public virtual List<Follow> Follows { get; set; }
        public virtual List<Follow> Followers { get; set; }
    }
}
