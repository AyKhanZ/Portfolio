using AdminEcommerceApp.Services.Interfaces;
using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using DbEcommerceApp.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AdminEcommerceApp.ViewModel;

public class AddProductViewModel : ViewModelBase
{
    public Product? Product { get; set; } = new();
    public User? User { get; set; } = new();
    public BitmapImage? image { get; set; } = new(new Uri(AppDomain.CurrentDomain.BaseDirectory + "Images/no_product.jpg"));
    public ObservableCollection<Category> Categories { get; set; } = new();
    public Category? SelectedCategory { get; set; } = new();


    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;


    public AddProductViewModel(INavigationService navigationService, IMessenger messenger)
    {
        using (var context = new EcommerceDbContext())
        {
            var categoriesFromDb = context.Categories.Include(b => b.Products).ToList();

            Categories = new ObservableCollection<Category>(categoriesFromDb);
        }
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        { 
            User = param?.Message as User;
        });
    }


    public RelayCommand AddProductCommand => new(() =>
    {
        if (SelectedCategory!.Name != null)
        {
            //Product!.Category = SelectedCategory!;
            Product!.CategoryId = SelectedCategory!.Id;
            using (var context = new EcommerceDbContext())
            {
                context.Products.Add(Product);
                context.SaveChanges();
            }
            MessageBox.Show("Product added successfully!");
        }
        else MessageBox.Show("Choose category!");
        Product = new();
        image = new();
    });


    public RelayCommand ImageDownoload => new(() =>
    {
        OpenFileDialog openImage = new();

        openImage.Filter = "Image files(*.PNG, *.JPG, *.BMP)|*.png;*.jpg;*.bmp";
        if (openImage.ShowDialog() == true)
        {
            string filePath = openImage.FileName;
            byte[] imageBytes = File.ReadAllBytes(filePath);
            Product!.Image = imageBytes;

            using (MemoryStream stream = new MemoryStream(imageBytes))
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

    public RelayCommand BackToAllProductsCommand => new(() =>
    {
        _navigationService?.NavigateTo<AllProductsViewModel>(new ParameterMessage { Message = User });
    });
}
