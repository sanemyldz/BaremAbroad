using BaremAbroad.Repository.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string AdminLevel { get; set; }
        public string SocialRef { get; set; }
        public string Sub { get;set; }
        public virtual ICollection<BlogArticle>? BlogArticles { get; set; }
        public virtual ICollection<UserComment>? UserComments { get; set; }
        public virtual UserPassword? UserPassword { get; set; }
        public virtual ICollection<Follow>? Follows { get; set; }
        public virtual ICollection<Follow>? Followers { get; set; }
    }
}
