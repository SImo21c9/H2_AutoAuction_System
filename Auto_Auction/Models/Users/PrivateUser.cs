namespace Auto_Auction.Models.Users;

public class PrivateUser : User
{
   public string CPR { get; set; }

   public PrivateUser(int id, string userName, string password, int zipCode, string cpr)
      : base(id, userName, password, zipCode)
   {
      CPR = cpr;
   }

   public override string ToString()
   {
      return base.ToString() + $", CPR: {CPR}";
   }
}
