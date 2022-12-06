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
        public int HappeningNavigationId { get; set; }
        public Happening HappeningNavigation { get; set; } = default!;

        // public Equipment EquipmentNavigation { get; set; } = default!;
        public int CartNavigationId { get; set; }
        public Cart CartNavigation { get; } = default!;

        public CartEntry()
        { }
        public CartEntry(Happening happeningNavigation, Cart cartNavigation)
        {
            HappeningNavigation = happeningNavigation;
            CartNavigation = cartNavigation;
        }
    }
}
