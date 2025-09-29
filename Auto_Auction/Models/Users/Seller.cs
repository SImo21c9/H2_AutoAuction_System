using System;

namespace Auto_Auction.Models.Users
{
    public class Seller : User
    {
        public Seller(int id, string userName, string password, int postalCode) : base(id, userName, password, postalCode)
        {
            
        }
        
        
    }
}