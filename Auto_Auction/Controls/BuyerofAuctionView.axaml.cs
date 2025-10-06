using System;
using System.Runtime.InteropServices.JavaScript;
using Auto_Auction.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class BuyerofAuctionView : UserControl
{
    public BuyerofAuctionView()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}