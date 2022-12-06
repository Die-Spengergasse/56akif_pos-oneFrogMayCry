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
        public int Id { get; set; }

        public int ItemCount { get; }

        public CartStates CartState { get; set; }
        //muss für EntityFramework null sein, kann sonst nicht gemapped werden!
        public User UserNavigation { get; } = default!;

        private List<CartEntry> _cartEntries = new();

        public IReadOnlyList<CartEntry> CartEntries => _cartEntries;

        public Cart(int id, int itemCount, CartStates cartState, User userNavigation, List<CartEntry> cartEntries)
        {
            Id = id;
            ItemCount = itemCount;
            CartState = cartState;
            UserNavigation = userNavigation;
            _cartEntries = cartEntries;
        }
    }
}
