using Apagame.shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apagame.backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Define DbSet properties for your entities
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entities here
            modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();
        }

    }
}
