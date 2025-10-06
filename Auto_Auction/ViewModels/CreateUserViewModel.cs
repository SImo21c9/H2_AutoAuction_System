using CommunityToolkit.Mvvm.Input;

namespace Auto_Auction.ViewModels;
using System.Text.RegularExpressions;

public partial class CreateUserViewModel
{
    [RelayCommand]
    public void RegisterUser()
    {
        //Logic for Registering a new user goes here
    }

    [RelayCommand]
    public void Cancel()
    {
        //Logic for Cancelling user registration goes here
    }
}