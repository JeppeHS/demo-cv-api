using DemoCVApi.Models;

namespace DemoCVApi.DummyData
{
    public static class SkillRepository
    {
        public static List<Skill> GetSkills() =>
            new List<Skill>
            {
                new Skill()
                {
                    Id = 1,
                    Name = "React (with Typescript)",
                    Description = "",
                    Level ="Proficient/Expert"
                },
                new Skill()
                {
                    Id = 2,
                    Name = "C# (.NET)",
                    Description = "",
                    Level ="Advanced"
                },
                new Skill()
                {
                    Id = 3,
                    Name = "Ruby on Rails",
                    Description = "",
                    Level ="Proficient"
                },
                new Skill()
                {
                    Id = 4,
                    Name = "AWS",
                    Description = "",
                    Level ="Competent"
                },
                new Skill()
                {
                    Id = 5,
                    Name = "Azure",
                    Description = "",
                    Level ="Intermediate"
                },
                new Skill()
                {
                    Id = 6,
                    Name = "Dynamics 365",
                    Description = "",
                    Level ="Intermediate"
                },
                new Skill()
                {
                    Id = 7,
                    Name = "Economic",
                    Description = "",
                    Level ="Intermediate"
                }
            };
    }
}

