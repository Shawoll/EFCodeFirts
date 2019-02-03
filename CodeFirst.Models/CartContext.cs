using System;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options)
        : base(options)
        {

        }

        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasData(
            new Cart
            {
                Id = 1,
                CreatedDate = DateTime.UtcNow,
                Description = "Casual shopping",
                Title = "1 week buy shopping",
                Price = 100
            },
            new Cart
            {
                Id = 2,
                CreatedDate = DateTime.UtcNow,
                Description = "Mid week shopping",
                Title = "Buying some good stuff",
                Price = 50
            });
        }
    }

}
