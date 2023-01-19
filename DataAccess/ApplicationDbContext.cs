using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {  }

        public DbSet<Address> Addresse { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<History> HistoryOrder { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Produs> Produs { get; set; }
        public DbSet<SexType> SexType { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<User> User { get; set; }
    }
}
