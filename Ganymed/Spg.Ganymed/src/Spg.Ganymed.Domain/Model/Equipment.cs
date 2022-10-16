using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Equipment
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool Available { get; set; }

        public EquipmentType EquipmentTypeNavigator { get; set; } = default!;

        public WarehousePosition WarehousePositionNavigator { get; set; } = default!;

        public List<CartEntry> EquipmentCartEntries { get; set; } = new();
    }
}
