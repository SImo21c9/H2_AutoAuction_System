using System;

namespace Auto_Auction.Models.Users
{
    public class Seller : User
    {
        public decimal Balance { get; set; }
        private Action<string>? _notification;
        
        public Seller(int id, string userName, string password, int postalCode) : base(id, userName, password, postalCode)
        {
            //Road to becoming richer than Putin starts from zero
            Balance = 0;
        }

        public void SetNotificationMethod(Action<string> notification)
        {
            _notification = notification;
        }

        public void ReceiveBidNotification(string message)
        {
            _notification?.Invoke((message));
            if (_notification == null)
            {
                Console.WriteLine($"{DateTime.Now} Notification for {UserName}: {message}");
            }
        }
        
        
    }
}