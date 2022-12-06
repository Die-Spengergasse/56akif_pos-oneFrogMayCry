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

        //public Happening CurrentHappeningNavigation { get; set; } = default!;

        public HappeningLocation CurrentHappeningLocationNavigation { get; set; } = default!;

        public EquipmentType EquipmentTypeNavigation { get; } = default!;

        public WarehousePosition WarehousePositionNavigation { get; set; } = default!;

        public List<CartEntry> _equipmentInCartEntries = new();
        public IReadOnlyList<CartEntry> EquipmentInCartEntries => _equipmentInCartEntries;

        public Equipment(int iD, string name, string description, bool available, HappeningLocation currentHappeningLocationNavigation, EquipmentType equipmentTypeNavigation, WarehousePosition warehousePositionNavigation, List<CartEntry> equipmentInCartEntries)
        {
            ID = iD;
            Name = name;
            Description = description;
            Available = available;
            CurrentHappeningLocationNavigation = currentHappeningLocationNavigation;
            EquipmentTypeNavigation = equipmentTypeNavigation;
            WarehousePositionNavigation = warehousePositionNavigation;
            _equipmentInCartEntries = equipmentInCartEntries;
        }
    }
}
