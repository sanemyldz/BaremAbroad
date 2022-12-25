using System.ComponentModel.DataAnnotations.Schema;

namespace BaremAbroad.Repository.Entities
{
    public class UserPassword
    {
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual User User { get; set; }
    }
}
