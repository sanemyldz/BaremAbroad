namespace BaremAbroad.Repository.Entities
{
    public class Faq : BaseEntity
    {
        public string Question { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }
    }
}
