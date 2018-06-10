using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.DBControllers;
using Restaurant.Entities;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class LayoutControllerUnitTest
    {
        [TestMethod]
        public void SelectLayoutTestMethod()
        {
            List<Layout> list = LayoutDbController.GetLayouts();
            Assert.IsTrue(list != null);
        }
        [TestMethod]
        public void AddLayoutTestMethod()
        {
            List<Layout> list = LayoutDbController.GetLayouts();
            int count = list.Count;
            bool res = LayoutDbController.AddLayout(1, 1, 100.5);
            Assert.IsTrue(res);
            List<Layout> newList = LayoutDbController.GetLayouts();
            Assert.AreEqual(newList.Count, ++count);
            Assert.AreEqual(newList[count - 1].IdDish, 1);
            Assert.AreEqual(newList[count - 1].IdProduct, 1);
            Assert.AreEqual(newList[count - 1].Quantity, 100.5);
        }

        [TestMethod]
        public void DeleteLayoutTestMetod()
        {
            bool resAdd = LayoutDbController.AddLayout(1, 1, 100.5);
            Assert.IsTrue(resAdd);
            List<Layout> list = LayoutDbController.GetLayouts();
            int count = list.Count;
            bool resDel = LayoutDbController.DeleteLayout(list[count - 1].Id);
            Assert.IsTrue(resDel);
            Assert.AreEqual(LayoutDbController.GetLayouts().Count, --count);
        } 
    }
}
