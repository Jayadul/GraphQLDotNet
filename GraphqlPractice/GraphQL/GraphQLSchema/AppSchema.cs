using GraphQL.Types;
using GraphqlPractice.GraphQL.GraphQLQueries;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GraphqlPractice.GraphQL.GraphQLSchema;

public class AppSchema : Schema
{
    public AppSchema(IServiceProvider provider)
        : base(provider)
    {
        Query = provider.GetRequiredService<AppQuery>();
    }
}
