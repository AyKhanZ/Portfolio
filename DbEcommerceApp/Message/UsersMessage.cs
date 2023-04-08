using DbEcommerceApp.Data.Models; 

namespace DbEcommerceApp.Message;

public class UsersMessage
{
    public User? SentUser { get; set; } = new();
}