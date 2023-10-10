using BlazorMasterDetails.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace BlazorMasterDetails.Server.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
                (
                    new Product { ProductId = 1, ProductName = "Television"},
                    new Product { ProductId = 2, ProductName = "Washing machine"},
                    new Product { ProductId = 3, ProductName = "Woven"}
                );
        }
    }
}
