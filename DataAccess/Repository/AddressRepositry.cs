using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class AddressRepositry : Repository<Address>, IAddressRepository
    {
        public AddressRepositry(ApplicationDbContext db) : base(db)
        { }
    }
}
