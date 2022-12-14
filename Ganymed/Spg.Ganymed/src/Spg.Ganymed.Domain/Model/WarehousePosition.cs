using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class WarehousePosition
    {
        public int Id { get; private set; }
        public string Room { get; set; } = string.Empty;

        public string Shelf { get; set; } = string.Empty;

        public string Level { get; set; } = string.Empty;

        public string Compartment { get; set; } = string.Empty;

        public int WarehouseNavigationId { get; set; }
        public virtual Warehouse WarehouseNavigation { get; set; } = default!;

        private List<Equipment> _equipmentInWarehousePosition = new();
        public virtual IReadOnlyList<Equipment> EquipmentInWarehousePosition => _equipmentInWarehousePosition;

        protected WarehousePosition()
        { }
        public WarehousePosition(string room, string shelf, string level, string compartment, Warehouse warehouseNavigation)
        {
            Room = room;
            Shelf = shelf;
            Level = level;
            Compartment = compartment;
            WarehouseNavigation = warehouseNavigation;
        }
    }
}
