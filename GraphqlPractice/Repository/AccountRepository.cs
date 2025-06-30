using GraphqlPractice.Contracts;
using GraphqlPractice.Entities.Context;

namespace GraphqlPractice.Repository;

public class AccountRepository : IAccountRepository
{
    private readonly ApplicationContext _context;

    public AccountRepository(ApplicationContext context)
    {
        _context = context;
    }
}