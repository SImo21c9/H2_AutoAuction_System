using System;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class BuyerofAuctionViewModel : ViewModelBase
{
    public DateTime ClosingDate{ get; }
    public Decimal CurrentBid { get; set; }

    [RelayCommand]
    public void BackToHomeScreen()
    {
        //Logic to navigate back to home screen
    }

    [RelayCommand]
    public void OnMakeBidClick()
    {
        //Navigate to 
    }
}