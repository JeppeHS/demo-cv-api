namespace DemoCVApi.Models
{
    public class Person : BaseModel
    {
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public List<Education> Educations { get; set; } = new List<Education>();

        public string Name { get; set; }
        public string Initials { get; set; }
        public string CurrentJobTitle { get; set; }
    }
}
