using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
namespace UserEcommerceApp.Services.Classes;
internal class NavigationService : INavigationService
{
    private readonly IMessenger _messenger;
    public NavigationService(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void NavigateTo<T>(ParameterMessage? message) where T : ViewModelBase
    {
        _messenger.Send(message);
        _messenger.Send(new NavigationMessage() { ViewModelType = typeof(T) });
    }
    public void NavigateTo<T>(UsersMessage? message) where T : ViewModelBase
    {
        _messenger.Send(message);
        _messenger.Send(new NavigationMessage() { ViewModelType = typeof(T) });
    }
}