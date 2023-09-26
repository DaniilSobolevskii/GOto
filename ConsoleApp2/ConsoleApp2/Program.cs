using System.Runtime.InteropServices.ComTypes;
using EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;



var db = new DbContextFactory().CreateDbContext(new string[] { });
var x = db.Customers.ToList();
Console.WriteLine(x.Count);
public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{ 
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        string connectionString = "Datasource=localhost; Database = test; User = root; Password = Volk5801;";
        optionsBuilder.UseMySQL(connectionString);

        return new AppDbContext(optionsBuilder.Options);
    }
}

//var customer = new Customer{Id = 100, Name ="Joni", RegistrationTime = DateTime.Now};
    //db.Customers.Add(customer);
    //var product = new Product { Id = 2, Name = "Car" };
    //db.Products.Add(product);
    //db.SaveChanges();


