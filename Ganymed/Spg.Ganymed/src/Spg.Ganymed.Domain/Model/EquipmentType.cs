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

        public List<Equipment> EquipmentOfType { get; set; }
    }
}
