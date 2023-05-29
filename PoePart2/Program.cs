
using System;
using PoePart2;
using System.Collections.Generic;

namespace PoePart2
{
    internal class Program
    {
        //calling the list <t>
        private static List<Recipe> recipes = new List<Recipe>();

        private static void Main() // main method to run the program
        {
            //color for the texts
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("****************************************************" +
                "*\n*Welcome to Recipe World, your house to tasty foods!*\n*" +
                "****************************************************\n");
            Console.ResetColor();

            while (true)
            {
                //displaying the menu options to user
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("-----------------\nSelect an option:\n-----------------" +
                     "\n1) Add Recipe" +
                     "\n2) Display All Recipes" +
                     "\n3) Clear Recipes" +
                     "\n4) Exit");
                
                //select variable user for switch statement
                string select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                       //calling recipe class
                        Recipe recipe = new Recipe();

                        // Subscribe to the event
                        recipe.OnCalorieExceeded += Calories.CalorieExceededNotification;
                        //recipe method to add new recipe
                        recipe.AddRecipe(recipes);
                        break;

                    case "2":
                        //displaying all recipes to user
                        DisplayAllRecipes();
                        break;

                    case "3":
                        //clearing all recipe data
                        Recipe.ClearRecipes(recipes);
                        break;

                    case "4":
                        Console.WriteLine("Goodbye, thanks for using recipe world");
                        return; // Exit the program by returning from the Main method

                    default:
                        //if user enters value lower than 1 and greater then 4, display this error message
                        Console.WriteLine("Invalid selection. Please try again.\n");

                        //resetting the text colour
                        Console.ResetColor();
                        break;
   
                }

                Console.WriteLine();
            }
        }

        // Display all recipes
        public static void DisplayAllRecipes()
        {
            //if user enters 0 or if no recipes is entered, application will display no recipes
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

                // Sorting the recipes list in alphabetical order by recipe name
                List<Recipe> sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();

                for (int i = 0; i < sortedRecipes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {sortedRecipes[i].RecipeName}");
                }

                Console.WriteLine("\nEnter the number of your favorite recipe dish you want to view (or '0' to go back):");
                int recipeNumber;
                //recipe function 
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