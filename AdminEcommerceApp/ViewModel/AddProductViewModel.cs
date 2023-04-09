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
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AdminEcommerceApp.ViewModel;

public class AddProductViewModel : ViewModelBase
{
    public Product? Product { get; set; } = new();
    public User? User { get; set; } = new();
    public BitmapImage? image { get; set; } = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "Images/no_product.jpg"));
    public ObservableCollection<Category> Categories { get; set; } = new();
    public Category? SelectedCategory { get; set; } = new();
    public string? Price { get; set; }


    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;


    public AddProductViewModel(INavigationService navigationService, IMessenger messenger)
    { 
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            User = param?.Message as User;
            using (var context = new EcommerceDbContext())
            {
                var categoriesFromDb = context.Categories.Include(b => b.Products).ToList();

                Categories = new ObservableCollection<Category>(categoriesFromDb);
            }
        });
    }


    public RelayCommand AddProductCommand => new(() =>
    {
        if (Product != null)
        {
            if (SelectedCategory!.Name != null)
            {
                if (Product.Image != null)
                {
                    if (!string.IsNullOrEmpty(Price)
                    && !string.IsNullOrEmpty(Product.Name)
                    && !string.IsNullOrEmpty(Product.Description)
                    && !string.IsNullOrEmpty(Product.Make)
                    && !string.IsNullOrEmpty(Price))
                    {
                        if (Regex.IsMatch(Price, @"^[0-9.]{1,15}$"))
                        {
                            float price;
                            if (float.TryParse(Price, out price))
                            {
                                Product.Price = price;
                                Product!.CategoryId = SelectedCategory!.Id;
                                using (var context = new EcommerceDbContext())
                                {
                                    var FoundProduct = context.Products.SingleOrDefault(u => u.Name == Product!.Name);
                                    if (FoundProduct != null) MessageBox.Show("This product already exist!");
                                    else
                                    {
                                        context.Products.Add(Product);
                                        context.SaveChanges();
                                        MessageBox.Show("Product added successfully!");
                                    }
                                }
                                Product = new();
                                Price = "";
                                image = new(new Uri(AppDomain.CurrentDomain.BaseDirectory + "Images/no_product.jpg"));
                            }
                        }
                        else MessageBox.Show("Price must contains only digits and dot!");
                    }
                    else MessageBox.Show("All fields are required!");
                }
                else MessageBox.Show("Choose image!");
            }
            else MessageBox.Show("Choose category!");
        }
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
