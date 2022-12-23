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
        public int Id { get; private set; }
        public int HappeningNavigationId { get; set; }
        public virtual Happening HappeningNavigation { get; set; } = default!;
        public int EquipmentNavigationId { get; set; }
        public virtual Equipment EquipmentNavigation { get; set; } = default!;
        public int CartNavigationId { get; set; }
        public virtual Cart CartNavigation { get; set; } = default!;

        protected CartEntry()
        { }
        public CartEntry(Happening happeningNavigation, Cart cartNavigation, Equipment equipmentNavigation)
        {
            HappeningNavigation = happeningNavigation;
            CartNavigation = cartNavigation;
            EquipmentNavigation = equipmentNavigation;
        }
    }
}
