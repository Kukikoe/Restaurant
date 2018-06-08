using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.DBControllers;
using Restaurant.Entities;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class DishesControllerUnitTest
    {
        [TestMethod]
        public void SelectDishesTest()
        {
            List<Dish> list = DishesDbController.GetDishes();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddDishesTest()
        {
            List<Dish> list = DishesDbController.GetDishes();
            int count = list.Count;
            bool res = DishesDbController.AddDish("Potato Greece", 1, 300, "gr", 60);
            Assert.IsTrue(res);
            Assert.AreEqual(DishesDbController.GetDishes().Count, ++count);
        }
    }
}
