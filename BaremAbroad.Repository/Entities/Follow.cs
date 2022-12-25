using System.ComponentModel.DataAnnotations.Schema;

namespace BaremAbroad.Repository.Entities
{
    public class Follow
    {
        public int Id { get; set; }
        public int FollowerId { get; set; }
        public int FollowedUserId { get; set; }
        public DateTime CreateTime { get; set; }
        [NotMapped]
        public virtual User Follower { get; set; }
        [NotMapped]
        public virtual User FollowedUser { get; set; }
    }
}
