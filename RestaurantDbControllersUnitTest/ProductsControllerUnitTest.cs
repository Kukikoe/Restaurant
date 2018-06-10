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
            List<Product> list = ProductDbController.GetProducts();
            Assert.IsTrue(list != null);
        }
        [TestMethod]
        public void AddProductTestMethod()
        {
            List<Product> list = ProductDbController.GetProducts();
            int count = list.Count;
            bool res = ProductDbController.AddProduct("Potato", "gr");
            Assert.AreEqual(res, true);
            List<Product> resList = ProductDbController.GetProducts();
            Assert.AreEqual(resList.Count, ++count);
            Assert.AreEqual(resList[count - 1].Name, "Potato");
            Assert.AreEqual(resList[count - 1].Unit, "gr");
        }
        [TestMethod]
        public void DeleteProductTestMethod()
        {
            bool resAdd = ProductDbController.AddProduct("Potato", "gr");
            Assert.IsTrue(resAdd);
            List<Product> list = ProductDbController.GetProducts();
            int count = list.Count;
            bool resDel = ProductDbController.DeleteProduct(list[count - 1].Id);
            Assert.IsTrue(resDel);
            Assert.AreEqual(ProductDbController.GetProducts().Count, --count);
        }      
    }
}
