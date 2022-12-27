namespace BaremAbroad.Repository.Entities
{
    public class BlogCategory : BaseEntity
    {
        public string Name { get; set; }
        public int BlogCount { get; set; }
        public string Lang { get; set; }
        public virtual ICollection<BlogArticle>? BlogArticles { get; set; }
    }
}
