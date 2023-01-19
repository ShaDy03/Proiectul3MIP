using DataAccess.Repository.Interface;
using Models;

namespace DataAccess.Repository
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(ApplicationDbContext db) : base(db)
        { }
    }
}
