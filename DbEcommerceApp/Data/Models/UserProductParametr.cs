namespace DbEcommerceApp.Data.Models;
public record class UserProductParameter(User User, Product Product) : ISendable { }