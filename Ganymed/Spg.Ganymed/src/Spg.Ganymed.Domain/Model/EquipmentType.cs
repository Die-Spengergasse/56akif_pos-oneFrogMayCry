using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class EquipmentType
    {
        public string Type { get; set; } = string.Empty;

        public List<Equipment> _equipmentOfType = new();
        public IReadOnlyList<Equipment> EquipmentOfType => _equipmentOfType;

        public EquipmentType(string type, List<Equipment> equipmentOfType)
        {
            Type = type;
            _equipmentOfType = equipmentOfType;
        }
    }
}
