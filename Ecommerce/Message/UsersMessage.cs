using DbEcommerceApp.Data.Models; 
namespace UserEcommerceApp.Message;
public class UsersMessage
{
    public User? SentUser { get; set; } = new();
}