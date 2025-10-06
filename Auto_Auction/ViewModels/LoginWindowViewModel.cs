using Auto_Auction.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class LoginWindowViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainWindowViewModel;
    public LoginWindowViewModel( MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;
    }

    [RelayCommand]
    public async void OnLoginClick()
    {
        _mainWindowViewModel.NavigateToDashboard();
    }

    [RelayCommand]
    public void OnCreateUser()
    {
        _mainWindowViewModel.NavigateToCreateUser();       
    }
}
