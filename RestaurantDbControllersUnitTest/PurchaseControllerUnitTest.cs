using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.DBControllers;
using Restaurant.Entities;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class PurchaseControllerUnitTest
    {
        [TestMethod]
        public void SelectPurchasesTestMethod()
        {
            List<Purchase> list = PurchaseDbController.GetPurchases();
            Assert.IsTrue(list != null);
        }
        [TestMethod]
        public void AddPurchaseTestMethod()
        {
            List<Purchase> list = PurchaseDbController.GetPurchases();
            int count = list.Count;
            bool res = PurchaseDbController.AddPurchase(11, 15.5, 5, "kg");
            Assert.IsTrue(res);
            Assert.AreEqual(PurchaseDbController.GetPurchases().Count, ++count);
            List<Purchase> resList = PurchaseDbController.GetPurchases();
            Assert.AreEqual(resList[count - 1].IdProduct, 11);
            Assert.AreEqual(resList[count - 1].Quantity, 15.5);
            Assert.AreEqual(resList[count - 1].Price, 5);
            Assert.AreEqual(resList[count - 1].Unit, "kg");
        }

        [TestMethod]
        public void DeletePurchaseTestMethod()
        {
            bool resAdd = PurchaseDbController.AddPurchase(11, 15.5, 5, "kg");
            Assert.IsTrue(resAdd);
            List<Purchase> list = PurchaseDbController.GetPurchases();
            int count = list.Count;
            bool resDel = PurchaseDbController.DeletePurchase(list[count - 1].Id);
            Assert.IsTrue(resDel);
            Assert.AreEqual(PurchaseDbController.GetPurchases().Count, --count);
        }  
    }
}
