using DemoCVApi.Models;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Field(p => p.Id);
            Field(p => p.Institution);
            Field(p => p.Degree);
            Field(p => p.StartDate);
            Field(p => p.EndDate);
        }
    }
}