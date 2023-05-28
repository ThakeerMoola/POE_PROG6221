
using System;
using PoePart2;
using System.Collections.Generic;

namespace PoePart2
{
    internal class Program
    {
        private static List<Recipe> recipes = new List<Recipe>();

        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("****************************************************" +
                "*\n*Welcome to Recipe World, your house to tasty foods!*\n*" +
                "****************************************************\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("-----------------\nSelect an option:\n-----------------" +
                     "\n1) Add Recipe" +
                     "\n2) Display All Recipes" +
                     "\n3) Clear Recipes" +
                     "\n4) Exit");

                string select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                        Recipe recipe = new Recipe();

                        // Subscribe to the event
                        recipe.OnCalorieExceeded += Calories.CalorieExceededNotification;

                        recipe.AddRecipe(recipes);
                        break;

                    case "2":
                        DisplayAllRecipes();
                        break;

                    case "3":
                        Recipe.ClearRecipes(recipes);
                        break;

                    case "4":
                        Console.WriteLine("Goodbye, thanks for using recipe world");
                        return; // Exit the program by returning from the Main method

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        
                        Console.ResetColor();
                        break;
   
                }

                Console.WriteLine();
            }
        }

        // Display all recipes
        private static void DisplayAllRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                Console.WriteLine("\nNo recipes available to display.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**************\n*All Recipes:*\n**************");

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
    }
}