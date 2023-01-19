using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class HistoryRepository : Repository<History>, IHistoryRepository
    {
        public HistoryRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
