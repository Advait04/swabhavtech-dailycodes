﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLibF.Model;
using System;

namespace ShoppingCartLibTest
{
    [TestClass]
    public class TestOrder
    {
        [TestMethod]
        public void TestOrderItems()
        {
            Order order = new Order(101, new DateTime(2021, 11, 09));
            order.AddItems(new LineItem(101, new Product(1, "Books", 300, 9), 2));
            order.AddItems(new LineItem(102, new Product(2, "mobile", 25000, 4), 1));
            Assert.AreEqual<int>(101, order.Items[0].ID);
            Assert.AreEqual<int>(102, order.Items[1].ID);
        }
        
        [TestMethod]
        public void TestSameProductForLineItem()
        {
            Order order = new Order(101, new DateTime(2021, 11, 10));
            order.AddItems(new LineItem(101, new Product(1, "Books", 300, 0), 2));
            order.AddItems(new LineItem(102, new Product(1, "Books", 300, 0), 1));
            order.AddItems(new LineItem(102, new Product(1, "Books", 300, 0), 2));
            Assert.AreEqual<int>(1, order.ItemCount);
        }
        [TestMethod]
        public void TestOrderItemsCount()
        {
            Order order = new Order(101, new DateTime(2021, 11, 10));
            Product product = new Product(101, "Books", 250.5, 0.25f);
            LineItem lineItem = new LineItem(1, product, 2);

            Assert.AreEqual<int>(0, order.ItemCount);
            order.AddItems(lineItem);
            order.AddItems(new LineItem(102, new Product(2, "Laptop", 2500, 5f), 1));
            Assert.AreEqual<int>(2, order.ItemCount);
        }
        [TestMethod]
        public void TestOrderLineItemQuantityCount()
        {
            Order order = new Order(101, new DateTime(2021, 11, 10));
            order.AddItems(new LineItem(101, new Product(1 , "Books", 350, 0), 2));
            order.AddItems(new LineItem(102, new Product(1 , "Books", 350, 0), 1));
            order.AddItems(new LineItem(102, new Product(1 , "Books", 350, 0), 2));
            Assert.AreEqual<int>(5, order.Items[0].Quantity);
        }
        [TestMethod]
        public void TestTotalOrderPrice()
        {
            Order order = new Order(101, new DateTime(2021, 11, 10));
            order.AddItems(new LineItem(101, new Product(1, "Books", 350, 10), 2));
            order.AddItems(new LineItem(102, new Product(2, "Mobile", 20000, 90), 1));
            Assert.AreEqual<double>(2630, order.TotalOrderPrice());
        }
    }
}
