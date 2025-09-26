namespace Auto_Auction.Models.Users;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public int PostalCode { get; set; }

    public User(int id, string userName, string password, int postalCode )
    {
        Id = id;
        UserName = userName;
        Password = password;
        PostalCode = postalCode;
    }
    
    
    public override string ToString()
    {
        return $"Id: {Id}, UserName: {UserName}, Password: {Password}, PostalCode: {PostalCode}";
    }
}