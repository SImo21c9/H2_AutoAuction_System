using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto_Auction.Models.Users;

namespace Auto_Auction.Models
{
    public class Bid
    {
        public Buyer Buyer { get; }
        public decimal Amount { get; }
        public DateTime Timestamp { get; }

        public Bid(Buyer buyer, decimal amount)
        {
            if (buyer == null) throw new ArgumentNullException(nameof(buyer));
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Bid amount must be greater than 0.");

            Buyer = buyer;
            Amount = amount;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Buyer.UserName} bid {Amount:C} at {Timestamp}";
        }
    }
}