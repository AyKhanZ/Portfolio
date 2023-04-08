using AdminEcommerceApp.Services.Interfaces;
using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using DbEcommerceApp.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AdminEcommerceApp.ViewModel;

public class LoginViewModel : ViewModelBase
{
    public User? User { get; set; } = new();

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public LoginViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            User = param?.Message as User;
        });
    }

    public RelayCommand<PasswordBox> LoginCommand => new((pass) =>
    {
        using (var context = new EcommerceDbContext())
        {
            var FoundAdmin = context.Users.SingleOrDefault(u => u.Login == User!.Login);
            if (FoundAdmin != null && FoundAdmin.IsAdmin)
            {
                if (FoundAdmin?.Password == pass.Password)
                {
                    _navigationService?.NavigateTo<AllProductsViewModel>(new ParameterMessage { Message = FoundAdmin });
                }
                else MessageBox.Show("Incorrect password!");
            } 
            else MessageBox.Show("You aren\'t an admin!");
        }
    });

}