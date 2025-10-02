using CommunityToolkit.Mvvm.ComponentModel;

namespace Auto_Auction.ViewModels;

public partial class SetForSaleViewModel : ViewModelBase
{
    [ObservableProperty]
    private VehiclePropertyControlViewModel _vehiclePropertyControlViewModel = new();
}