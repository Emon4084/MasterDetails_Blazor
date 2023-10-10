using MasterDetails.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterDetails.Server.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                new Product { ProductId = 1, ProductName = "Lenovo"},
                new Product { ProductId = 2, ProductName = "Hp"},
                new Product { ProductId = 3, ProductName = "Mac"}
                );
        }

    }
}
