using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class CartEntry
    {
        public Happening HappeningNavigation { get; set; } = default!;

        // public Equipment EquipmentNavigation { get; set; } = default!;

        public Cart CartNavigation { get; set; } = default!;
    }
}
