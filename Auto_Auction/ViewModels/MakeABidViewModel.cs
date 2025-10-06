using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class MakeABidViewModel
{
    private readonly MainWindowViewModel _MainViewModel;
    // [ObservableProperty]
    // private decimal bidAmount;
    
    public MakeABidViewModel(MainWindowViewModel mainViewModel )
    {
        _MainViewModel = mainViewModel;
    }

    [RelayCommand]
    public void Bid()
    {
        
        // if (IsValidateAmount(BidAmount, out string error))
        // {
        //     // Add logic to submit bid
        //     Console.WriteLine($"Bid submitted: {BidAmount}");
        // }
        // else
        // {
        //     Console.WriteLine($"Invalid bid: {error}");
        // }
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
