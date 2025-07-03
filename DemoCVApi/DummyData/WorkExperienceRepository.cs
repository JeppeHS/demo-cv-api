using DemoCVApi.Models;

namespace DemoCVApi.DummyData
{
    public static class WorkExperienceRepository
    {
        public static List<WorkExperience> GetWOrkExperiences() =>
            new List<WorkExperience>
            {
                new WorkExperience()
                {
                    Id = 1,
                    Company = CompanyRepository.GetCompany(1),
                    JobTitle = "Full Stack Developer & Co-owner",
                    StartDate = new DateTime(2025, 1, 1),
                },
                new WorkExperience()
                {
                    Id = 2,
                    Company = CompanyRepository.GetCompany(2),
                    JobTitle = "Full Stack Developer",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2025, 1, 1)
                },
                new WorkExperience()
                {
                    Id = 3,
                    Company = CompanyRepository.GetCompany(3),
                    JobTitle = "Software Engineer",
                    StartDate = new DateTime(2021, 1, 1),
                    EndDate = new DateTime(2022, 1, 1)
                },
                new WorkExperience()
                {
                    Id = 4,
                    Company = CompanyRepository.GetCompany(4),
                    JobTitle = "Full Stack Developer",
                    StartDate = new DateTime(2017, 1, 1),
                    EndDate = new DateTime(2021, 1, 1)
                },
                new WorkExperience()
                {
                    Id = 5,
                    Company = CompanyRepository.GetCompany(5),
                    JobTitle = "Developer",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2021, 1, 1)
                },
                new WorkExperience()
                {
                    Id = 6,
                    Company = CompanyRepository.GetCompany(6),
                    JobTitle = "IT Consultant",
                    StartDate = new DateTime(2014, 1, 1),
                    EndDate = new DateTime(2014, 1, 1)
                }
            };
    }
}
