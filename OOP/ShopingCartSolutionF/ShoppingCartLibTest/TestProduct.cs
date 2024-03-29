﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLibF.Model;
using System;

namespace ShoppingCartLibTest
{
    [TestClass]
    public class TestProduct
    {
        [TestMethod]
        public void TestProductDiscountedPrice()
        {
            Product product = new Product(101, "Books", 250.50, 0.25f);
            Assert.AreEqual<double>(249.87375, product.GetDiscountedPrice());
        }
        [TestMethod]
        public void TestProductCreation()
        {
            Product product = new Product(101, "Books", 250.50, 0.25f);
            Assert.AreEqual<int>(101, product.Id);
            Assert.AreEqual<string>("Books", product.Name);
            Assert.AreEqual<double>(250.50, product.Price);
            Assert.AreEqual<float>(0.25f, product.Discount);
        }
    }
}
