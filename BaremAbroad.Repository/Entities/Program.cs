using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class Program : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SchoolId { get; set; }
        public string Lang { get; set; }
        public ICollection<BlogArticle>? BlogArticles { get; set; }
        public School? School { get; set; }
        public ICollection<ContentDetail>? ContentDetails { get; set; }
    }
}
