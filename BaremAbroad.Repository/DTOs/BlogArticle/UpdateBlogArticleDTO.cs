using System.Text.Json.Serialization;

namespace BaremAbroad.Repository.DTOs.BlogArticle
{
    public class UpdateBlogArticleDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int? BlogCategoryId { get; set; }
        public int? ProgramId { get; set; }
        private int upVotes = 0;
        [JsonIgnore]
        public int UpVotes { get => upVotes; set => upVotes = value; }
        private int downVotes = 0;
        [JsonIgnore]
        public int DownVotes { get => downVotes; set => downVotes = value; }
        public string Content { get; set; }
        private string lang = "TR";
        [JsonIgnore]
        public string Lang { get => lang; set => lang = value; }
    }
}
