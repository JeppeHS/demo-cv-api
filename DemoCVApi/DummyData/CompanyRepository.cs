using DemoCVApi.Models;

namespace DemoCVApi.DummyData
{
    public static class CompanyRepository
    {
        public static List<Company> GetCompanies() =>
            new List<Company>
            {
                new Company()
                {
                    Id = 1,
                    Name = "Syntastic ApS"
                },
                new Company()
                {
                    Id = 2,
                    Name = "Somebody ApS"
                },
                new Company()
                {
                    Id = 3,
                    Name = "TERMA"
                },
                new Company()
                {
                    Id = 4,
                    Name = "FlightLogger ApS"
                },
                new Company()
                {
                    Id = 5,
                    Name = "Duka"
                },
                new Company()
                {
                    Id = 6,
                    Name = "IT Minds"
                }
            };

        public static Company GetCompany(int id) => GetCompanies().FirstOrDefault(c => c.Id == id);
    }
}
