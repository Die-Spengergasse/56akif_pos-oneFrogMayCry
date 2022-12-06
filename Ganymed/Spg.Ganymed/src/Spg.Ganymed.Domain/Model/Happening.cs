using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Happening
    {
        //public List<Equipment> HappeningEquipment { get; set; } = new();

        public List<HappeningLocation> _happeningLocations = new();
        public IReadOnlyList<HappeningLocation> HappeningLocations => _happeningLocations;

        public List<CartEntry> _happeningInCartEntries = new();
        public IReadOnlyList<CartEntry> HapperningInCartEntries => _happeningInCartEntries;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Happening(List<HappeningLocation> happeningLocations, List<CartEntry> happeningInCartEntries, DateTime startTime, DateTime endTime) 
        {
            _happeningLocations = happeningLocations;
            _happeningInCartEntries = happeningInCartEntries;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
