namespace BaremAbroad.Repository.DTOs
{
    public class UserPasswordDTO
    {
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }
    }
}
