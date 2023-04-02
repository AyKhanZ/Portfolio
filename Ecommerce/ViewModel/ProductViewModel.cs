using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class ProductViewModel : ViewModelBase
{
    public int Quantity { get; set; } = 1;
    public bool IsEnabledToQuantityDown { get; set; } 
    public User? User { get; set; } = new();
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
            User = UserProduct?.User;
            Product = UserProduct?.Product;

            if (Product?.Image != null) image = new BitmapImage(new Uri(Product?.Image!));

        });
    }


    public RelayCommand BuyProductCommand => new(() =>
    {
        Order? Order = new() { UserId = User!.Id, Quantity = Quantity, Date = DateTime.Now, TotalPrice = Product!.Price * Quantity };
        User?.Orders?.Add(Order);
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        ///////////////////
        MessageBox.Show("The purchase was successful");
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = User });
    });


    public RelayCommand AddToBasketCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        {
            var categoriesFromDb = context.Categories.Include(b => b.Products).ToList();

            context.Products.Remove(Product!);
            context.SaveChanges();
             
            Product!.IsInBasket = true;
            context.Products.Add(Product);
            context.SaveChanges();

            MessageBox.Show("Product has been added to basket successfully!👍");
        }
    });


    #region Quantities RelayCommands
    public RelayCommand BackToShopCommand => new(() =>
    {
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = User });
    });

    public RelayCommand DownQuantityCommand => new(() =>
    {
        if (Quantity > 1)
        {
            if (Quantity == 2) IsEnabledToQuantityDown = false;
            Quantity -= 1;
        }
    });

    public RelayCommand UpQuantityCommand => new(() =>
    {
        Quantity += 1;
        IsEnabledToQuantityDown = true;
    });
    #endregion
}