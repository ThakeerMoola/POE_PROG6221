using System;
using System.Collections.Generic;
using System.Linq;

namespace PoePart2
{
    public class Recipe
    {
        // delegate for the calorie notification
        public delegate void CalorieNotification(int totalCalories);

        //event based on the delegate
        public event CalorieNotification OnCalorieExceeded;

        public string RecipeName { get; set; }
        //Array list <T> used for saving data
        private List<string> ingredients;
        private List<string> units;
        private List<double> quantity;
        private List<int> calories;
        private List<string> foodgroup;
        private string[] steps;
        //list for available food groups
        private static List<string> availableFoodGroups = new List<string>
        {
            "Starchy foods",
            "Vegetables and fruits",
            "Dry beans, peas, lentils and soya",
            "Chicken, fish, meat and eggs",
            "Milk and dairy products",
            "Fats and oil",
            "Water"
        };


        //changing List to private making it accessible 
        public Recipe()
        {
            ingredients = new List<string>();
            units = new List<string>();
            quantity = new List<double>();
            calories = new List<int>();
            foodgroup = new List<string>();
        }

        // Displaying method for recipe 
        public void DisplayRecipe()
        {
            //calories calculator & totalling amounts
            int totalCalories = calories.Sum();

            
            Console.WriteLine("-------------------------------\n" +
                $"Recipe Ingredients for {RecipeName}:\n" +
                "-------------------------------\n");

            //for loop for ingredients 
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"\n{ingredients[i]} - {quantity[i]} {units[i]}\n {calories[i]} Cals \n Food groups: {foodgroup[i]}");
            }

            //displaying the total calories to the user 
            Console.WriteLine($"\nTotal Calories: {totalCalories}");

            //if statement for total calories, if entered amount the following will display
            if (totalCalories < 100)
            {
                //if value is less than 100 display the following
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Low-calorie intake, this recipe is perfect for people on a diet");
                Console.ResetColor();

            }
            else if (totalCalories > 100 && totalCalories <= 300)
            {
                //if vsalue is less equal to, display the following
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Medium-calorie intake, this recipe is suitable for most people");
                Console.ResetColor();
            }
            else
            {
                // If the total calories exceed 300, raise the event to notify the user
                OnCalorieExceeded?.Invoke(totalCalories);
            }
            Console.ForegroundColor= ConsoleColor.Green;    
            Console.WriteLine("-------------------------------\n" +
                             $"Instructions steps for {RecipeName}:\n" +
                             "-------------------------------\n");
            //displaying the steps instruction
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {steps[i]}");
                Console.ResetColor();
            }
        }

        // Method to add a recipe
        public void AddRecipe(List<Recipe> recipes)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //try and catch exception for handling
            try
            {
                Console.WriteLine("Please enter the name of the recipe");
                RecipeName = Console.ReadLine(); //prompting for input from user

                Console.WriteLine("\nPlease enter the number of ingredients for your special dish:");
                int amount = int.Parse(Console.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine($"\nEnter ingredient {i + 1} for {RecipeName}:");
                    ingredients.Add(Console.ReadLine());

                    Console.WriteLine($"\nEnter calories for {ingredients[i]} for {RecipeName}:");
                    calories.Add(int.Parse(Console.ReadLine()));
                    Console.ResetColor();

                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Console.WriteLine("Select the food group from the list:\n");
                    DisplayAvailableFoodGroups();
                    Console.WriteLine($"\nSelect the Food Group for {ingredients[i]} for {RecipeName}:");

                    Console.ResetColor();
                    int foodGroupIndex;
                    //foodgroup if statement, running through the index
                    if (int.TryParse(Console.ReadLine(), out foodGroupIndex) && foodGroupIndex >= 1 && foodGroupIndex <= availableFoodGroups.Count)
                    {
                        foodgroup.Add(availableFoodGroups[foodGroupIndex - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid food group selection. Food group not added.");
                    }

                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine($"\nEnter quantity for {ingredients[i]} for {RecipeName}:");
                    quantity.Add(double.Parse(Console.ReadLine()));

                    Console.WriteLine($"\nEnter unit for {ingredients[i]} for {RecipeName}:");
                    units.Add(Console.ReadLine());
                }

                Console.WriteLine("\nPlease enter the number of steps involved in this recipe:");
                int numsteps = int.Parse(Console.ReadLine());

                steps = new string[numsteps];

                for (int i = 0; i < numsteps; i++)
                {
                    Console.WriteLine($"\nEnter step {i + 1} and a description:");
                    steps[i] = Console.ReadLine();
                    Console.ResetColor();
                }

                Console.WriteLine($"\n{RecipeName} recipe has been added successfully!\n");
                

                recipes.Add(this);
            }
            //catch exception if inncorrect value is added in
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }

            Console.ResetColor();
        }

        // Clear all recipes
        public static void ClearRecipes(List<Recipe> recipes)
        {
            recipes.Clear();
            Console.WriteLine("\nAll recipes have been cleared.");
        }

        // Display available food groups
        public void DisplayAvailableFoodGroups()
        {
            for (int i = 0; i < availableFoodGroups.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {availableFoodGroups[i]}");
            }
        }
    }
}
