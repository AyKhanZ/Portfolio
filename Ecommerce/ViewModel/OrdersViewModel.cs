using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;
public class OrdersViewModel:ViewModelBase
{
    public User? user { get; set; } = new();
    public ObservableCollection<Category> Categories { get; set; } = new();
    public ObservableCollection<Product> Products { get; set; } = new();
    public ObservableCollection<Order> Orders { get; set; } = new();
    public Category SelectedCategory { get; set; } = new();

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public OrdersViewModel(INavigationService navigationService, IMessenger messenger)
    {
        using (var context = new EcommerceDbContext())
        {
            var categoriesFromDb = context.Categories.Include(b => b.Products).ToList();
            Categories = new ObservableCollection<Category>(categoriesFromDb);
            foreach (var category in Categories) Products = new ObservableCollection<Product>(category.Products!.ToList());
        }
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            user = param?.Message as User;
        });
    }

    public RelayCommand BackCommand => new(() =>
    { 
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = user });
    });

    public RelayCommand CardCommand => new(() =>
    {
        user = null;
        _navigationService?.NavigateTo<CardViewModel>(new ParameterMessage { Message = user });
    }); 

    public RelayCommand MyOrdersCommand => new(() =>
    { 
        _navigationService?.NavigateTo<OrdersViewModel>(new ParameterMessage { Message = user });
    }); 

}