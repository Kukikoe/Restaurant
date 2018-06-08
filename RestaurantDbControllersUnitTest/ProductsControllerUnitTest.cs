using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.DBControllers;
using Restaurant.Entities;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class ProductsControllerUnitTest
    {
        [TestMethod]
        public void SelectProductsTestMethod()
        {
            List<Product> list = ProductDBController.GetProduct();
            Assert.AreEqual(list.Count, 0);
        }
        [TestMethod]
        public void AddProductTestMethod()
        {
            List<Product> list = ProductDBController.GetProduct();
            int count = list.Count;
            bool res = ProductDBController.AddProduct("Potato", "gr");
            Assert.AreEqual(res, true);
            Assert.AreEqual(ProductDBController.GetProduct().Count, ++count);
        }
    }
}
