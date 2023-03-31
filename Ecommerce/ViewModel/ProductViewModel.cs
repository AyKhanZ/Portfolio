using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Windows.Media.Imaging;
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class ProductViewModel : ViewModelBase
{
    public User? user { get; set; } = new();
    public Product? Product { get; set; } = new();
    public BitmapImage? image { get; set; } = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "Images/no_product.jpg"));

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public ProductViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            var UserProduct = param?.Message as UserProductParameter;
            user = UserProduct?.User;
            Product = UserProduct?.Product;

            if (Product?.Image != null) image = new BitmapImage(new Uri(Product?.Image!));

        });
    }

    public RelayCommand BuyProductCommand => new(() =>
    {
        //////////////
        ////////////// 
        ////////////// 
        //////////////
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = user });
    }); 

    public RelayCommand BackToShopCommand => new(() =>
    {
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = user });
    }); 
}