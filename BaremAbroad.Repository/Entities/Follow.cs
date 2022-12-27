using System.ComponentModel.DataAnnotations.Schema;

namespace BaremAbroad.Repository.Entities
{
    public class Follow : BaseEntity
    {
        public int? FollowerId { get; set; }
        public int? FollowedUserId { get; set; }
        [NotMapped]
        public virtual User? Follower { get; set; }
        [NotMapped]
        public virtual User? FollowedUser { get; set; }
    }
}
