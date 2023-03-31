using UserEcommerceApp.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace UserEcommerceApp.ViewModel;

public class MainViewModel : ViewModelBase
{
    public ViewModelBase? CurrentViewModel { get; set; }

    private readonly IMessenger _messenger;

    public MainViewModel(IMessenger messenger)
    {
        CurrentViewModel = App.Container?.GetInstance<LoginViewModel>();

        _messenger = messenger;

        _messenger.Register<NavigationMessage?>(this, message =>
        {
            var viewModel = App.Container?.GetInstance(message?.ViewModelType!) as ViewModelBase;
            CurrentViewModel = viewModel;
        });
    }
    public WindowState State { get; set; } 
    public RelayCommand ExitCommand => new(() =>
    { 
        App.Current.Shutdown();
    });
    
    public RelayCommand MinimalizeCommand  => new(() =>
    {
        State = WindowState.Minimized;
    });
    
}