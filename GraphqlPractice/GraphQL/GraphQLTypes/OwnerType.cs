using GraphQL.Types;
using GraphqlPractice.Entities;

namespace GraphqlPractice.GraphQL.GraphQLTypes;

public class OwnerType : ObjectGraphType<Owner>
{
    public OwnerType()
    {
        Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
        Field(x => x.Name).Description("Name property from the owner object.");
        Field(x => x.Address).Description("Address property from the owner object.");
    }
}
