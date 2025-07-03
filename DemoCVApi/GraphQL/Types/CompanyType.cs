using DemoCVApi.Models;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
        }
    }
}