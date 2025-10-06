using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class SetForSaleViewModel : ViewModelBase
{
    [ObservableProperty]
    private VehiclePropertyControlViewModel _vehiclePropertyControlViewModel = new();

    [RelayCommand]
    private void CancelSale()
    {
        //Logic to Cancel the sale goes here
    }
}