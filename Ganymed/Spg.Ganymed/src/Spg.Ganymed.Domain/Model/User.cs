using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public enum Genders { Male, Female, Other}

    public class User
    {
        public int ID { get; set; }

        public Genders MyProperty { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string EMail { get; set; } = string.Empty;

        public string PwdHash { get; set; } = string.Empty;

        public DateTime RegistrationDateTime { get; init; }

       // public List<Cart> UserCarts { get; set; } = new();     <---- not save
        public List<Cart> _userCarts = new();

        public IReadOnlyList<Cart> UserCarts => _userCarts;    //<---- more save

        public User(int iD, Genders myProperty, string firstName, string lastName, string username, string eMail, string pwdHash, DateTime registrationDateTime, List<Cart> userCarts)
        {
            ID = iD;
            MyProperty = myProperty;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EMail = eMail;
            PwdHash = pwdHash;
            RegistrationDateTime = registrationDateTime;
            _userCarts = userCarts;
        }
    }
}
