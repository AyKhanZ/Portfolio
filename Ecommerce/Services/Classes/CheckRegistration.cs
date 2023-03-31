using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using System.Linq;
using System.Text.RegularExpressions;
namespace UserEcommerceApp.Services.Classes;
public static class CheckRegistration
{
    public static string? CheckUser(User? user,string confPass)
    {
        if (!string.IsNullOrEmpty(user?.Name) && !string.IsNullOrEmpty(user?.Surname) &&
           !string.IsNullOrEmpty(user?.Login) && !string.IsNullOrEmpty(user?.Password) &&
           !string.IsNullOrEmpty(user?.Email))
        {
            if (Regex.IsMatch((user?.Login!), @"^[~`!@#$%^&*()_+=[\]\\{}|;':"",.\/<>?a-zA-Z0-9-]{4,15}$"))
            {
                using (var context = new EcommerceDbContext())
                {
                    var FoundUser = context.Users.SingleOrDefault(u => u.Login == user!.Login);
                    if (FoundUser != null) return "Choose another username!";
                    else
                    {
                        if (Regex.IsMatch((user?.Password!), @"^[A-Za-z0-9]{8,}$") && user!.Password!.Any(char.IsUpper) && user!.Password!.Any(char.IsLower) && user!.Password!.Any(char.IsDigit))
                        {
                            if (user.Password == confPass)
                            {
                                if (Regex.IsMatch((user?.Email!), @"^[A-Za-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{1,45}$"))
                                {
                                    if (Regex.IsMatch((user?.Surname!), @"^[A-Za-z]{3,15}$"))
                                    {
                                        if (Regex.IsMatch((user?.Name!), @"^[A-Za-z]{3,15}$")) return null;
                                        return "Name must have 3-15 symbols of alphabits\n(Ex: Aykhan)";
                                    }
                                    return "Name must have 3-15 symbols of alphabits\n(Ex: Zeynalov)";
                                }
                                return "Invalid email! Email must contain '@',digits,althabits!";
                            }
                            return "Your password and confirm password are\'t equal!";
                        }
                        return "The password must be at least 8 characters long and contain 1 digits,uppercase(A-Z) and lowercase(a-z) letters";
                    }
                }
            }
            return "Incorrect username format!\n" +
            "Username must be than 4 any simbols and must be english althabit!";
        }
        return "Line empty!";
    }
}