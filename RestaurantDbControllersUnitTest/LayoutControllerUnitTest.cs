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
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddLayoutTestMethod()
        {
            List<Layout> list = LayoutDbController.GetLayouts();
            int count = list.Count;
            bool res1 = LayoutDbController.AddLayout(100, 1, 1);
            bool res2 = LayoutDbController.AddLayout(150, 1, 8);
            bool res3 = LayoutDbController.AddLayout(20, 1, 13);
            Assert.AreEqual(res1, true);
            Assert.AreEqual(res2, true);
            Assert.AreEqual(res3, true);
            Assert.AreEqual(LayoutDbController.GetLayouts().Count, count + 3);
        }
    }
}
