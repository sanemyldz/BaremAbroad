namespace BaremAbroad.Repository.DTOs
{
    public class UserCommentDTO
    {
        public int? UserId { get; set; }
        public int? BlogArticleId { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public bool IsSuspended { get; set; }
    }
}
