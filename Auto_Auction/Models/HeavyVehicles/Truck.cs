using System;

namespace Auto_Auction.Models;

public class Truck : HeavyVehicle
{
    public Truck(int id, string name, double distance, int registrationNumber, int year, bool towHook, string vehicleType, double motorSize, double distanceByFuel, FuelTypeEnum fuel, EnergyClassEnum energyClass, double height, double weight, double length, double loadingAbility) 
        : base(id, name, distance, registrationNumber, year, towHook, vehicleType, 
           // basically if Truck has a towHook licencetype it's CE but if it's not it's just C
            licenceType: towHook ? "CE" : "C", motorSize, distanceByFuel, fuel, energyClass, height, weight, length)
    {
        LoadingAbility = loadingAbility;
        MotorSize = motorSize;
    }

    public double LoadingAbility { get; set; }
    public override string LicenceType { get; set; }

    public override string ToString()
    {
        return $"Height: {Height}, Weight: {Weight}, Length: {Length}, LoadingAbility: {LoadingAbility}, LicenceType: {LicenceType}, MotorSize: {MotorSize}";
    }
}