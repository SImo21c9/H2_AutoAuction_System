using System;

namespace Auto_Auction.Models;

public abstract class HeavyVehicle : Vehicle
{
    protected HeavyVehicle(int id, string name, double distance, int registrationNumber, int year, bool towHook, string vehicleType, string licenceType, 
        double motorSize, double distanceByFuel, FuelTypeEnum fuel, EnergyClassEnum energyClass, double height, double weight, double length) : 
        base(id, name, distance, registrationNumber, year, towHook, vehicleType, licenceType, motorSize, distanceByFuel, fuel, energyClass)
    {
        Height = height;
        Weight = weight;
        Length = length;
    }

    public double Height { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    

    private double _motorSize;
    public new double MotorSize
    {
        get => _motorSize;
        protected set
        {
            if (value < 4.2 || value > 15.0)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Engine size must be between 4.2 and 15.0 L");
            _motorSize = value;
        }
    }

    public override string ToString()
    {
        return $"Height: {Height}, Weight: {Weight}, Length: {Length}, LicenceType: {LicenceType}, MotorSize: {MotorSize}";
    }
}