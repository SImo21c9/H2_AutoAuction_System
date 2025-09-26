using System;
using System.Text.RegularExpressions;

namespace Auto_Auction.Models.Users;

public abstract class User : IValidate
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public bool IsCorp => this is CorporateUser;
    public int PostalCode { get; set; }

    public User(int id, string userName, string password, int postalCode )
    {
        Id = id;
        UserName = userName;
        Password = password;
        PostalCode = postalCode;
    }

    public void Validate()
    {
        if (!Regex.IsMatch(UserName, @"^[A-Za-Z0-9,-]{3,32}$"))
            throw new ArgumentException("Invalid UserName, Username must be between 3 and 32 characters");
        
        if (!Regex.IsMatch(Password, @"^(?=.[a-z])(?=.[A-Z])(?=.*\d){8,}$"))
            throw new ArgumentException("Invalid Password, Password must be between 8 and 32 characters");
    }
    
    
    public override string ToString()
    {
      
        return $" Id: {Id}, UserName: {UserName}, PostalCode: {PostalCode}";
    }
    
}
