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
        public int Id { get; private set; }
        private List<HappeningLocation> _happeningLocations = new();
        public IReadOnlyList<HappeningLocation> HappeningLocations => _happeningLocations;

        private List<CartEntry> _happeningInCartEntries = new();
        public IReadOnlyList<CartEntry> HapperningInCartEntries => _happeningInCartEntries;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        protected Happening()
        { }
        public Happening(DateTime startTime, DateTime endTime) 
        {
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
