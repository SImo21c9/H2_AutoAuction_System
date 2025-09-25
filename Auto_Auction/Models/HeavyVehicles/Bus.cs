using System;

namespace Auto_Auction.Models;

public class Bus : HeavyVehicle
{
    public Bus(int id, string name, double distance, int registrationNumber, int year, bool towHook, string vehicleType, double motorSize, double distanceByFuel, 
        FuelTypeEnum fuel, EnergyClassEnum energyClass, double height, double weight, double length, int numberOfSeats, bool hasToilets, int numberOfBeds) 
        : base(id, name, distance, registrationNumber, year, towHook, vehicleType, 
            // basically if Bus has a towHook licencetype it's CE but if it's not it's just C
            licenceType: towHook ? "DE" : "D", 
            motorSize, distanceByFuel, fuel, energyClass, height, weight, length)
    {
        NumberOfSeats = numberOfSeats;
        HasToilets = hasToilets;
        NumberOfBeds = numberOfBeds;
        MotorSize = motorSize;
    }

    public override string LicenceType { get; set; }
    public int NumberOfSeats { get; set; }
    public bool HasToilets { get; set; }
    public int NumberOfBeds { get; set; }

    public override string ToString()
    {
        return $"Height: {Height}, Weight: {Weight}, Length: {Length}, NumberOfSeats: {NumberOfSeats}, HasToilets: {HasToilets}, NumberOfBeds: {NumberOfBeds}, LicenceType: {LicenceType}, MotorSize: {MotorSize}";
    }
}