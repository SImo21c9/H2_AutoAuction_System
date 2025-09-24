using System;
using System.Dynamic;

namespace Auto_Auction.Models;
public abstract class HeavyVhicle
{
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public abstract string LicenceType { get; set; }
    public double MotorSize { get; set; }


    protected virtual void ValidateEngineSize(double motorSize)
    {
        if (motorSize >= 4.2 && motorSize <= 15)
            throw new ArgumentOutOfRangeException("MotorSize must be between 4.2 and 15");
    }

    public override string ToString()
    {
        return $"Height: {Height}, Weight: {Weight}, Length: {Length}, LicenceType: {LicenceType}, MotorSize: {MotorSize}";
    }
}