using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class MakeABidViewModel
{
    
    public MakeABidViewModel()
    {
        
    }

    [RelayCommand]
    public void Bid()
    {
        //Logic goes here to place a bid
    }

    [RelayCommand]
    private void OnCancelBidClick()
    {
        //logic to cancel the bid goes here
    }
    

    public static bool IsValidateAmount(decimal amount, out string error)
    {
        if (amount <= 0)
        {
            error = "Bid amount must be greater than zero.";
            return false;
        }

        // you can add more validation here if needed
        error = string.Empty;
        return true;
    }
    
    
}
