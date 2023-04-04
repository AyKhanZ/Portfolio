namespace DbEcommerceApp.Data.Models;

public class BasketProduct
{
    public int BasketId { get; set; }
    public Basket Basket { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
