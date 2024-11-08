using Microsoft.EntityFrameworkCore;
using Web.Entities;

namespace Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextoptions) : base(dbContextoptions)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "High performance laptop", Price = 1200.99m },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 799.99m },
                new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 199.99m },
                new Product { Id = 4, Name = "Smartwatch", Description = "Waterproof smartwatch with GPS", Price = 249.99m },
                new Product { Id = 5, Name = "Tablet", Description = "10-inch tablet with high resolution display", Price = 329.99m }
            };
            builder.Entity<Product>().HasData(products);

            base.OnModelCreating(builder);
        }
    }
}
