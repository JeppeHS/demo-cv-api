using DemoCVApi.Models;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Field(p => p.Id);
            Field(p => p.Description);
            Field(p => p.StartDate);
            Field(p => p.EndDate);

        }   
    }
}