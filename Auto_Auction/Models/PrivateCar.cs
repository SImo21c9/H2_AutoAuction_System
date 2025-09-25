using System;

namespace Auto_Auction.Models
{
    public class PrivateCar : Car
    {
        public bool Isofix { get; private set; }

        public PrivateCar(
            int id,
            string name,
            double distance,
            int registrationNumber,
            int year,
            bool towHook,
            string vehicleType,
            double motorSize,
            double distanceByFuel,
            FuelTypeEnum fuel,
            EnergyClassEnum energyClass,
            int seatCount,
            Dimensions trunk,
            double engineSize,
            bool isofix)
            : base(id, name, distance, registrationNumber, year, towHook,
                   vehicleType, motorSize, distanceByFuel, fuel, energyClass,
                   seatCount, trunk, engineSize)
        {
            if (seatCount < 2 || seatCount > 7)
                throw new ArgumentOutOfRangeException(nameof(seatCount),
                    "Private car must have between 2 and 7 seats");

            Isofix = isofix;
        }

        public override string ToString()
            => $"{base.ToString()}, Isofix: {(Isofix ? "Yes" : "No")}";
    }
}
