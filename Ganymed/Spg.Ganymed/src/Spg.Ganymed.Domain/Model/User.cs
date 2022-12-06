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
        public int ID { get; }

        public Genders MyProperty { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string EMail { get; set; } = string.Empty;

        public string PwdHash { get; } = string.Empty;

        public DateTime RegistrationDateTime { get; }

       // public List<Cart> UserCarts { get; set; } = new();     <---- not save
        private List<Cart> _userCarts = new();
        public IReadOnlyList<Cart> UserCarts => _userCarts;    //<---- more save

        protected User()
        { }
        public User(Genders myProperty, string firstName, string lastName, string username, string eMail, string pwdHash, DateTime registrationDateTime)
        {
            MyProperty = myProperty;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EMail = eMail;
            PwdHash = pwdHash;
            RegistrationDateTime = registrationDateTime;
        }
    }
}
