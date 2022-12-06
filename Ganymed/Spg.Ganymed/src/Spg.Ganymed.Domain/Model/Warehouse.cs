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
        public string ID { get; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        private List<WarehousePosition> _warehousePositions = new();
        public IReadOnlyList<WarehousePosition> WarehousePositions => _warehousePositions;

        public Warehouse(string iD, string address, List<WarehousePosition> warehousePositions)
        {
            ID = iD;
            Address = address;
            _warehousePositions = warehousePositions;
        }
    }
}
