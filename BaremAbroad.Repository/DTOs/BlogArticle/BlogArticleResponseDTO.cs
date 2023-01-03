namespace BaremAbroad.Repository.DTOs.BlogArticle
{
    public class BlogArticleResponseDTO
    {
        public int Id { get; set; }
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
