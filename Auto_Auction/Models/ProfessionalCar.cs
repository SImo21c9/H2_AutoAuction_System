namespace Auto_Auction.Models
{
    public class ProfessionalCar : Car
    {
        public bool SafetyBar { get; private set; }
        public double LoadCapacity { get; private set; } // in kg

        public ProfessionalCar(
            int id,
            string name,
            double distance,
            int registrationNumber,
            int year,
            bool towHook,
            string vehicleType,
            string motorSize,
            double distanceByFuel,
            FuelTypeEnum fuel,
            EnergyClassEnum energyClass,
            Dimensions trunk,
            double engineSize,
            bool safetyBar,
            double loadCapacity)
            : base(id, name, distance, registrationNumber, year, towHook,
                   vehicleType, motorSize, distanceByFuel, fuel, energyClass,
                   seatCount: 2, trunk, engineSize) // commercial cars always 2 seats
        {
            SafetyBar = safetyBar;
            LoadCapacity = loadCapacity;

            // Determine required license type
            LicenceType = LoadCapacity > 750 ? "BE" : "B";
        }

        public override string ToString()
            => $"{base.ToString()}, SafetyBar: {(SafetyBar ? "Yes" : "No")}, LoadCapacity: {LoadCapacity} kg";
    }
}
