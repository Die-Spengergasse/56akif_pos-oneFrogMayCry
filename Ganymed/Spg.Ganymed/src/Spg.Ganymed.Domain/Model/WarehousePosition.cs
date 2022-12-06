using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class WarehousePosition
    {
        public string Room { get; } = string.Empty;

        public string Shelf { get; set; } = string.Empty;

        public string Level { get; set; } = string.Empty;

        public string Compartment { get; set; } = string.Empty;

        public Warehouse WarehouseNavigation { get; } = default!;

        public List<Equipment> _equipmentInWarehousePosition = new();
        public IReadOnlyList<Equipment> EquipmentInWarehousePosition => _equipmentInWarehousePosition;

        public WarehousePosition(string room, string shelf, string level, string compartment, Warehouse warehouseNavigation, List<Equipment> equipmentInWarehousePosition)
        {
            Room = room;
            Shelf = shelf;
            Level = level;
            Compartment = compartment;
            WarehouseNavigation = warehouseNavigation;
            _equipmentInWarehousePosition = equipmentInWarehousePosition;
        }
    }
}
