using DemoCVApi.DummyData;
using DemoCVApi.GraphQL.Types;
using GraphQL.Types;

namespace DemoCVApi.GraphQL.Queries
{
    public class PersonsQuery : ObjectGraphType
    {
        public PersonsQuery()
        {
            Field<ListGraphType<PersonType>>(
                "persons",
                resolve: context => PersonRepository.GetPersons()
            );
        }
    }
}
