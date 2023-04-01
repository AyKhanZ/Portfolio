namespace DbEcommerceApp.Data.Models;

public class UserPayment
{
    public int Id { get; set; }
    public string CVV { get; set; } = null!;
    public string EXP { get; set; } = null!;
    public string SixteenDigitCode { get; set; } = null!;

    public int UserId { get; set; }
    public User? User { get; set; }
}