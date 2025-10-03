using Auto_Auction.ViewModels;
using Auto_Auction.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class SetForSaleView : UserControl
{
    private MainWindow _mainWindow;
    public SetForSaleView(MainWindow mainWindow)
    {
        InitializeComponent();
        DataContext = new SetForSaleViewModel();
        _mainWindow = mainWindow;
    }

    private void CancelSale(object? sender, RoutedEventArgs e)
    {
        NavigateToDashboard();
    }

    private void NavigateToDashboard()
    {
        _mainWindow.NavigateToDashboard();
    }
}