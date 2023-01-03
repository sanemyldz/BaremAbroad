namespace BaremAbroad.Repository.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public int AdminLevel { get; set; }
        public string? SocialRef { get; set; }
        public string? Sub { get; set; }
        public virtual ICollection<BlogArticle> BlogArticles { get; set; }
        public virtual ICollection<UserComment> UserComments { get; set; }
        public virtual UserPassword UserPassword { get; set; }
        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<Follow> Followers { get; set; }
    }
}
