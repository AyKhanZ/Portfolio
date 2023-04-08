﻿using DbEcommerceApp.Message;
using GalaSoft.MvvmLight;

namespace AdminEcommerceApp.Services.Interfaces;

public interface INavigationService
{
    public void NavigateTo<T>(ParameterMessage? message = null) where T : ViewModelBase;
    public void NavigateTo<T>(UsersMessage? message = null) where T : ViewModelBase;
}