namespace BaremAbroad.Repository.Entities
{
    public class ContentDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ProgramId { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Lang { get; set; }
        public Program Program { get; set; }
    }
}
