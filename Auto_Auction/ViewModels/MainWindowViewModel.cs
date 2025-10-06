using Auto_Auction.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Auto_Auction.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    
    [ObservableProperty]
    private ViewModelBase _currentView;

    public MainWindowViewModel()
    {
        // Start with login view
        CurrentView = new LoginWindowViewModel(this);
    }
    
    public void NavigateToLogin()
    {
        CurrentView = new LoginWindowViewModel(this);
    }

    public void NavigateToDashboard()
    {
        CurrentView = new DashBoardViewModel(this);
    }

    public void NavigateToCreateUser()
    {
        CurrentView = new CreateUserViewModel(this);  
    }

    public void NavigateToSetForSale()
    {
        CurrentView = new SetForSaleViewModel(this);
    }

    public void NavigateToBuyerAuction()
    {
        CurrentView = new BuyerofAuctionViewModel(this);
    }

    public void NavigateToBidHistory()
    {
        CurrentView = new BidHistoryViewModel(this);
    }

    public void NavigateToMakeBid()
    {
        CurrentView = new MakeABidViewModel(this);
    }

    public void NavigateToProfile()
    {
        CurrentView = new UserProfileViewModel(this);
    }
}