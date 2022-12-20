using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class HappeningLocation
    {
        public int Id { get; private set; }

        public Address? Address { get; set; }

        private List<Equipment> _happeningLocationEquipment = new();
        public IReadOnlyList<Equipment> HappeningLocationEquipment => _happeningLocationEquipment;

        private List<Happening> _happeningsInLocation = new();
        public IReadOnlyList<Happening> HappeningsInLocation => _happeningsInLocation;

        protected HappeningLocation()
        { }
        public HappeningLocation(Address? address)
        {
            Address = address;
        }
    }
}
