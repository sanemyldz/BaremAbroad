namespace BaremAbroad.Repository.Entities
{
    public class BlogCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlogCount { get; set; }
        public string Lang { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual List<BlogArticle> BlogArticles { get; set; }
    }
}
