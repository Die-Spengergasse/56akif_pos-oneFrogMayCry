using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class HappeningLocation
    {
        public string ID { get; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public List<Equipment> _happeningLocationEquipment = new();
        public IReadOnlyList<Equipment> HappeningLocationEquipment => _happeningLocationEquipment;

        public List<Happening> _happeningsInLocation = new();

        public HappeningLocation(string iD, string address, List<Equipment> happeningLocationEquipment, List<Happening> happeningsInLocation)
        {
            ID = iD;
            Address = address;
            _happeningLocationEquipment = happeningLocationEquipment;
            _happeningsInLocation = happeningsInLocation;
        }

        public IReadOnlyList<Happening> HappeningsInLocation => _happeningsInLocation;
    }
}
