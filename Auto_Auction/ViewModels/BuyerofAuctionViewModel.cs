using System;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class BuyerofAuctionViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainViewModel;
    public DateTime ClosingDate{ get; }
    public Decimal CurrentBid { get; set; }

    public BuyerofAuctionViewModel(MainWindowViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }
    
    [RelayCommand]
    public void BackToHomeScreen()
    {
        _mainViewModel.NavigateToDashboard();
    }

    //here is a to do this button should navigate to a window to allow user to make a bid but it doesn't work right now for some reason 
    [RelayCommand]
    public void OnMakeBidClick()
    {
        _mainViewModel.NavigateToMakeBid();
    }
}