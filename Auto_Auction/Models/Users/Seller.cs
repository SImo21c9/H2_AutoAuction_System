using System;

namespace Auto_Auction.Models.Users
{
    public class Seller : User
    {
        //Notification method to inform seller about new bids
        private Action<string>? _notification;
        
        public Seller(int id, string userName, string password, int zipCode) : base(id, userName, password, zipCode)
        {
            //Road to becoming richer than Putin starts from zero
            Balance = 0;
        }
        

        //Method to receive bid notifications
        public void ReceiveBidNotification(string message)
        {
            //Invoke the notification method if set, it will otherwise just print to console
            if (_notification != null)
            {
                _notification.Invoke(message);
            }
            //This is the fallback if no notification method is set
            if (_notification == null)
            {
                Console.WriteLine($"{DateTime.Now} Notification for {UserName}: {message}");
            }
        }
        
        
    }
}