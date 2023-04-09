using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Linq; 
using DbEcommerceApp.Message;
using AdminEcommerceApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel; 
using AdminEcommerceApp.Services.Classes;
using System.Windows.Media.Imaging;
using System.IO;

namespace AdminEcommerceApp.ViewModel;

public class AllProductsViewModel:ViewModelBase
{
    public BitmapImage? AdminIcon { get; set; }  
    public User? User { get; set; } = new();
    public ObservableCollection<Category> Categories { get; set; } = new();

    public ObservableCollection<Product> Products { get; set; } = new();
    public ObservableCollection<Product> SearchResults { get; set; } = new();
    public string? SearchText { get; set; }


    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;


    public AllProductsViewModel(INavigationService navigationService, IMessenger messenger)
    { 
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {  
            User = param?.Message as User;
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
                    AdminIcon = _image;
                }
            }

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
            if (_selectedCategory != null)
            {
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
    }
    #endregion


    #region RelayCommands
    public RelayCommand SearchProductCommand => new(() =>
    {
        SearchResults = SearchServices.SearchInHomeView(SearchText!, SearchResults, Products);
    });

    
    public RelayCommand CategorySettingsCommand => new(() =>
    {
        _navigationService?.NavigateTo<AddCategoryViewModel>(new ParameterMessage());
    });


    public RelayCommand AddProductCommand => new(() =>
    {
        _navigationService?.NavigateTo<AddProductViewModel>(new ParameterMessage());
    });


    /*public RelayCommand OrdersStatusCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage());
    });
    public RelayCommand AllUsersCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage());
    });
    public RelayCommand MyProfileCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage());
    });*/


    public RelayCommand ExitCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage());
    });
    #endregion
}