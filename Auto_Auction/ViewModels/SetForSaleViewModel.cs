using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class SetForSaleViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainViewModel;
    
    [ObservableProperty]
    private VehiclePropertyControlViewModel _vehiclePropertyControlViewModel = new();

    public SetForSaleViewModel(MainWindowViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }
    [RelayCommand]
    private void CancelSale()
    {
        _mainViewModel.NavigateToDashboard();
    }
}