using Microsoft.EntityFrameworkCore;

namespace EF;
using Microsoft.EntityFrameworkCore.Design;
using Version = System.Version;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> optionsBuilderOptions) : base(optionsBuilderOptions)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("customer");
        modelBuilder.Entity<Customer>().Property(c => c.Id).HasColumnName("idCustomer");
        modelBuilder.Entity<Customer>().Property(p => p.Name).HasColumnName("Name");
        modelBuilder.Entity<Customer>().Property(p => p.RegistrationTime).HasColumnName("RegistrationTime");
        modelBuilder.Entity<Customer>().Property(p => p.RegistrationTime).HasPrecision(2);

        modelBuilder.Entity<Product>().Property(p => p.Id).HasColumnName("idBusinessProduct");

    }
}