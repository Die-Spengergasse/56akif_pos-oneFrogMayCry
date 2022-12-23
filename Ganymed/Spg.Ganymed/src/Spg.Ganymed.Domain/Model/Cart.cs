using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Model
{
    public enum CartStates { Active = 0, Sent = 1, Unknown = 99 }

    public class Cart
    {
        public int Id { get; private set; }

        public int ItemCount => _cartEntries.Count;

        public CartStates CartState { get; set; }

        public int UserNavigationId { get; set; }
        public virtual User UserNavigation { get; private set; } = default!;

        private List<CartEntry> _cartEntries = new();

        public virtual IReadOnlyList<CartEntry> CartEntries => _cartEntries;

        protected Cart()
        { }
        public Cart(CartStates cartState, User userNavigation)
        {
            CartState = cartState;
            UserNavigation = userNavigation;
        }
    }
}
