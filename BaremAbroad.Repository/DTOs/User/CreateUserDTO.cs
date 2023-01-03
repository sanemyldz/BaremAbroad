using System.Text.Json.Serialization;

namespace BaremAbroad.Repository.DTOs.User
{
    public class CreateUserDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        private int adminLevel = 16;
        [JsonIgnore]
        public int AdminLevel { get => adminLevel; set => adminLevel = value; }
        [JsonIgnore]
        public string? SocialRef { get; set; }
        [JsonIgnore]
        public string? Sub { get; set; }
        [JsonIgnore]
        public UserPasswordDTO? UserPassword { get; set; }
    }
}
