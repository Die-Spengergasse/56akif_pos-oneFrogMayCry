using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Happening
    {
        public List<Equipment> HappeningEquipment { get; set; } = new();

        public List<HappeningLocation> HappeningLocations { get; set; } = new();

        public List<CartEntry> HappeningInCartEntries { get; set; } = new();

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
