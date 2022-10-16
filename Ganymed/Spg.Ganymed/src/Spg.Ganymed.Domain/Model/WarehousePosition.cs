using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class WarehousePosition
    {
        public string Room { get; set; } = string.Empty;

        public string Shelf { get; set; } = string.Empty;

        public string Level { get; set; } = string.Empty;

        public string Compartment { get; set; } = string.Empty;

        public Location LocationNavigation { get; set; } = default!;

        public List<Equipment> EquipmentInWarehousePosition { get; set; }
    }
}
