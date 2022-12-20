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

        private List<Equipment> _equipmentOfType = new();
        public IReadOnlyList<Equipment> EquipmentOfType => _equipmentOfType;

        protected EquipmentType()
        { }
        public EquipmentType(string type)
        {
            Type = type;
        }
    }
}
