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
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class HomeViewModel : ViewModelBase
{
    public Uri? UserIcon { get; set; }
    public User? User { get; set; } = new();
    public ObservableCollection<Category> Categories { get; set; } = new();
    public ObservableCollection<Product> Products { get; set; } = new();
    public Category SelectedCategory { get; set; } = new();

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
                Products = new ObservableCollection<Product>(category.Products!.ToList());
            }
        }
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            User = param?.Message as User;
            if (User?.Icon != null) UserIcon = new Uri(User?.Icon!); 
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

    #region RelayCommands
    public RelayCommand ExitCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage { Message = User });
    });

    public RelayCommand MyCardsCommand => new(() =>
    {
        _navigationService?.NavigateTo<CardsViewModel>(new ParameterMessage { Message = User });
    });

    public RelayCommand MyOrdersCommand => new(() =>
    {
        _navigationService?.NavigateTo<OrdersViewModel>(new ParameterMessage { Message = User });
    });

    #endregion
}