using System;

namespace Auto_Auction.ViewModels;

public class BuyerofAuctionViewModel : ViewModelBase
{
    public DateTime ClosingDate{ get; }
    public Decimal CurrentBid { get; set; }
    
    
}