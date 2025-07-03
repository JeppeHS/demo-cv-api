using DemoCVApi.Models;

namespace DemoCVApi.DummyData
{
    public static class EducationRepository
    {
        public static List<Education> GetEducations() =>
            new List<Education>
            {
                new Education()
                {
                    Id = 1,
                    Institution = "Aarhus University",
                    Degree = "MSc in Computer Science",
                    StartDate = new DateTime(2011, 1, 1),
                    EndDate = new DateTime(2014, 1, 1),
                },
                new Education()
                {
                    Id = 2,
                    Institution = "Aarhus University",
                    Degree = "BSc in Computer Science",
                    StartDate = new DateTime(2008, 1, 1),
                    EndDate = new DateTime(2011, 1, 1),
                },
                new Education()
                {
                    Id = 3,
                    Institution = "Odder Gymnasium",
                    Degree = "High School Diploma (Mathematics)",
                    StartDate = new DateTime(2003, 1, 1),
                    EndDate = new DateTime(2006, 1, 1),
                }
            };
    }
}
