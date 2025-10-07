using System;
using System.Collections.ObjectModel;
using System.Reactive;
using Auto_Auction.Models;
using Auto_Auction.Models.Users;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;

namespace Auto_Auction.ViewModels;

public partial class DashBoardViewModel : ViewModelBase
{
    public ObservableCollection<Auction> UserAuctions { get; } = new();
    private readonly MainWindowViewModel _mainViewModel;

    public DashBoardViewModel(MainWindowViewModel mainViewModel)
    {
        UserAuctions.Add(new Auction(1,
            new PrivateCar(1, "Toyota Camry", 2020, 123, 2020, true, "PersonalCar",  123, 20, FuelTypeEnum.Petrol, EnergyClassEnum.C, 4, new Dimensions(23, 23, 32),0.7, true),
            new Seller(1, "John Doe", "Hestemanden123", 9200),9000));
        _mainViewModel = mainViewModel;

    }
    [RelayCommand]
    private void BidHistory()
    {
        _mainViewModel.NavigateToBidHistory();
    }

    [RelayCommand]
    private void UserProfile()
    {
        _mainViewModel.NavigateToProfile();

    }

    [RelayCommand]
    private void SetForSale()
    {
        _mainViewModel.NavigateToSetForSale();
    }

    [RelayCommand]
    private void Logout()
    {
        _mainViewModel.NavigateToLogin();
    }


    [RelayCommand]
    private void YourAuctionsDoubleTapped(Auction auction)
    {
        if (auction != null)
        {
            Console.WriteLine($"YourAuctions - Double tapped on: {auction.Vehicle.Name}");
        }
    }

    [RelayCommand]
    private void OtherAuctionsDoubleTapped(Auction auction)
    {
        if (auction != null)
        {
            Console.WriteLine($"OtherAuctions - Double tapped on: {auction.Vehicle.Name}");
            _mainViewModel.NavigateToBuyerAuction();
        }
    }
    

    
    
}

