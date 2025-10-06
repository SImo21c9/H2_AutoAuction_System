using System;
using System.Threading.Tasks;
using Auto_Auction.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tmds.DBus.Protocol;

namespace Auto_Auction.ViewModels;

public partial class LoginWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string username;

    [ObservableProperty] 
    private string password;
    
    private readonly MainWindowViewModel _mainWindowViewModel;
    public LoginWindowViewModel( MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;
    }

    [RelayCommand]
    public async Task OnLoginClick()
    {
        if (Username == "admin" && Password == "1234")
        {
            _mainWindowViewModel.NavigateToDashboard();
            Console.WriteLine("LOGIN SUCCESSFUL");
        }
        else
        {
            Console.WriteLine("Login failed");
        }
    }
    
    
    [RelayCommand]
    public void OnCreateUser()
    {
        _mainWindowViewModel.NavigateToCreateUser();       
    }
}
