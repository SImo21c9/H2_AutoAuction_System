using System;

namespace Auto_Auction.Models
{
    public abstract class Car : Vehicle
    {
        public int SeatCount { get; protected set; }
        public Dimensions Trunk { get; protected set; }

        private double _engineSize;
        public double EngineSize
        {
            get => _engineSize;
            protected set
            {
                if (value < 0.7 || value > 10.0)
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "Engine size must be between 0.7 and 10.0 L");
                _engineSize = value;
            }
        }

        protected Car(
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
            int seatCount,
            Dimensions trunk,
            double engineSize)
            : base(id, name, distance, registrationNumber, year, towHook,
                   vehicleType, "B", motorSize, distanceByFuel, fuel, energyClass) // default B
        {
            SeatCount = seatCount;
            Trunk = trunk;
            EngineSize = engineSize;
        }

        public override string ToString()
            => $"{Name} ({Year}) - {SeatCount} seats, Engine: {EngineSize} L, Trunk: {Trunk}, Requires {LicenceType} license";
    }
}
