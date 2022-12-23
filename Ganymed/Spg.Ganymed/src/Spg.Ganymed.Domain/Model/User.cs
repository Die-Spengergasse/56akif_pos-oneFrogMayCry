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
        public int Id { get; private set; }

        public Genders Gender { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string EMail { get; set; } = string.Empty;

        public string PwdHash { get; private set; } = string.Empty;

        public DateTime RegistrationDateTime { get; private set; }

       // public List<Cart> UserCarts { get; set; } = new();     <---- not save
        private List<Cart> _userCarts = new();
        public virtual IReadOnlyList<Cart> UserCarts => _userCarts;    //<---- more save

        protected User()
        { }
        public User(Genders gender, string firstName, string lastName, string username, string eMail, string pwdHash, DateTime registrationDateTime)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            EMail = eMail;
            PwdHash = pwdHash;
            RegistrationDateTime = registrationDateTime;
        }
    }
}
