using System;
using System.Text.RegularExpressions;
using Auto_Auction.Security;

namespace Auto_Auction.Models.Users
{
    public class User : IValidate
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        // Store hashed password, not plain text
        public string PasswordHash { get; private set; }
        
        
        public bool CanSell => this is Seller;
        public int ZipCode { get; set; }
        public decimal Balance { get; set; }

        public User(int id, string userName, string password, int zipCode)
        {
            Id = id;
            UserName = userName;
            SetPassword(password); // Hash happens here
            ZipCode = zipCode;
        }

        public void SetPassword(string password)
        {
            // Validate password complexity
            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,32}$"))
                throw new ArgumentException("Invalid Password. Must be 8–32 chars, include upper, lower, and digit.");

            PasswordHash = PasswordHasher.Hash(password);
        }

        public bool VerifyPassword(string password)
        {
            return PasswordHasher.Verify(password, PasswordHash);
        }

        public void Validate()
        {
            if (!Regex.IsMatch(UserName, @"^[A-Za-z0-9,-]{3,32}$"))
                throw new ArgumentException("Invalid UserName. Must be 3–32 characters.");
        }

        public override string ToString()
        {
            return $"Id: {Id}, UserName: {UserName}, PostalCode: {ZipCode}";
        }
    }
}
