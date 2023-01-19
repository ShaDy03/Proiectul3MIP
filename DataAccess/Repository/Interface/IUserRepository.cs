using Models;

namespace DataAccess.Repository.Interface
{
    public interface IUserRepository : Repository<User>, IUserRepository
    {}
}
