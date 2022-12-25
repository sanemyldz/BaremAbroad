using System.ComponentModel.DataAnnotations;

namespace BaremAbroad.Repository.Entities
{
    public class BlockedWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public DateTime CreateTime { get; set; }
        public string Lang { get; set; }
    }
}
