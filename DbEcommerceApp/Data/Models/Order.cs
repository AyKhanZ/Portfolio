namespace DbEcommerceApp.Data.Models;
public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public bool OrderStatus { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<OrderProduct>? OrderProducts { get; set; }
}