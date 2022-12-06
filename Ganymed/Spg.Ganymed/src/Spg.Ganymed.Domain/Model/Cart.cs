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
        public int Id { get; }

        public int ItemCount { get; }

        public CartStates CartState { get; set; }

        public int UserNavigationId { get; set; }
        public User UserNavigation { get; } = default!;

        private List<CartEntry> _cartEntries = new();

        public IReadOnlyList<CartEntry> CartEntries => _cartEntries;

        protected Cart()
        { }
        public Cart(int itemCount, CartStates cartState, User userNavigation)
        {
            ItemCount = itemCount;
            CartState = cartState;
            UserNavigation = userNavigation;
        }
    }
}
