using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLibF.Model;
using System;

namespace ShoppingCartLibTest
{
    [TestClass]
    public class TestCustomer
    {
       
        [TestMethod]
        public void TestCustomerOrder()
        {
            Customer customer = new Customer(101, "Advait");
            Order order1 = new Order(101, new DateTime(2021, 11, 10));
            order1.AddItems(new LineItem(101, new Product(101, "Books", 250, 0), 2));
            order1.AddItems(new LineItem(102, new Product(102, "Mobile", 25000, 0), 1));

            Order order2 = new Order(102, new DateTime(2021, 11, 10));
            order2.AddItems(new LineItem(103, new Product(103, "Milk", 25, 0), 2));
            order2.AddItems(new LineItem(102, new Product(102, "Icecream", 50, 0), 1));

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            Assert.AreEqual<int>(102, customer.Orders[1].Id);
        }
        [TestMethod]
        public void TestCustomerOrderCount()
        {
            Customer customer = new Customer(101, "Advait");
            Assert.AreEqual<int>(0, customer.OrderCount);
            Order order1 = new Order(101, new DateTime(2021, 11, 10));
            order1.AddItems(new LineItem(101, new Product(101, "Books", 250, 0), 2));
            order1.AddItems(new LineItem(102, new Product(102, "Mobile", 25000, 0), 1));

            Order order2 = new Order(102, new DateTime(2021, 11, 10));
            order2.AddItems(new LineItem(103, new Product(103, "Milk", 25, 0), 3));
            order2.AddItems(new LineItem(102, new Product(104, "icecCream", 50, 0), 2));

            customer.AddOrder(order1);
            customer.AddOrder(order2);
            Assert.AreEqual<int>(2, customer.OrderCount);
        }
    }
}
