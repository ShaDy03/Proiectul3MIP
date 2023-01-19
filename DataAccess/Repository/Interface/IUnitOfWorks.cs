namespace DataAccess.Repository.Interface
{
    public interface IUnitOfWorks : IDisposable
    {
        public IAddressRepository Address { get; }
        public IBrandRepository Brand { get; }
        public ICityRepository City { get; }
        public ICountryRepository Country { get; }
        public IHistoryRepository History { get; }
        public IImageRepository Image { get; }
        public IProdusRepository Produs { get; }
        public ISexTypeRepository SexType { get; }
        public IUnitRepository Unit { get; }
        public IUserRepository User { get; }
    }
}
