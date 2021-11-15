using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacadeDesignPatternApp
{
    class RestaurantFacade
    {
        private IPizza _pizzaProvider;
        private IBread _breadProvider;
        public RestaurantFacade()
        {
            _pizzaProvider = new PizzaProvider();
            _breadProvider = new BreadProvider();
        }
        public void GetNonVegPizza()
        {
            _pizzaProvider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _pizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _breadProvider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _breadProvider.GetCheesyGarlicBread();
        }
    }
}
