using AdminEcommerceApp.Services.Interfaces;
using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using DbEcommerceApp.Message;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AdminEcommerceApp.ViewModel;

public class AddCategoryViewModel : ViewModelBase
{
    public User? User { get; set; } = new();
    public BitmapImage? image { get; set; } = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "Images/no_product.jpg"));
    public Category NewCategory { get; set; } = new();
    public Category ChangedCategory { get; set; } = new();
    public ObservableCollection<Category> Categories { get; set; } = new();
    public bool IsEnabledToDelete { get; set; }


    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;


    public AddCategoryViewModel(INavigationService navigationService, IMessenger messenger)
    {  
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            var UserProduct = param?.Message as UserProductParameter;
            User = UserProduct?.User;

            using (var context = new EcommerceDbContext())
            {
                var categoriesFromDb = context.Categories.Include(b => b.Products).ToList();

                Categories = new ObservableCollection<Category>(categoriesFromDb);
            }
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
    #region SelectedCategory FullProp
    private Category _selectedCategory;
    public Category SelectedCategory
    {
        get => _selectedCategory;
        set
        {
            _selectedCategory = value;
            IsEnabledToDelete = true;
        }
    }
    #endregion

    public RelayCommand DeleteCategoryCommand => new(() =>
    {
        using (var context = new EcommerceDbContext())
        {
            context.Products.RemoveRange(_selectedCategory.Products!);
            context.Categories.Remove(_selectedCategory!);
            context.SaveChanges();
            MessageBox.Show($"Category {_selectedCategory.Name} deleted successfully!");
        }
        IsEnabledToDelete = false;
        Categories.Remove(SelectedCategory);
        ChangedCategory = new();
    });

    public RelayCommand UpdateCategoryCommand => new(() =>
    {
        bool isExists = Categories.Any(x => x.Name == ChangedCategory.Name);
        if (isExists) MessageBox.Show($"Current category is {ChangedCategory.Name}!\nChoose another title!");
        else
        {
            using (var context = new EcommerceDbContext())
            {
                context.Categories.Remove(SelectedCategory);
                context.SaveChanges();

                context.Categories.Add(ChangedCategory);
                context.SaveChanges();
            }
            Categories.Remove(SelectedCategory);
            Categories.Add(ChangedCategory);
            ChangedCategory = new();
        }
    });


    public RelayCommand AddCategoryCommand => new(() =>
    {
        bool isExists = Categories.Any(x => x.Name == NewCategory.Name);
        if (isExists) MessageBox.Show($"Ecommerce already has {NewCategory.Name} category!\nChoose another title!");
        else
        {
            using (var context = new EcommerceDbContext())
            {
                context.Categories.Add(NewCategory);
                context.SaveChanges();
            }
            Categories.Add(NewCategory);
            NewCategory = new();
            MessageBox.Show("The category has been successfully added !");
        }
    });

    public RelayCommand BackToAllProductsCommand => new(() =>
    {
        _navigationService?.NavigateTo<AllProductsViewModel>(new ParameterMessage { Message = User });
    });
}
