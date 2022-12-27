using System.ComponentModel.DataAnnotations.Schema;

namespace BaremAbroad.Repository.Entities
{
    public class UserPassword : BaseEntity
    {
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public string HashedPassword { get; set; }
        public string PasswordSalt { get; set; }
        public virtual User? User { get; set; }
    }
}
