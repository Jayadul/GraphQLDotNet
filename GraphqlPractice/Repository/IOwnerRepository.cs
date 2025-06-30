using GraphqlPractice.Contracts;
using GraphqlPractice.Entities;
using GraphqlPractice.Entities.Context;

namespace GraphqlPractice.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly ApplicationContext _context;

    public OwnerRepository(ApplicationContext context)
    {
        _context = context;
    }
    public IEnumerable<Owner> GetAll() => _context.Owners.ToList();
}
