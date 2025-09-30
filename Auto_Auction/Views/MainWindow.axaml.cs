using Auto_Auction.Controls;
using Avalonia.Controls;

namespace Auto_Auction.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new LoginView(this); // Pass reference of MainWindow
    }
}