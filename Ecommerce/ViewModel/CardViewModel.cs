using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Linq;
using System.Windows;
using DbEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class CardViewModel : ViewModelBase
{
    public UserPayment? UserPayment { get; set; } = new();
    public User? User { get; set; } = new();

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public CardViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            User = param?.Message as User;
            UserPayment = new();
        });
    }

    public RelayCommand BackCommand => new(() =>
    {
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = User });
    });


    public RelayCommand AddCardCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        {
            var FoundUserPayment = context.UserPayments.SingleOrDefault(u => u.SixteenDigitCode == UserPayment!.SixteenDigitCode);
            if (FoundUserPayment == null)
            {
                if (UserPayment != null && User != null)
                {
                    UserPayment.UserId = User.Id;
                    context.UserPayments.Add(UserPayment);
                    context.SaveChanges();
                    MessageBox.Show("Your card has been added successfully!");

                    _navigationService?.NavigateTo<CardsViewModel>(new ParameterMessage { Message = User });
                }
            }
            else MessageBox.Show("You already have this card !");
        }
    });

}