using Auto_Auction.Controls;
using Auto_Auction.ViewModels;
using Avalonia.Controls;

namespace Auto_Auction.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new LoginView(this); // Pass reference of MainWindow
    }
    public void NavigateToDashboard()
    {
        MainContent.Content = new DashBoardControle(this);
    }

    public void NavigateToUser()
    {
        MainContent.Content = new CreateUserView(this);
    }
    public void NavigateToSetForSale()
    {
        MainContent.Content = new SetForSaleView();
    }

    

}