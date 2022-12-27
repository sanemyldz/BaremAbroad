namespace BaremAbroad.Repository.Entities
{
    public class ContentDetail : BaseEntity
    {
        public string Title { get; set; }
        public int? ProgramId { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }
        public Program? Program { get; set; }
    }
}
