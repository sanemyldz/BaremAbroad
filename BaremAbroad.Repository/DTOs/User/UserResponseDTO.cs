namespace BaremAbroad.Repository.DTOs.User
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public int AdminLevel { get; set; }
        public string? SocialRef { get; set; }
        public string? Sub { get; set; }
        //public UserPasswordDTO UserPassword { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
