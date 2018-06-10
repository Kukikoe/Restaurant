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
            Assert.IsTrue(list != null);
        }
        [TestMethod]
        public void AddDishTestMetod()
        {
            List<Dish> list = DishesDbController.GetDishes();
            int count = list.Count;
            bool res = DishesDbController.AddDish("Potato Greece", 1, 300, "gr", 60.5);
            Assert.IsTrue(res);
            List<Dish> newList = DishesDbController.GetDishes();
            Assert.AreEqual(newList.Count, ++count);
            Assert.AreEqual(newList[count - 1].Name, "Potato Greece");
            Assert.AreEqual(newList[count - 1].RecipeId, 1);
            Assert.AreEqual(newList[count - 1].PortionSize, 300);
            Assert.AreEqual(newList[count - 1].Unit, "gr");
            Assert.AreEqual(newList[count - 1].Price, 60.5);

        }
        [TestMethod]
        public void DeleteDishTestMethod()
        {
            bool resAdd = DishesDbController.AddDish("Potato Greece", 1, 300, "gr", 60.5);
            Assert.IsTrue(resAdd);
            List<Dish> list = DishesDbController.GetDishes();
            int count = list.Count;
            bool resDel = DishesDbController.DeleteDish(list[count - 1].Id);
            Assert.IsTrue(resDel);
            Assert.AreEqual(DishesDbController.GetDishes().Count, --count);
        }
    }
}
