namespace Auto_Auction.Models.Users;

public class CorporateUser : User
{
    public int Credit { get; set; }
    public string CVR { get; set; }

    public CorporateUser(int id, string userName, string password, int postalCode, int credit, string cvr)
        : base(id, userName, password, postalCode)
    {
        Credit = credit;
        CVR = cvr;
    }

    public override string ToString()
    {
        return base.ToString() + $", Credit: {Credit}, CVR: {CVR}";
    }
}


