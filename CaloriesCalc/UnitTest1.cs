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
            recipe = new Recipe();
            recipes = new List<Recipe>();
        }

        [Test]
        public void CalculateTotalCalories_RecipeWithIngredients_ReturnsCorrectTotalCalories()
        {
            // Arrange
            recipe.ingredients = new List<string> { "Ingredient 1", "Ingredient 2", "Ingredient 3" };
            recipe.calories = new List<int> { 100, 200, 300 };

            // Act
            int totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(600, totalCalories);
        }
    }
}
