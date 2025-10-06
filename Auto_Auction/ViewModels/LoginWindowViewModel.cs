using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;

public partial class LoginWindowViewModel : ViewModelBase
{
    public LoginWindowViewModel()
    {
        
    }

    [RelayCommand]
    private void OnLoginClick()
    {
        //Logic for login goes here
    }

    [RelayCommand]
    private void OnCreateUser()
    {
        //Logic for creating a new user goes here 
    }
}
