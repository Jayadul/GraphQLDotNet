using GraphQL.Types;
using GraphqlPractice.Contracts;
using GraphqlPractice.GraphQL.GraphQLTypes;

namespace GraphqlPractice.GraphQL.GraphQLQueries;

public class AppQuery: ObjectGraphType
{
    public AppQuery(IOwnerRepository repository)
    {
        Field<ListGraphType<OwnerType>>("owners")
            .Resolve(context => repository.GetAll());
    }
}
