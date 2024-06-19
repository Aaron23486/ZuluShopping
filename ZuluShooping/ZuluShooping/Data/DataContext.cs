using Microsoft.EntityFrameworkCore;
using ZuluShooping.Data.Entities;

namespace ZuluShooping.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<Canton> Cantones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Province>().HasIndex("Name", "CountryId").IsUnique();
            modelBuilder.Entity<Canton>().HasIndex("Name", "ProvinceId").IsUnique();
        }

    }
}
