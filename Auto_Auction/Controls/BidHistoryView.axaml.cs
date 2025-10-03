using Auto_Auction.Views;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Auto_Auction.Controls;

public partial class BidHistoryView : UserControl
{
    private MainWindow _mainWindow;
    public BidHistoryView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
    }

    private void GoBacktoDashboard(object? sender, RoutedEventArgs e)
    {
        NavigateToDashboard();
    }

    private void NavigateToDashboard()
    {
        _mainWindow.NavigateToDashboard();
    }
}