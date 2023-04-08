using AdminEcommerceApp.Services.Interfaces;
using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using DbEcommerceApp.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace AdminEcommerceApp.ViewModel;

public class ProductViewModel : ViewModelBase
{
    public Product? Product { get; set; } = new();
    public User? User { get; set; } = new();
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
                // IMAGE
            if (User != null)
            {
                using (MemoryStream stream = new MemoryStream(User!.Icon))
                {
                    BitmapImage _image = new();
                    _image.BeginInit();
                    _image.CacheOption = BitmapCacheOption.OnLoad;
                    _image.StreamSource = stream;
                    _image.EndInit();
                    image = _image;
                }
            }
        });
    }


    public RelayCommand UpdateProductCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        {
            //Order? Order = new() { UserId = User!.Id, Quantity = Quantity, Date = DateTime.Now, TotalPrice = Product!.Price * Quantity };
            //User?.Orders?.Add(Order);

            //context.Orders.Add(Order);
            //context.SaveChanges();

            //OrderProduct orderProduct = new() { OrderId = Order.Id, ProductId = Product!.Id };
            //context.OrderProducts.Add(orderProduct);
            //context.SaveChanges();
        }
         
        _navigationService?.NavigateTo<AllProductsViewModel>(new ParameterMessage { Message = User });

    });

    public RelayCommand ImageDownoload => new(() =>
    {
        OpenFileDialog openImage = new();

        openImage.Filter = "Image files(*.PNG, *.JPG, *.BMP)|*.png;*.jpg;*.bmp";
        //if (openImage.ShowDialog() == true)
        //{
        //    var uri = new Uri(openImage.FileName);
        //    image = new(uri);

        //    User!.Icon = uri.ToString();
        //}
        //User!.Icon = image!.UriSource.ToString();
    });

    public RelayCommand BackToAllProductsCommand => new(() =>
    {
        _navigationService?.NavigateTo<AllProductsViewModel>(new ParameterMessage { Message = User });
    });
}
