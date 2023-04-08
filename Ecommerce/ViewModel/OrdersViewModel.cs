using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using DbEcommerceApp.Message;
using UserEcommerceApp.Services.Classes;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class OrdersViewModel : ViewModelBase
{
    public User? User { get; set; } = new();
    public ObservableCollection<OrderProduct> OrderProducts { get; set; } = new();
    public ObservableCollection<OrderProduct> SearchResults { get; set; } = new();
    public string? SearchText { get; set; }
    public bool IsEnabledToCancel { get; set; }


    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public OrdersViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            IsEnabledToCancel = false;
            User = param?.Message as User;
            if (User != null)
            {
                using (var context = new EcommerceDbContext())
                {
                    var orderProductsFromDb = context.Set<OrderProduct>().Where(o => o.Order!.UserId == User.Id).ToList();
                    OrderProducts = new ObservableCollection<OrderProduct>(orderProductsFromDb)!;

                    foreach (var orderProduct in OrderProducts)
                    {
                        orderProduct.Product = context.Products.SingleOrDefault(p => p.Id == orderProduct.ProductId)!;
                    }

                }
            }
            SearchResults = new(OrderProducts);
        });

    }


    #region SelectedOrderProduct FullProp
    private OrderProduct _selectedOrderProduct;
    public OrderProduct SelectedOrderProduct
    {
        get => _selectedOrderProduct;
        set
        {
            _selectedOrderProduct = new();
            _selectedOrderProduct = value;
            IsEnabledToCancel = true;
        }
    }
    #endregion
     

    public RelayCommand DeleteProductCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        { 
            context.OrderProducts.Remove(_selectedOrderProduct!);
            context.SaveChanges();
             
            OrderProducts.Remove(_selectedOrderProduct!);
            SearchResults = new(OrderProducts);

            IsEnabledToCancel = false;
            MessageBox.Show("Order has been deleted successfully!");
        }
    });


    public RelayCommand SearchOrderCommand => new(() =>
    {
        SearchResults = SearchServices.SearchInOrders(SearchText!, SearchResults, OrderProducts);
    });


    public RelayCommand BackToHomeCommand => new(() =>
    {
        IsEnabledToCancel = false;
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = User });
    });
}