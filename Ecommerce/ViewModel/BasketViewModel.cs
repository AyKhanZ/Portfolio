using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using UserEcommerceApp.Message;
using UserEcommerceApp.Services.Interfaces;

namespace UserEcommerceApp.ViewModel;

public class BasketViewModel : ViewModelBase
{
    public User? User { get; set; } = new();
    public ObservableCollection<BasketProduct> BasketProducts { get; set; } = new(); 
    public bool IsEnabledToCancel { get; set; }

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public BasketViewModel(INavigationService navigationService, IMessenger messenger)
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
                    var basketProductsFromDb = context.Set<BasketProduct>().Where(o => o.Basket.UserId == User.Id).ToList();
                    BasketProducts = new ObservableCollection<BasketProduct>(basketProductsFromDb)!;

                    foreach (var basketProduct in BasketProducts)
                    {
                        basketProduct.Product = context.Products.SingleOrDefault(p => p.Id == basketProduct.ProductId)!;
                    } 

                }
            }
        });

    }

    #region SelectedOrder FullProp
    private BasketProduct _selectedBasketProduct;
    public BasketProduct SelectedBasketProduct
    {
        get => _selectedBasketProduct;
        set
        {
            _selectedBasketProduct= new();
            _selectedBasketProduct= value;
            IsEnabledToCancel = true;
        }
    }
    #endregion




    public RelayCommand DeleteProductCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        { 
            context.BasketProducts.Remove(_selectedBasketProduct!);
            context.SaveChanges();
            IsEnabledToCancel = false;
            MessageBox.Show("Product has been deleted from basket successfully!");
        }
    });


    public RelayCommand SearchProductCommand => new(() =>
    {
        MessageBox.Show("Searched");
    });


    public RelayCommand BackToHomeCommand => new(() =>
    {
        IsEnabledToCancel = false;
        _navigationService?.NavigateTo<HomeViewModel>(new ParameterMessage { Message = User });
    });
}