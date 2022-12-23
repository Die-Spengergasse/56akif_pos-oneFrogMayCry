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
        public int Id { get; private set; }

        public Address? Address { get; set; }

        private List<WarehousePosition> _warehousePositions = new();
        public virtual IReadOnlyList<WarehousePosition> WarehousePositions => _warehousePositions;

        protected Warehouse()
        { }
        public Warehouse(Address? address)
        {
            Address = address;
        }
    }
}
