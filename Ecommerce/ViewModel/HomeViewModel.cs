using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using DbEcommerceApp.Message;
using UserEcommerceApp.Services.Classes;
using UserEcommerceApp.Services.Interfaces;
using System.Windows.Media.Imaging;
using System.IO;

namespace UserEcommerceApp.ViewModel;

public class HomeViewModel : ViewModelBase
{ 
    public BitmapImage? UserIcon { get; set; } = new();
    public User? User { get; set; } = new();
    public ObservableCollection<Category> Categories { get; set; } = new();

    public ObservableCollection<Product> Products { get; set; } = new();
    public ObservableCollection<Product> SearchResults { get; set; } = new();
    public string? SearchText { get; set; }


    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;


    public HomeViewModel(INavigationService navigationService, IMessenger messenger)
    {
        using (var context = new EcommerceDbContext())
        {
            var categoriesFromDb = context.Categories.Include(b => b.Products).ToList();

            Categories = new ObservableCollection<Category>(categoriesFromDb);

            foreach (var category in Categories)
            {
                if (category.Name == Categories[0].Name)
                {
                    Products = new(category.Products!);
                    SearchResults = new(Products);
                }
            }
        }
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            User = param?.Message as User;
            // IMAGE
            if (User!.Icon != null)
            {
                using (MemoryStream stream = new MemoryStream(User!.Icon))
                {
                    BitmapImage _image = new();
                    _image.BeginInit();
                    _image.CacheOption = BitmapCacheOption.OnLoad;
                    _image.StreamSource = stream;
                    _image.EndInit();
                    UserIcon = _image;
                }
            }
        });
    }

    #region SelectedProduct FullProp
    private Product _selectedProduct;
    public Product SelectedProduct
    {
        get => _selectedProduct;
        set
        {
            _selectedProduct = value;

            UserProductParameter userProductParameter = new(User!, _selectedProduct);

            if (SelectedProduct != null) _navigationService?.NavigateTo<ProductViewModel>(new ParameterMessage { Message = userProductParameter });
        }
    }
    #endregion

    #region SelectedCategory FullProp
    private Category _selectedCategory;
    public Category SelectedCategory
    {
        get => _selectedCategory;
        set
        {
            _selectedCategory = value;
            foreach (var category in Categories)
            {
                if (category.Name == _selectedCategory.Name)
                {
                    Products = new(category.Products!);
                    SearchResults = new(Products);
                }
            }
        }
    }
    #endregion


    #region RelayCommands
    public RelayCommand SearchProductCommand => new(() =>
    {
        SearchResults = SearchServices.SearchInHomeView(SearchText!, SearchResults, Products);
    });

    public RelayCommand MyCardsCommand => new(() =>
    {
        _navigationService?.NavigateTo<CardsViewModel>(new ParameterMessage { Message = User });
    });

    public RelayCommand GoToBasketCommand => new(() =>
    {
        _navigationService?.NavigateTo<BasketViewModel>(new ParameterMessage { Message = User });
    });

    public RelayCommand MyOrdersCommand => new(() =>
    {
        _navigationService?.NavigateTo<OrdersViewModel>(new ParameterMessage { Message = User });
    });

    public RelayCommand ExitCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage { Message = User });
    });
    #endregion
}