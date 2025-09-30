using System.Collections.ObjectModel;
using Auto_Auction.Models;
using Auto_Auction.Models.Users;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Auto_Auction.ViewModels;

public class DashBoardViewModel : ObservableObject
{
    public ObservableCollection<Auction> UserAuctions { get; } = new();

    public DashBoardViewModel()
    {
        
        UserAuctions.Add(new Auction(1,
            new PrivateCar(1, "Toyota Camry", 2020, 123, 2020, true, "PersonalCar",  123, 20, FuelTypeEnum.Petrol, EnergyClassEnum.C, 4, new Dimensions(23, 23, 32),0.7, true),
            new Seller(1, "John Doe", "awdawd", 9200),9000));

    }
}

