using CommunityToolkit.Mvvm.ComponentModel;

namespace Auto_Auction.ViewModels;

public partial class VehiclePropertyControlViewModel : ViewModelBase
{
    [ObservableProperty] 
    private bool _truckVisible = false;
    [ObservableProperty]
    private bool _privCarVisble = false;
    [ObservableProperty]
    private bool _proCarVisble = false;
    [ObservableProperty]
    private bool _busVisble = false;
}