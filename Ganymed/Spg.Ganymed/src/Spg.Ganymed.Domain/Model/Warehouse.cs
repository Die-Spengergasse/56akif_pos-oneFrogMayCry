using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Warehouse
    {
        public string ID { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public List<WarehousePosition> WarehousePositions { get; set; } = new();
    }
}
