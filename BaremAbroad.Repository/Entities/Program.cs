using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Repository.Entities
{
    public class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SchoolId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Lang { get; set; }
        public List<BlogArticle> BlogArticles { get; set; }
        public School School { get; set; }
        public List<ContentDetail> ContentDetails { get; set; }
    }
}
