using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Auction.Models
{
    public class Auction
    {
        public int Id { get; }
        public Vehicle Vehicle { get; }
        public Seller Seller { get; }
        public decimal MinimumPrice { get; }
        public List<Bid> Bids { get; } = new();

        public Auction(int id, Vehicle vehicle, Seller seller, decimal minimumPrice)
        {
            Id = id;
            Vehicle = vehicle ?? throw new ArgumentNullException(nameof(vehicle));
            Seller = seller ?? throw new ArgumentNullException(nameof(seller));
            MinimumPrice = minimumPrice >= 0 ? minimumPrice
                                             : throw new ArgumentOutOfRangeException(nameof(minimumPrice));
        }

        public Bid? HighestBid => Bids.OrderByDescending(b => b.Amount).FirstOrDefault();

        public override string ToString()
        {
            return $"Auction {Id}: {Vehicle.Name} ({Vehicle.Year}), MinPrice: {MinimumPrice}, CurrentHighest: {HighestBid?.Amount ?? 0}";
        }
    }

}