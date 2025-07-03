namespace DemoCVApi.Models
{
    public class Project : BaseModel
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
