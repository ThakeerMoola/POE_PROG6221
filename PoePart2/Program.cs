using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PoePart2
{
    internal class Recipe
    {
        // Define a delegate for the calorie notification
        public delegate void CalorieNotification(int totalCalories);

        // Define an event based on the delegate
        public event CalorieNotification OnCalorieExceeded;

        public string RecipeName { get; set; }
        private List<string> ingredients;
        private List<string> units;
        private List<double> quantity;
        private List<int> calories;
        private List<string> foodgroup;
        private string[] steps;

        // Constructor
        public Recipe()
        {
            ingredients = new List<string>();
            units = new List<string>();
            quantity = new List<double>();
            calories = new List<int>();
            foodgroup = new List<string>();
        }

        // Display recipe instructions
        public void DisplayRecipe()
        {
            Console.WriteLine("--------------------------------\n" +
                              "Instructions:\n" +
                              "--------------------------------\n");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}\n");
            }

            Console.ResetColor();
        }

        // Add a recipe
        public void AddRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {

                Console.WriteLine("Please enter the name of the recipe");
                RecipeName = Console.ReadLine();

                Console.WriteLine("\nPlease enter the number of ingredients for your special dish:");
                int amount = int.Parse(Console.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine($"\nEnter ingredient {i + 1} for {RecipeName}:");
                    ingredients.Add(Console.ReadLine());

                    Console.WriteLine($"Enter calories for {ingredients[i]} for {RecipeName}:");
                    calories.Add(int.Parse(Console.ReadLine()));

                    Console.WriteLine($"select the food group from the list:\n 1)poultry\n 2)Dairy\n 3)Vegetables and fruits\n 4)Grains\n 5)Fats and oils Enter the food group for {ingredients[i]} for {RecipeName}:");
                    foodgroup.Add(Console.ReadLine());

                    Console.WriteLine($"\nEnter quantity for {ingredients[i]}:");
                    quantity.Add(double.Parse(Console.ReadLine()));

                    Console.WriteLine($"\nEnter units of measurement for {ingredients[i]}:");
                    units.Add(Console.ReadLine());

                    Console.ResetColor();
                }

                int totalCalories = calories.Sum();

                Console.WriteLine("--------------------------------\n" +
                    $"Recipe Ingredients for {RecipeName}:\n" +
                    "--------------------------------\n");

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine($"\n{ingredients[i]} - {quantity[i]} {units[i]}\n {calories[i]} Cals \n Food groups: {foodgroup[i]}");
                }

                Console.WriteLine($"\nTotal Calories: {totalCalories}");

                if (totalCalories < 100)
                {
                    Console.WriteLine("Low calorie encounter, this recipe is perfect for people on a diet");
                }
                else if (totalCalories > 100 && totalCalories <= 300)
                {
                    Console.WriteLine("Moderate calorie encounter, this recipe is suitable for most people");
                }
                else
                {
                    // If the total calories exceed 300, raise the event to notify the user
                    OnCalorieExceeded?.Invoke(totalCalories);
                }

                Console.WriteLine("--------------------------------\n" +
                    "Instructions:\n" +
                    "--------------------------------\n");

                // Prompt the user to enter the number of steps involved in this recipe
                Console.WriteLine("\nPlease enter the number of steps involved in this recipe:");
                int numsteps = int.Parse(Console.ReadLine());

                steps = new string[numsteps];

                for (int i = 0; i < numsteps; i++)
                {
                    Console.WriteLine($"\nEnter step {i + 1} and a description:");
                    steps[i] = Console.ReadLine();
                }

            }
           catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        internal class Program
        {
            private static List<Recipe> recipes = new List<Recipe>();

            private static void Main()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("---------------------------------------------------" +
                    "\nWelcome to Recipe World, your house to tasty foods!\n" +
                    "---------------------------------------------------\n");

                while (true)
                {
                    Console.WriteLine("------------------\nSelect an option:\n------------------" +
                        "\n1. Add Recipe" +
                        "\n2. Display All Recipes" +
                        "\n3. Scale recipe" +
                        "\n4. Clear Recipes" +
                        "\n5. Exit");

                    Console.ResetColor();

                    string select = Console.ReadLine();

                    switch (select)
                    {
                        case "1":
                            AddRecipe();
                            break;
                        case "2":
                            DisplayAllRecipes();
                            break;
                        case "3":
                        //    ScaleRecipe();
                        //    break;
                        //case "4":
                        //    ClearRecipe();
                        //    break;
                        case "5":

                            Console.WriteLine("\nThank you for using Recipe World. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }

            private static void AddRecipe()
            {
                Recipe recipe = new Recipe();
                recipe.OnCalorieExceeded += CalorieExceededNotification;
                recipe.AddRecipe();
                recipes.Add(recipe);
            }

            private static void DisplayAllRecipes()
            {
                if (recipes.Count == 0)
                {
                    Console.WriteLine("\nNo recipes available to display.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("--------\nAll Recipes:\n--------");

                    // Sort the recipes list in alphabetical order by recipe name
                    List<Recipe> sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();

                    for (int i = 0; i < sortedRecipes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {sortedRecipes[i].RecipeName}");
                    }

                    Console.WriteLine("\nEnter the number of your favorite recipe dish you want to view (or '0' to go back):");
                    int recipeNumber;
                    bool validInput = int.TryParse(Console.ReadLine(), out recipeNumber);

                    if (validInput && recipeNumber >= 1 && recipeNumber <= sortedRecipes.Count)
                    {
                        Console.WriteLine();
                        sortedRecipes[recipeNumber - 1].DisplayRecipe();
                    }
                    else if (recipeNumber == 0)
                    {
                        return; // Go back to the main menu
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid recipe number.");
                        Console.ResetColor();
                    }
                }
            }

            public static void CalorieExceededNotification(int totalCalories)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"This recipe has {totalCalories} calories which is a high intake, exceeding the recommended limit.");

                Console.ResetColor();
            }
        }
    }
}
