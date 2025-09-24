using System.Dynamic;

namespace Auto_Auction.Models;

public class HeavyVhicle
{
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }
    public string LicenceType { get; set; }

    public override string ToString()
    {
        return $"Height: {Height}, Weight: {Weight}, Length: {Length}, LicenceType: {LicenceType}";
    }
}