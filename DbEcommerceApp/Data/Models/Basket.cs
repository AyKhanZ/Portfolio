namespace DbEcommerceApp.Data.Models;

public class Basket
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public ICollection<BasketProduct>? BasketProducts { get; set; }
}