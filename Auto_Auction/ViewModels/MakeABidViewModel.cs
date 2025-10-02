namespace Auto_Auction.ViewModels;

public class MakeABidViewModel
{
    public MakeABidViewModel()
    {
        // constructor code if needed
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
