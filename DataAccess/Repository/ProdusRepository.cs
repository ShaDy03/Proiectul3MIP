using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class ProdusRepository : Repository<Produs>, IProdusRepository
    {
        public ProdusRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
