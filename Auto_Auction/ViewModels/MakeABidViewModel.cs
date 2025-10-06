using System;
using System.Xml;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class MakeABidViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainViewModel;
    // [ObservableProperty]
    // private decimal bidAmount;
    
    public MakeABidViewModel(MainWindowViewModel mainViewModel )
    {
        _mainViewModel = mainViewModel;
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
    private void OnCancelBidClick(object parameter)
    {
        if (parameter is Window window)
        {
            window.Close();
        }
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
