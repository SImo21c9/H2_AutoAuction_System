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
    public CreateUserView()
    {
        InitializeComponent();
    }

    private void RegisterUser(object? sender, RoutedEventArgs e)
    {
        var Username = UsernameBox.Text?.Trim();
        var Passwordagain = PasswordagainBox.Text?.Trim();
        var Password = this.PasswordBox.Text?.Trim();
        var VCR = VCRBox;
        var Credit = CreditBox;
        
        if(!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Passwordagain))
        {
            throw new Exception("All field must be filled");
        }
    }

    private void Cancel(object? sender, RoutedEventArgs e)
    {
        
    }
    
}