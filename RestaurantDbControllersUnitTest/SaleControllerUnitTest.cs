using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.DBControllers;
using Restaurant.Entities;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class SaleControllerUnitTest
    {
        [TestMethod]
        public void SelectSalesTestMethod()
        {
            List<Sale> list = SaleDbController.GetSales();
            Assert.IsTrue(list!=null);
        }
        [TestMethod]
        public void AddSaleTest()
        {
            List<Sale> list = SaleDbController.GetSales();
            int count = list.Count;
            bool res = SaleDbController.AddSale(1, 5);
            Assert.IsTrue(res);
            Assert.AreEqual(SaleDbController.GetSales().Count, ++count);
            List<Sale> resList = SaleDbController.GetSales();
            Assert.AreEqual(resList[count - 1].IdDish, 1);
            Assert.AreEqual(resList[count - 1].NumOfSales, 5);
            Assert.AreEqual(resList[count - 1].TotalAmount, 155);
        }

        [TestMethod]
        public void DeleteSaleTest()
        {
            bool resAdd = SaleDbController.AddSale(1, 5);
            Assert.IsTrue(resAdd);
            List<Sale> list = SaleDbController.GetSales();
            int count = list.Count;
            bool res = SaleDbController.DeleteSale(list[count - 1].Id);
            Assert.IsTrue(res);
            Assert.AreEqual(SaleDbController.GetSales().Count, --count);
        } 
    }
}
