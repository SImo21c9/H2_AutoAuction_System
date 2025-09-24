
using System.Globalization;

namespace Auto_Auction.Models;

public class GetEnergyClass
{
    public enum FuelTypeEnum { Diesel, Petrol, Electric, Hydrogen }
    public FuelTypeEnum FuelType { get; set; }
    public int Year { get; set; }
    public double DistanceByFuel { get; set; }

    public string EnergyClass()
    {
        switch (FuelType)
        {
            case FuelTypeEnum.Electric:
                return "A";
            case FuelTypeEnum.Hydrogen:
                return "A";

            case FuelTypeEnum.Petrol:
                if (Year < 2010 && DistanceByFuel >= 18)
                    return "A";
                if (Year < 2010 && DistanceByFuel > 14 && DistanceByFuel < 18)
                    return "B";
                if (Year < 2010 && DistanceByFuel > 10 && DistanceByFuel <= 14)
                    return "C";
                if (Year < 2010 && DistanceByFuel < 10)
                    return "D";
                if (Year >= 2010 && DistanceByFuel >= 20)
                    return "A";
                if (Year >= 2010 && DistanceByFuel > 16 && DistanceByFuel < 20)
                    return "B";
                if (Year >= 2010 && DistanceByFuel > 12 && DistanceByFuel <= 16)
                    return "C";
                if (Year >= 2010 && DistanceByFuel < 12)
                    return "D";
                break;
            case FuelTypeEnum.Diesel:
                if (Year < 2010 && DistanceByFuel >= 23)
                    return "A";
                if (Year < 2010 && DistanceByFuel > 18 && DistanceByFuel < 23)
                    return "B";
                if (Year < 2010 && DistanceByFuel > 13 && DistanceByFuel < 18)
                    return "C";
                if (Year < 2010 && DistanceByFuel < 13)
                    return "D";
                if (Year >= 2010 && DistanceByFuel >= 25)
                    return "A";
                if (Year >= 2010 && DistanceByFuel > 20 && DistanceByFuel < 25)
                    return "B";
                if (Year >= 2010 && DistanceByFuel > 15 && DistanceByFuel <= 20)
                    return "C";
                if (Year >= 2010 && DistanceByFuel < 15)
                    return "D";
                break;

        }
        
        
        return "Unknown";
    }
}