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
        public int Id { get; }

        public string Address { get; set; } = string.Empty;

        private List<WarehousePosition> _warehousePositions = new();
        public IReadOnlyList<WarehousePosition> WarehousePositions => _warehousePositions;

        protected Warehouse()
        { }
        public Warehouse(string address)
        {
            Address = address;
        }
    }
}
