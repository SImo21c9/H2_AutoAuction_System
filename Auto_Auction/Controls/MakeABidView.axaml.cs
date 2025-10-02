using System;
using Auto_Auction.ViewModels;
using Auto_Auction.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class MakeABidView : Window
{
    private MainWindow _mainWindow;
    private MakeABidViewModel _viewModel;
    public MakeABidView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        
    }
    
    private void OnSubmitBidClick(object? sender, RoutedEventArgs e)
    {
        //at the end thy should close the modal window
    }

    private void OnCancelBidClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}