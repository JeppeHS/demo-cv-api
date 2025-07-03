using DemoCVApi.GraphQL.Queries;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Types
{
    public class PublicSchema : Schema
    {

        public PublicSchema(IServiceProvider provider) : base(provider)
        {
            // Person
            Query = provider.GetRequiredService<PersonsQuery>();
        }
    }
}
