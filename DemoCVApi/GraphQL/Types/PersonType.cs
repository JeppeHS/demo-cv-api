using DemoCVApi.Models;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Initials);
            Field(p => p.CurrentJobTitle);

            Field<ListGraphType<NonNullGraphType<EducationType>>>(
                "educations",
                resolve: context => context.Source.Educations
            );
            Field<ListGraphType<NonNullGraphType<SkillType>>>(
                "skills",
                resolve: context => context.Source.Skills
            );
            Field<ListGraphType<NonNullGraphType<ProjectType>>>(
                "projects",
                resolve: context => context.Source.Projects
            );
            Field<ListGraphType<NonNullGraphType<WorkExperienceType>>>(
                "workExperiences",
                resolve: context => context.Source.WorkExperiences
            );
        }
    }
}
