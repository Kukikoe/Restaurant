using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.Entities;
using RestaurantDataAccessLayer.DBControllers;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class RecipeControllerUnitTest
    {
        [TestMethod]
        public void SelectLayoutTestMethod()
        {
            List<Recipe> list = RecipeDbController.GetRecipes();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddRecipeTest()
        {
            List<Recipe> list = RecipeDbController.GetRecipes();
            int count = list.Count;
            bool res = RecipeDbController.AddRecipe("Patato with mushrooms", "Potato 100 gr on skillet witn 20 ml oil, free 30 minutes on medium fire. Then add 150 gr mushrooms and free 5 minutes. Good Luck!");
            Assert.IsTrue(res);
            Assert.AreEqual(RecipeDbController.GetRecipes().Count, ++count);
        }
    }
}
