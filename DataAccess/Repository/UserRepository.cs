using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
