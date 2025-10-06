namespace Auto_Auction.Models.Users
{
    public class Buyer : User
    {

        public Buyer(int id, string userName, string password, int zipCode)
            : base(id, userName, password, zipCode)
        {
            Balance = 5000;
        }
        
        // //amount will only be deducted if you have enough money
        // public bool DeductAmount(decimal amount)
        // {
        //     if (Balance >= amount)
        //     {
        //         Balance -= amount;
        //         return true;
        //     }
        //     return false;
        // }
        
    }
}