using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
