using CommunityToolkit.Mvvm.ComponentModel;
using Auto_Auction.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class BidHistoryViewModel : ViewModelBase
{
    [ObservableProperty]
    private ObservableCollection<BidHistoryItem> bidHistory;

    private MainWindowViewModel _mainViewModel;
    public BidHistoryViewModel(MainWindowViewModel mainViewModel)
    {
        // Testdata (kan senere hentes fra DB)
        BidHistory = new ObservableCollection<BidHistoryItem>
        {
            new BidHistoryItem("Ford Fiesta", 2015, 12000, 12500, true),
            new BidHistoryItem("VW Golf", 2018, 18000, 19000, false),
            new BidHistoryItem("BMW 320i", 2020, 25000, 25000, true),
        };

        _mainViewModel = mainViewModel;
    }

    [RelayCommand]
    public void OnBackClick()
    {
        _mainViewModel.NavigateToDashboard();

    }
}

// Lille model til grid’et
public class BidHistoryItem
{
    public string VehicleName { get; }
    public int Year { get; }
    public decimal YourBid { get; }
    public decimal AcceptedBid { get; }
    public string Status => Won ? "WON" : string.Empty;

    public bool Won { get; }

    public BidHistoryItem(string name, int year, decimal yourBid, decimal acceptedBid, bool won)
    {
        VehicleName = name;
        Year = year;
        YourBid = yourBid;
        AcceptedBid = acceptedBid;
        Won = won;
    }
}
