using DemoCVApi.Models;

namespace DemoCVApi.DummyData
{
    public static class PersonRepository
    {
        public static List<Person> GetPersons() =>
            new List<Person>
            {
                new Person()
                {
                    Id = 1,
                    Name = "Jeppe Klynge Haugaard",
                    Initials = "JH",
                    CurrentJobTitle = "Senior Full Stack Developer",
                    Skills = SkillRepository.GetSkills(),
                    Projects = ProjectRepository.GetProjects(),
                    WorkExperiences = WorkExperienceRepository.GetWOrkExperiences(),
                    Educations = EducationRepository.GetEducations(),
                }
            };
    }
}
