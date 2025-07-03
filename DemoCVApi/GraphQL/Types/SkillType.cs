using DemoCVApi.Models;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Description);
            Field(p => p.Level);
        }
    }
}