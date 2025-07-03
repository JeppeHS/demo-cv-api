namespace DemoCVApi.Models
{
    public class WorkExperience : BaseModel
    {
        public Company Company { get; set; }

        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
