using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class UnitRepository : Repository<Unit>, IUnitRepository
    {
        public UnitRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
