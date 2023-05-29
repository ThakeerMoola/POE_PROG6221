using NUnit.Framework;
using System.Collections.Generic;

namespace PoePart2.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        private Recipe recipe;
        private List<Recipe> recipes;

        [SetUp]
        public void Setup()
        {
            //method being called 
            recipe = new Recipe();
            //Array List <t> being called 
            recipes = new List<Recipe>();
        }

        [Test]
        //testing the calorie calculation method =
        public void CalculateTotalCalories_RecipeWithIngredients_ReturnsCorrectTotalCalories()
        {
            // Arrange
            recipe.ingredients = new List<string> { "Ingredient 1", "Ingredient 2", "Ingredient 3" };
            recipe.calories = new List<int> { 100, 200, 300 };
            // this test is testing three ingredients which was entered from the user, for each of these ingredients the user provided the program
            //with 3 inputs. these 3 input were 100 for ingredient 2, 200 for ingredient 2 and 300 for ingredient .
            //the total of these will be totaled below

            // Act
            int totalCalories = recipe.CalculateTotalCalories();
            //the total calories method is used to total these 3 calorie inputs from the user
            //the total is 100+200+300 = 600 cals
            //this is how the program should work

            // Assert
            Assert.AreEqual(600, totalCalories);
            //this is the correct value being displayed 
        }
    }
}
