using CommunityToolkit.Mvvm.ComponentModel;

namespace Auto_Auction.ViewModels;
using System.Text.RegularExpressions;

public partial class CreateUserViewModel : ViewModelBase
{
    [ObservableProperty]
    private string name;

    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string password;

    [ObservableProperty]
    private string cprNumber;

    [ObservableProperty]
    private string cvrNumber;

    [ObservableProperty]
    private decimal credit;

    [ObservableProperty] private bool isCorp;
    public static bool IsValidUsername(string username, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(username))
        {
            error = "Username is required.";
            return false;
        }
        
        
        if (!Regex.IsMatch(username!, @"^[A-Za-z0-9,-]{3,32}$"))
        {
            error = "Invalid UserName. Must be 3–32 characters and may contain letters, numbers, comma or dash.";
            return false;
        }

        return true;
    }

    public static bool IsValidPassword(string password, out string error)
    {
        error = string.Empty;
        if (string.IsNullOrWhiteSpace(password))
        {
            error = "Password is required.";
            return false;
        }


        if (!Regex.IsMatch(password!, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,32}$"))
        {
            error =
                "Invalid Password. Must be 8–32 chars and include at least one uppercase, one lowercase and one digit.";
            return false;
        }

        return true;
    }
}