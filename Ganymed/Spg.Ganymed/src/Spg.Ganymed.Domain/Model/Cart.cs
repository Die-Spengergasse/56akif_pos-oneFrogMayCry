using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Cart
    {
        public int Id { get; set; }

        public int ItemCount { get; }

        public User UserNavigation { get; set; } = default!;

        public List<Equipment> CartEquipment { get; set; } = new();
    }
}
