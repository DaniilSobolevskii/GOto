using System.ComponentModel.DataAnnotations.Schema;

namespace EF;


[Table(("business_products"))]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}