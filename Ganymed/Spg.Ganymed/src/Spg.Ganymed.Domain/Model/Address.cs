using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Address
    {
        public string Street { get; } = default!;
        public string Number { get; } = default!;
        public int  Zip { get; }
        public string City { get; } = default!;

        protected Address()
        { }

        public Address(string street, string number, int zip, string city)
        {
            Street = street;
            Number = number;
            Zip = zip;
            City = city;
        }
    }
}
