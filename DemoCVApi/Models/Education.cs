namespace DemoCVApi.Models
{
    public class Education : BaseModel
    {
        public string Institution { get; set; }
        public string Degree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
