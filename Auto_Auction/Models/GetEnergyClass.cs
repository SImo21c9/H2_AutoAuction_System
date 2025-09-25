using System.Globalization;

namespace Auto_Auction.Models;

// Shared fuel type enum used across models
public enum FuelTypeEnum { Diesel, Petrol, Electric, Hydrogen }

// Energy class enum — method will return this instead of strings.
public enum EnergyClassEnum { A, B, C, D, Unknown }

public class GetEnergyClass
{
    public FuelTypeEnum FuelType { get; set; }
    public int Year { get; set; }
    public double DistanceByFuel { get; set; }

    // Return the energy class as an enum to avoid string-based errors
    public EnergyClassEnum EnergyClass()
    {
        switch (FuelType)
        {
            case FuelTypeEnum.Electric:
            case FuelTypeEnum.Hydrogen:
                return EnergyClassEnum.A;

            case FuelTypeEnum.Petrol:
                if (Year < 2010 && DistanceByFuel >= 18)
                    return EnergyClassEnum.A;
                if (Year < 2010 && DistanceByFuel > 14 && DistanceByFuel < 18)
                    return EnergyClassEnum.B;
                if (Year < 2010 && DistanceByFuel > 10 && DistanceByFuel <= 14)
                    return EnergyClassEnum.C;
                if (Year < 2010 && DistanceByFuel < 10)
                    return EnergyClassEnum.D;
                if (Year >= 2010 && DistanceByFuel >= 20)
                    return EnergyClassEnum.A;
                if (Year >= 2010 && DistanceByFuel > 16 && DistanceByFuel < 20)
                    return EnergyClassEnum.B;
                if (Year >= 2010 && DistanceByFuel > 12 && DistanceByFuel <= 16)
                    return EnergyClassEnum.C;
                if (Year >= 2010 && DistanceByFuel < 12)
                    return EnergyClassEnum.D;
                break;

            case FuelTypeEnum.Diesel:
                if (Year < 2010 && DistanceByFuel >= 23)
                    return EnergyClassEnum.A;
                if (Year < 2010 && DistanceByFuel > 18 && DistanceByFuel < 23)
                    return EnergyClassEnum.B;
                if (Year < 2010 && DistanceByFuel > 13 && DistanceByFuel < 18)
                    return EnergyClassEnum.C;
                if (Year < 2010 && DistanceByFuel < 13)
                    return EnergyClassEnum.D;
                if (Year >= 2010 && DistanceByFuel >= 25)
                    return EnergyClassEnum.A;
                if (Year >= 2010 && DistanceByFuel > 20 && DistanceByFuel < 25)
                    return EnergyClassEnum.B;
                if (Year >= 2010 && DistanceByFuel > 15 && DistanceByFuel <= 20)
                    return EnergyClassEnum.C;
                if (Year >= 2010 && DistanceByFuel < 15)
                    return EnergyClassEnum.D;
                break;
        }

        return EnergyClassEnum.Unknown;
    }
}