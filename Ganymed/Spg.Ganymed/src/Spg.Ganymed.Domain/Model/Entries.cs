using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public class Entries
    {
        public Location LocationNavigation { get; set; } = default!;

        public User UserNavigation { get; set; } = default!;

        public Equipment EquipmentNavigation { get; set; } = default!;

        public DateTime TimeFrom { get; set; }

        public DateTime TimeUntil { get; set; }
    }
}
