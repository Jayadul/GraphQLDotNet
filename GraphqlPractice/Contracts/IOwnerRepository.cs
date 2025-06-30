using GraphqlPractice.Entities;

namespace GraphqlPractice.Contracts;

public interface IOwnerRepository
{
    IEnumerable<Owner> GetAll();
}
