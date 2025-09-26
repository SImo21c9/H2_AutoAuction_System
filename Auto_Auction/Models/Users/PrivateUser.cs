namespace Auto_Auction.Models.Users;

public class PrivateUser : User
{
   public string CPR { get; set; }

   public PrivateUser(int id, string userName, string password, int postalCode, string cpr)
      : base(id, userName, password, postalCode)
   {
      CPR = cpr;
   }

   public override string ToString()
   {
      return base.ToString() + $", CPR: {CPR}";
   }
}
