using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.Entities;
using Restaurant.DBControllers;

namespace RestaurantDbControllersUnitTest
{
    [TestClass]
    public class RecipeControllerUnitTest
    {
        [TestMethod]
        public void SelectLayoutTestMethod()
        {
            List<Recipe> list = RecipeDbController.GetRecipes();
            Assert.IsTrue(list != null);
        }
        [TestMethod]
        public void AddRecipeTestMethod()
        {
            List<Recipe> list = RecipeDbController.GetRecipes();
            int count = list.Count;
            bool res = RecipeDbController.AddRecipe("Test name", "Test Recipe");
            Assert.IsTrue(res);
            List<Recipe> resList = RecipeDbController.GetRecipes();
            Assert.AreEqual(resList.Count, ++count);
            Assert.AreEqual(resList[count - 1].NameDish, "Test name");
            Assert.AreEqual(resList[count - 1].Recipy, "Test Recipe");
        }

        [TestMethod]
        public void DeleteRecipeTestMethod()
        {
            bool resAdd = RecipeDbController.AddRecipe("Test name", "Test Recipe");
            Assert.IsTrue(resAdd);
            List<Recipe> list = RecipeDbController.GetRecipes();
            int count = list.Count;
            bool res = RecipeDbController.DeleteRecipe(list[count - 1].Id);
            Assert.IsTrue(res);
            List<Recipe> resList = RecipeDbController.GetRecipes();
            Assert.AreEqual(resList.Count, --count);
        }
    }
}
