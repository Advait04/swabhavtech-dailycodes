using ShoppingCartLibF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, "Advait");

            Order order1 = new Order(101, new DateTime(2021, 11, 09));
            order1.AddItems(new LineItem(1, new Product(101, "Books", 250, 25), 2));
            order1.AddItems(new LineItem(2, new Product(102, "Mobile", 35000, 9), 1));

            Order order2 = new Order(102, new DateTime(2021, 11, 10));
            order2.AddItems(new LineItem(1, new Product(103, "Milk", 25, 0), 2));
            order2.AddItems(new LineItem(2, new Product(104, "Icecream", 40, 0), 1));

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            PrintDetails(customer);
            Console.ReadKey();
        }

        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine("{0}'s orders:", customer.Name);
            Console.WriteLine("No of orders: {0}", customer.OrderCount);
            foreach (var order in customer.Orders)
            {
                Console.WriteLine("Order Id: {0}", order.Id);
                Console.WriteLine("Order Date: {0}", order.DateTime);
                Console.WriteLine("Order Details:");
                Console.WriteLine("No Of Items: {0}", order.ItemCount);
                foreach (var lineItem in order.Items)
                {
                    Console.WriteLine("LineItem id: {0}", lineItem.ID);
                    Console.WriteLine("Product ID: {0}", lineItem.Product.Id);
                    Console.WriteLine("Product Name: {0}", lineItem.Product.Name);
                    Console.WriteLine("Original Price: {0}", lineItem.Product.Price);
                    Console.WriteLine("Discount: {0}", lineItem.Product.Discount);
                    Console.WriteLine("Discounted Price: {0}", lineItem.Product.GetDiscountedPrice());
                    Console.WriteLine("Quantity: {0}", lineItem.Quantity);
                    Console.WriteLine("\tTotal Price for LineItem: {0}", lineItem.TotalPrice);
                }
                Console.WriteLine("\nTotal Price for current order: {0}", order.TotalOrderPrice());
            }
            Console.WriteLine("\nTotal Amount for {0} is {1}", customer.Name, customer.GetTotalPriceOfAllOrders());

        }

    }
}

