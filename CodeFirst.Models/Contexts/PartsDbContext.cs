using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

public class PartsDbContext : DbContext
{
    public DbSet<EmployeeContext> Employees { get; set; }
    public DbSet<CartContext> Carts { get; set; }
    public DbSet<CartItemContext> CartItems { get; set; }

    public PartsDbContext(DbContextOptions<PartsDbContext> options)
        : base(options)
    {
    }
}