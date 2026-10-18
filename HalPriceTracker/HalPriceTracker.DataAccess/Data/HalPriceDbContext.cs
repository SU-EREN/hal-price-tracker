
using HalPriceTracker.Models;
using Microsoft.EntityFrameworkCore;


namespace HalPriceTracker.DataAccess.Data
{
    public class HalPriceDbContext : DbContext
    {
        public HalPriceDbContext(DbContextOptions<HalPriceDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Price> Prices { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.SourceProductId)
                    .IsUnique();



            modelBuilder.Entity<Price>()
                .HasIndex(p => new { p.ProductId, p.Date })
                    .IsUnique();
            modelBuilder.Entity<Price>()
                .Property(p => p.MinPrice)
                    .HasPrecision(10, 2);
            modelBuilder.Entity<Price>()
            .Property(p => p.MaxPrice)
                    .HasPrecision(10, 2);
            modelBuilder.Entity<Price>()    
            .Property(p => p.AveragePrice)
                    .HasPrecision(10, 2);
            modelBuilder.Entity<Category>()
                .HasIndex(c => c.SourceCategoryId)
                    .IsUnique();

        }
    }
}

  
