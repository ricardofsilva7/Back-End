using System.ComponentModel.DataAnnotations;


namespace Cafeteria.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
}