namespace BaremAbroad.Repository.Entities
{
    public class UserCommentLog : BaseEntity
    {
        public int? UserCommentId { get; set; }
        public string Content { get; set; }
        public UserComment? UserComment { get; set; }
    }
}
