using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartUnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product p = new Product(101, "Book", 250, .50f);
            Assert.AreEqual<int>(p.Id, 101);
            Assert.AreEqual<string>(p.Name, "Book");
            Assert.AreEqual<double>(p.Price, 250);
            Assert.AreEqual<float>(p.Discount, .50f);

        }
    }
}
