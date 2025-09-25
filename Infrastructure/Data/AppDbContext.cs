using Microsoft.EntityFrameworkCore;
using Core.Domain;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Package> Packages => Set<Package>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Canteen> Canteens => Set<Canteen>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            // fluent config / relaties / indices etc.
        }
    }
}
