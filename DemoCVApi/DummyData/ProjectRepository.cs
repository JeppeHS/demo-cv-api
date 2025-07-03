using DemoCVApi.Models;

namespace DemoCVApi.DummyData
{
    public static class ProjectRepository
    {
        public static List<Project> GetProjects() =>
            new List<Project>
            {
                new Project()
                {
                    Id = 1,
                    Description = "Dynamics Business Central integration",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                },
                new Project()
                {
                    Id = 2,
                    Description = "Economic integration",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                },
                new Project()
                {
                    Id = 3,
                    Description = "Uniconta integration",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                },
                new Project()
                {
                    Id = 4,
                    Description = "Simplero integration",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                },
                new Project()
                {
                    Id = 5,
                    Description = "Frisbii integration",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                },
                new Project()
                {
                    Id = 6,
                    Description = "Stripe integration",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                },
                new Project()
                {
                    Id = 7,
                    Description = "Invoicing module",
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 1, 1),
                }
            };
    }
}

