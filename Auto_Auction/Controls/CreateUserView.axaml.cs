using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml; //Remember to get rid of unused usings
using Auto_Auction.Views;
using Azure.Identity;

namespace Auto_Auction.Controls;

public partial class CreateUserView : UserControl
{
    private MainWindow _mainwindow;
    public CreateUserView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainwindow = mainWindow;
    }

    private void RegisterUser(object? sender, RoutedEventArgs e)
    {
        var Username = UsernameBox.Text?.Trim();
        var Passwordagain = PasswordagainBox.Text?.Trim();
        var Password = this.PasswordBox.Text?.Trim();
        var VCR = VCRBox;
        var Credit = CreditBox;
        
        if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Passwordagain))
        {
            
            throw new Exception("All fields must be filled");
        }

        if (Password != Passwordagain)
        {
            
            throw new Exception("Passwords do not match");
        }

        _mainwindow.MainContent.Content = new DashBoardControle(_mainwindow);
    }
    

    private void Cancel(object? sender, RoutedEventArgs e)
    {
        _mainwindow.MainContent.Content = new LoginView(_mainwindow);
    }


}