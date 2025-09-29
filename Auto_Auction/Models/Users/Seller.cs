using System;

namespace Auto_Auction.Models.Users
{
    public class Seller : User
    {
        public decimal Balance { get; set; }
        //created a private action delegate with the that takes string parameter and return void  
        private Action<string>? _notificationMethod;

        public Seller(int id, string userName, string password, int postalCode) 
            : base(id, userName, password, postalCode)
        {
            //the journey to be Putin 
            Balance = 10;
        }

        //This method allows to plugin thy own method (thy just means you or whatever)
        public void SetNotificationMethod(Action<string> notificationMethod)
        {
            //it will be stored in _notificationMethod;
            _notificationMethod = notificationMethod;
        }

        public void ReceiveBidNotification(string message)
        {
            _notificationMethod?.Invoke(message);
           
            if (_notificationMethod == null)
            {
                Console.WriteLine($"[{DateTime.Now}] Notification for {UserName}: {message}");
            }
        }
    }
}