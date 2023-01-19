using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class SexTypeRepository : Repository<SexType>, ISexTypeRepository
    {
        public SexTypeRepository(ApplicationDbContext db) : base(db)
        {}
    }
}
