using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
