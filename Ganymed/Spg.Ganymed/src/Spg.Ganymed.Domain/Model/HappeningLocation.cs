using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class HappeningLocation
    {
        public string ID { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public List<Equipment> HappeningLocationEquipment { get; set; } = new();

        public List<Happening> HappeningsinLocation { get; set; } = new();
    }
}
