using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Auto_Auction.Models.Users;
using System;

namespace Auto_Auction.ViewModels;

public partial class UserProfileViewModel : ObservableObject
{
    [ObservableProperty]
    private User currentUser;

    [ObservableProperty]
    private string newPassword;

    [ObservableProperty]
    private decimal depositAmount;

    [ObservableProperty]
    private string statusMessage;

    [ObservableProperty]
    private int auctionsCreated;

    [ObservableProperty]
    private int auctionsWon;

    public UserProfileViewModel(User user)
    {
        CurrentUser = user;
        StatusMessage = "Ready";

        // Eksempel på statistik
        AuctionsCreated = 3;
        AuctionsWon = 1;
    }

    // Properties for XAML bindings
    public bool IsCorp => CurrentUser is CorporateUser;
    public bool CanDeposit => IsCorp;

    // Balance fra Buyer eller Seller
    public decimal Balance => (CurrentUser as Buyer)?.Balance
                             ?? (CurrentUser as Seller)?.Balance
                             ?? 0;

    [RelayCommand]
    private void ChangePassword()
    {
        try
        {
            CurrentUser.SetPassword(NewPassword);
            StatusMessage = "Password updated!";
            NewPassword = string.Empty;
        }
        catch (Exception ex)
        {
            StatusMessage = $"Error: {ex.Message}";
        }
    }

    [RelayCommand]
    private void Deposit()
    {
        if (CurrentUser is CorporateUser corp)
        {
            // Simulerer deposit for corporate user
            StatusMessage = $"Deposit of {DepositAmount}.";
            DepositAmount = 0;
        }
        else
        {
            StatusMessage = "Only corporate users can deposit!";
        }
    }
}
