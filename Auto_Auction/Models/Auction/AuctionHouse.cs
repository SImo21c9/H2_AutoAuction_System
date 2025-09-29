// using System;
// using System.Collections.Concurrent;
// using System.Collections.Generic;
// using Auto_Auction.Models.Users;

// namespace Auto_Auction.Models
// {
//     public class AuctionHouse
//     {
//         private int _nextAuctionId = 1;

//         private readonly ConcurrentDictionary<int, Auction> _auctions = new();
//         private readonly List<Auction> _soldAuctions = new();

//         public IEnumerable<Auction> ActiveAuctions => _auctions.Values;
//         public IEnumerable<Auction> SoldAuctions => _soldAuctions;

//         // --- SetForSale (simple) ---
//         public int SetForSale(Vehicle vehicle, Seller seller, decimal minPrice)
//         {
//             if (vehicle == null) throw new ArgumentNullException(nameof(vehicle));
//             if (seller == null) throw new ArgumentNullException(nameof(seller));
//             if (minPrice < 0) throw new ArgumentOutOfRangeException(nameof(minPrice));

//             var auctionId = _nextAuctionId++;
//             var auction = new Auction(auctionId, vehicle, seller, minPrice);
//             _auctions[auctionId] = auction;

//             return auctionId;
//         }

//         // --- SetForSale (with custom notification) ---
//         public int SetForSale(Vehicle vehicle, Seller seller, decimal minPrice, Action<string> notificationMethod)
//         {
//             var auctionId = SetForSale(vehicle, seller, minPrice);
//             seller.SetNotificationMethod(notificationMethod);
//             return auctionId;
//         }

//         // --- ReceiveBid ---
//         public bool ReceiveBid(Buyer buyer, int auctionId, decimal amount)
//         {
//             if (!_auctions.TryGetValue(auctionId, out var auction)) return false;

//             if (buyer.Balance < amount) return false; // Not enough money

//             var highestBid = auction.HighestBid;
//             if (highestBid != null && amount <= highestBid.Amount) return false; // Not higher than current

//             var bid = new Bid(buyer, amount);
//             auction.Bids.Add(bid);

//             // Notify seller if above minimum price
//             if (amount >= auction.MinimumPrice)
//             {
//                 auction.Seller.ReceiveBidNotification(
//                     $"Auction {auction.Id}: New interesting bid of {amount:C} from {buyer.UserName}");
//             }

//             return true;
//         }

//         // --- AcceptBid ---
//         public bool AcceptBid(Seller seller, int auctionId)
//         {
//             if (!_auctions.TryGetValue(auctionId, out var auction)) return false;
//             if (auction.Seller != seller) return false;

//             var winningBid = auction.HighestBid;
//             if (winningBid == null) return false;

//             // Complete transaction
//             if (winningBid.Buyer.Balance < winningBid.Amount) return false;

//             winningBid.Buyer.Balance -= winningBid.Amount;
//             seller.Balance += winningBid.Amount;

//             // Move auction from active to sold
//             _auctions.TryRemove(auctionId, out _);
//             _soldAuctions.Add(auction);

//             return true;
//         }

//         // --- FindAuctionById ---
//         public Auction? FindAuctionById(int auctionId)
//         {
//             _auctions.TryGetValue(auctionId, out var auction);
//             return auction;
//         }
//     }
// }
