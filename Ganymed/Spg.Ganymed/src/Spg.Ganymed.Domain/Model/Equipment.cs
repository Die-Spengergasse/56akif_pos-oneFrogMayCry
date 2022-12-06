using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Equipment
    {
        public int ID { get; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool Available { get; set; }

        //public Happening CurrentHappeningNavigation { get; set; } = default!;
        public int CurrentHappeningLocationNavigationId { get; set; }
        public HappeningLocation CurrentHappeningLocationNavigation { get; set; } = default!;

        public int EquipmentTypeNavigationId { get; set; }
        public EquipmentType EquipmentTypeNavigation { get; } = default!;

        public int WarehousePositionNavigationId { get; set; }
        public WarehousePosition WarehousePositionNavigation { get; set; } = default!;

        private List<CartEntry> _equipmentInCartEntries = new();
        public IReadOnlyList<CartEntry> EquipmentInCartEntries => _equipmentInCartEntries;

        protected Equipment()
        { }
        public Equipment(string name, string description, bool available, HappeningLocation currentHappeningLocationNavigation, EquipmentType equipmentTypeNavigation, WarehousePosition warehousePositionNavigation)
        {
            Name = name;
            Description = description;
            Available = available;
            CurrentHappeningLocationNavigation = currentHappeningLocationNavigation;
            EquipmentTypeNavigation = equipmentTypeNavigation;
            WarehousePositionNavigation = warehousePositionNavigation;
        }
    }
}
