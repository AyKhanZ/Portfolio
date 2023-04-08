using DbEcommerceApp.Data.DbContexts;
using DbEcommerceApp.Data.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using DbEcommerceApp.Message;
using UserEcommerceApp.Services.Classes;
using UserEcommerceApp.Services.Interfaces;
using System.IO;
using System.Collections;

namespace UserEcommerceApp.ViewModel;

public class RegistrationViewModel : ViewModelBase
{
    public User? user { get; set; } = new();
    public BitmapImage? image { get; set; } = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + "Images/defUser.png"));

    private readonly INavigationService? _navigationService;

    private readonly IMessenger? _messenger;

    public RegistrationViewModel(INavigationService navigationService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _messenger.Register<ParameterMessage>(this, param =>
        {
            user = param?.Message as User;
        });
    }

    public RelayCommand<PasswordBox> RegistrationCommand => new(param =>
    {
        user!.Password = param.Password; 
        var a = CheckRegistration.CheckUser(user, param.Password);
        if (a == null)
        {
            using (var context = new EcommerceDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
            _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage() { Message = user });
        }
        else MessageBox.Show(a);
    });


    public RelayCommand ImageDownoload => new(() =>
    {
        OpenFileDialog openImage = new();

        openImage.Filter = "Image files(*.PNG, *.JPG, *.BMP)|*.png;*.jpg;*.bmp";
        if (openImage.ShowDialog() == true)
        {
            string filePath = openImage.FileName;
            byte[] imageBytes = File.ReadAllBytes(filePath);
            user!.Icon = imageBytes;
             
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

    public RelayCommand BackToLoginCommand => new(() =>
    {
        _navigationService?.NavigateTo<LoginViewModel>(new ParameterMessage { Message = user });
    });

}