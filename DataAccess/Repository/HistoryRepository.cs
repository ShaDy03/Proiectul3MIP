using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class HistoryRepository : Repository<HistoryOrder>, IHistoryRepository
    {
        public HistoryRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
