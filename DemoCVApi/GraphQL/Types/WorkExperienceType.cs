using DemoCVApi.Models;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class WorkExperienceType : ObjectGraphType<WorkExperience>
    {
        public WorkExperienceType()
        {
            Field(p => p.Id);
            Field(p => p.JobTitle);
            Field(p => p.StartDate);
            Field(p => p.EndDate);
            Field<CompanyType>(
                "company",
                resolve: context => context.Source.Company
            );
        }
    }
}