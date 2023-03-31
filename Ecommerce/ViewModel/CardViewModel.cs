using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class CardViewModel : ViewModelBase
{
    public UserPayment? UserPayment { get; set; } = new();
    public User? user { get; set; } = new();

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public CardViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            user = param?.Message as User;
        });
    }

    public RelayCommand BackCommand => new(() =>
    { 
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = user });
    });
    
    
    public RelayCommand AddMoneyCommand => new(() =>
    {
        user!.UserPayment = UserPayment;
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = user });
    });
    
}