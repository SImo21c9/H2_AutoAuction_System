using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;
using System.Text.RegularExpressions;

public partial class CreateUserViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainViewModel;
    
    [ObservableProperty]
    private string username = string.Empty;
    
    [ObservableProperty]
    private string password = string.Empty;
    
    [ObservableProperty]
    private string passwordAgain = string.Empty;

    public CreateUserViewModel(MainWindowViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    [RelayCommand]
    public void RegisterUser()
    {
        if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordAgain))
        {
            return;
        }

        if (Password != PasswordAgain)
        {
            return;
        }
        
        _mainViewModel.NavigateToDashboard();
    }

    [RelayCommand]
    public void Cancel()
    {
        _mainViewModel.NavigateToLogin();
    }
}