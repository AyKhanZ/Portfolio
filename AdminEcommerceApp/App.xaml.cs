using AdminEcommerceApp.Services.Interfaces;
using AdminEcommerceApp.Services.Classes;
using AdminEcommerceApp.View; 
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using System.Windows;
using AdminEcommerceApp.ViewModel;

namespace AdminEcommerceApp;

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
        Container.RegisterSingleton<AllProductsViewModel>(); 
        Container.RegisterSingleton<LoginViewModel>();  
        Container.RegisterSingleton<ProductViewModel>();  
        Container.RegisterSingleton<AddProductViewModel>();  
        Container.RegisterSingleton<AddCategoryViewModel>();  

        Container.Verify();
    }

    private void MainStartup()
    {
        Window mainView = new MainView();

        mainView.DataContext = Container?.GetInstance<MainViewModel>();

        mainView.ShowDialog();
    }
}