using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly ApplicationDbContext _db;
        public IAddressRepository Address { get; private set; }
        public IBrandRepository Brand { get; private set; }
        public ICityRepository City { get; private set; }
        public ICountryRepository Country { get; private set; }
        public IHistoryRepository History { get; private set; }
        public IImageRepository Image { get; private set; }
        public IProdusRepository Produs { get; private set; }
        public ISexTypeRepository SexType { get; private set; }
        public IUnitRepository Unit { get; private set; }
        public IUserRepository User { get; private set; }

        public UnitOfWorks(ApplicationDbContext db)
        {
            _db = db;
            Address = new AddressRepositry(_db);
            Brand = new BrandRepository(_db);
            City = new CityRepository(_db);
            Country = new CountryRepository(_db);
            History = new HistoryRepository(_db);
            Image = new ImageRepository(_db);
            Produs = new ProdusRepository(_db);
            SexType = new SexTypeRepository(_db);
            Unit = new UnitRepository(_db);
            User = new UserRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
