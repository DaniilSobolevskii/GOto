using System.ComponentModel.DataAnnotations;

namespace EF;

public class Customer
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
    public DateTime? RegistrationTime{ get; set; }
}