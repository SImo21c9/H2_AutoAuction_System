using System;
using System.ComponentModel;
using ReactiveUI;
using Auto_Auction.Models;
using Auto_Auction.Models.Users;

namespace Auto_Auction.ViewModels;

public class MakeABidViewModel : ViewModelBase, IReactiveObject
{
    private decimal _bidAmount;
    private Auction _currentAuction;
    private Buyer _currentBuyer;
    private string _errorMessage;

    public decimal BidAmount
    {
        get => _bidAmount;
        set => this.RaiseAndSetIfChanged(ref _bidAmount, value);
    }

    public Auction CurrentAuction
    {
        get => _currentAuction;
        set => this.RaiseAndSetIfChanged(ref _currentAuction, value);
    }

    public Buyer CurrentBuyer
    {
        get => _currentBuyer;
        set => this.RaiseAndSetIfChanged(ref _currentBuyer, value);
    }

    public string ErrorMessage
    {
        get => _errorMessage;
        set => this.RaiseAndSetIfChanged(ref _errorMessage, value);
    }

    private bool ValidateBid()
    {
        if (CurrentAuction == null)
        {
            ErrorMessage = "No auction selected";
            return false;
        }

        if (BidAmount <= 0)
        {
            ErrorMessage = "Bid must be greater than zero";
            return false;
        }
        

        return true;
    }

    public void RaisePropertyChanging(PropertyChangingEventArgs args)
    {
        throw new NotImplementedException();
    }
    
    public void RaisePropertyChanged(PropertyChangedEventArgs args)
    {
        throw new NotImplementedException();
    }
}