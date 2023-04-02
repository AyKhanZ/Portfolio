using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class OrdersViewModel:ViewModelBase
{
    public User? User { get; set; } = new();  
    public ObservableCollection<Order> Orders { get; set; } = new();
    public bool IsEnabledToCancel { get; set; }

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public OrdersViewModel(INavigationService navigationService, IMessenger messenger)
    { 
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            User = param?.Message as User; 
            if (User != null)
            {
                using (var context = new EcommerceDbContext())
                {
                    var ordersFromDb = context.Set<Order>().Where(o => o.User!.Login == User!.Login).ToList();

                    Orders = new ObservableCollection<Order>(ordersFromDb);
                }
            }
        });

    }

    #region SelectedOrder FullProp
    private Order _selectedOrder;
    public Order SelectedOrder
    {
        get => _selectedOrder;
        set
        {  
            _selectedOrder = new(); 
            _selectedOrder = value;
            IsEnabledToCancel = true;
        }
    }
    #endregion

     


    public RelayCommand DeleteOrderCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        {
            context.Orders.Remove(_selectedOrder!);
            context.SaveChanges();
            MessageBox.Show("Your order has been deleted successfully!"); 
        }
    }); 
    

    public RelayCommand SearchOrderCommand => new(() =>
    {
        MessageBox.Show("Searched");
    }); 


    public RelayCommand BackToHomeCommand => new(() =>
    {
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = User });
    });
}