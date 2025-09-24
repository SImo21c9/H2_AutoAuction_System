namespace Auto_Auction.Models;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    //It's measured in kilometer
    public double Distance { get; set; }
    public int RegistrationNumber { get; set; }
    public int Year { get; set; }
    public bool TowHook { get; set; }
    public string VehicleType { get; set; } 
    public string LicenceType { get; set; }
    public string MotorSize { get; set; }
    // Km/L
    public string DistanceByFuel { get; set; }
    public string Fuel { get; set; }
    public string EnergyClass { get; set; }

    protected Vehicle(int id, string name, double distance, int registrationNumber, int year, bool towHook, string vehicleType, string licenceType, string motorSize, string distanceByFuel, string fuel, string energyCLass)
    {
        Id = id;
        Name = name;
        Distance = distance;
        RegistrationNumber = registrationNumber;
        Year = year;
        TowHook = towHook;
        VehicleType = vehicleType;
        LicenceType = licenceType;
        MotorSize = motorSize;
        DistanceByFuel = distanceByFuel;
        Fuel = fuel;
        EnergyClass = energyClass;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Distance: {Distance}, RegistrationNumber: {RegistrationNumber}, Year: {Year}, TowHook: {TowHook}, VehicleType: {VehicleType}, LicenceType: {LicenceType}, Motor: {MotorSize}, DistanceByFuel: {DistanceByFuel}, Fuel: {Fuel}, EnergyClass {EnergyClass}";
    }
}