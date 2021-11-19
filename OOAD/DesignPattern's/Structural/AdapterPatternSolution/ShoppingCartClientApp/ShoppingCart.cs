using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
    public class ShoppingCart
    {
        private List<IItem> _items = new List<IItem>();
        public void AddItem(IItem item)
        {
            _items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
        }
        public List<IItem> items
        {
            get
            {
                return _items;
            }
        }
    }
}
