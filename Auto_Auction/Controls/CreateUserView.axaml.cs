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
    public CreateUserView()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }


}