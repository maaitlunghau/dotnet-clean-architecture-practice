using CLEAN_DOMAIN.Entities;

namespace CLEAN_APPLICATION.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();

    Task<User?> GetByIdAsync(Guid id);

    Task AddAsync(User user);

    Task UpdateAsync(User user);

    Task DeleteAsync(User user);
}
