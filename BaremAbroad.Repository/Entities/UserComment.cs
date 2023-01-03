namespace BaremAbroad.Repository.Entities
{
    public class UserComment : BaseEntity
    {
        public int? UserId { get; set; }
        public int? BlogArticleId { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public bool IsSuspended { get; set; }
        public virtual BlogArticle? BlogArticle { get; set; }
        public virtual ICollection<UserCommentLog>? UserCommentLogs { get; set; }
        public virtual User? User { get; set; }
    }
}
