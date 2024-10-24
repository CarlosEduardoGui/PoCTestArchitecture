using PoCTestArchitecture.Domain.Entities;
using PoCTestArchitecture.Domain.Repositories;

namespace PoCTestArchitecture.Infrastructure.Repository;
public class UserRepository : IUserRepository
{
    public Task<User> InsertAsync(User entity)
    {
        throw new NotImplementedException();
    }
}
