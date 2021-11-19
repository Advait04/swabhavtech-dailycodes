using FancyItemsExternalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(new HatToItemAdapter(new Hat("Hat", "Premium ribboned golden hat", 500)));
            PrintCart(shoppingCart);
            Console.ReadKey();
        }
        public static void PrintCart(ShoppingCart cart)
        {
            foreach (var item in cart.items)
            {
                Console.WriteLine("Item Details:");
                Console.WriteLine("NAme:", item.ItemName());
                Console.WriteLine("Price:" + item.ItemPrice());
            }
        }
    }
}
