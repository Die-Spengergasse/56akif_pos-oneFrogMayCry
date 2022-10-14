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

        public DateTime RegistrationDateTime { get; init; }

        public List<Cart> UserCarts { get; set; } = new();
    }
}
