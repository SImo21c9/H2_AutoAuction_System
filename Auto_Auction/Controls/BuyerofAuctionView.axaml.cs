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

    private MainWindow _mainWindow;
    public BuyerofAuctionView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        DataContext = new Auto_Auction.ViewModels.BuyerofAuctionViewModel();

    }

    private void BackToHomeScreen(object? sender, RoutedEventArgs e)
    {
        _mainWindow.MainContent.Content = new DashBoardControle(_mainWindow);
    }

    private async void OnMakeBidClick(object? sender, RoutedEventArgs e)
    {
        var modal = new MakeABidView(_mainWindow);
        await modal.ShowDialog(_mainWindow);
    }

    
}