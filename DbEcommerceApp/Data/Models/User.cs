namespace DbEcommerceApp.Data.Models;

public class User :ISendable
{
    public int Id { get; set; }
    public string Login { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!; 
    public string Password { get; set; } = null!; 
    public string Email { get; set; } = null!;
    public byte[] Icon { get; set; } = null!;
    public bool IsAdmin { get; set; }
     
     
    public int UserDetailId { get; set; }
    public UserDetail UserDetail { get; set; } = null!;

    //
    public ICollection<Basket>? Baskets { get; set; }

    public ICollection<Order>? Orders { get; set; } 
    public ICollection<UserPayment>? UserPayments { get; set; }
}