using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternApp
{
   public class PizzaProvider:IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Get Non-Veg Pizza...");
        }
        public void GetVegPizza()
        {

            Console.WriteLine("Get Non-Veg Pizza...");
        }
        public void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non-Veg Pizza Toppings...");
        }
    }
}
