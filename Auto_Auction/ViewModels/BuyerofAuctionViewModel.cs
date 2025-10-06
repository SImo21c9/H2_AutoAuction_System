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

    [RelayCommand]
    public void OnMakeBidClick()
    {
        //Navigate to 
    }
}