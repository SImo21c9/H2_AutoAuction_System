using System;
using Auto_Auction.Controls;
using Auto_Auction.ViewModels;
using Avalonia.Controls;

namespace Auto_Auction.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var mainWindowViewModel = new MainWindowViewModel();
        DataContext = mainWindowViewModel;
        
    }
    
    
}