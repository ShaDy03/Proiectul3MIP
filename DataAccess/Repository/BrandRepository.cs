using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
