using System;
using Auto_Auction.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;

namespace Auto_Auction.Controls;

public partial class DashBoardControle : UserControl
{
    private MainWindow _mainWindow;
    public DashBoardControle(MainWindow mainWindow)
    {
        InitializeComponent();
        DataContext = new Auto_Auction.ViewModels.DashBoardViewModel();
        _mainWindow = mainWindow;
    }
    private void DataGrid_DoubleTappedYourAuctions(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is DataGrid dataGrid && dataGrid.SelectedItem is Auto_Auction.Models.Auction auction)
        {
            Console.WriteLine("YourAuctions");
            dataGrid.SelectedItem = null;
        }
    }
    private void DataGrid_DoubleTappedOtherAuctions(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (sender is DataGrid dataGrid && dataGrid.SelectedItem is Auto_Auction.Models.Auction auction)
        {
            //dataGrid.SelectedItem
            Console.WriteLine("OtherAuctions ");
            dataGrid.SelectedItem = null;
        }

        NavigateToBuyerAuction();

    }

    private void NavigateToBuyerAuction()
    {
        _mainWindow.NavigateToBuyerAuction();
    }
    
    private void SetForSale(Object sender, RoutedEventArgs e)
    {
        NavigateToSetForSale();
    }

    private void NavigateToSetForSale()
    {
        _mainWindow.NavigateToSetForSale();
    }

    private void UserProfile(object? sender, RoutedEventArgs e)
    {
        NavigateToUserProfile();
    }

    private void NavigateToUserProfile()
    {
        _mainWindow.NavigateToSetForSale();
    }

    private void BidHistory(object? sender, RoutedEventArgs e)
    {
        NavigateToBidHistory();
    }

    private void NavigateToBidHistory()
    {
        _mainWindow.NavigateToBidHistory();
    }
    private void SetForSale(object? sender, RoutedEventArgs e)
    {
        NavigateToSetForSale();
    }
    private void NavigateToSetForSale()
    {
        _mainWindow.NavigateToSetForSale();
    }
}