using System;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class CartItemContext : DbContext
    {
        public CartItemContext(DbContextOptions<CartItemContext> options) 
        : base(options)
        {

        }

        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>().HasData(
            new CartItem
            {
                Id = 1,
                Name = "Snack",
                Description = "Cheat day",
                Weight = 100,
                Calories = 150,
                Fats = 100,
                Proteins = 100,
                Sacharides = 100,
                PurchaseDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddDays(10)
            },
            new CartItem
            {
                Id = 2,
                Name = "Healthy",
                Description = "xxx",
                Weight = 222,
                Calories = 333,
                Fats = 111,
                Proteins = 222,
                Sacharides = 333,
                PurchaseDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddDays(10)
            }
           );
        }
    }
}
