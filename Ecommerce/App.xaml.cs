using UserEcommerceApp.Services.Interfaces;
using UserEcommerceApp.Services.Classes;
using UserEcommerceApp.View;
using UserEcommerceApp.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector; 
using System.Windows; 
namespace UserEcommerceApp;
public partial class App : Application
{
    public static Container? Container { get; internal set; }
    protected override void OnStartup(StartupEventArgs e)
    {
        Register();

        MainStartup();

        base.OnStartup(e);
    }

    private void Register()
    {
        Container = new();

        Container.RegisterSingleton<IMessenger, Messenger>();
        Container.RegisterSingleton<INavigationService, NavigationService>();

        Container.RegisterSingleton<MainViewModel>();
        Container.RegisterSingleton<LoginViewModel>(); 
        Container.Register<RegistrationViewModel>();
        Container.RegisterSingleton<HomeViewModel>();
        Container.RegisterSingleton<ProductViewModel>();
        Container.RegisterSingleton<CardViewModel>();
        Container.RegisterSingleton<CardsViewModel>();
        Container.RegisterSingleton<SelectedCardViewModel>();
        Container.RegisterSingleton<OrdersViewModel>();
        Container.RegisterSingleton<BasketViewModel>();

        Container.Verify();
    }

    private void MainStartup()
    {
        Window mainView = new MainView();

        mainView.DataContext = Container?.GetInstance<MainViewModel>();

        mainView.ShowDialog();
    }
}
