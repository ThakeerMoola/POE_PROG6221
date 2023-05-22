using System;
using System.Collections.Generic;

// Recipe class representing a single recipe
class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}

// Ingredient class representing a single ingredient
class Ingredientm
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public string FoodGroup { get; set; }
}

class Program
{
    static List<Recipe> recipes = new List<Recipe>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Add a recipe");
            Console.WriteLine("2. Display all recipes");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddRecipe();
                    break;
                case "2":
                    DisplayRecipes();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddRecipe()
    {
        Recipe recipe = new Recipe();

        Console.Write("Enter the name of the recipe: ");
        recipe.Name = Console.ReadLine();

        Console.WriteLine("Enter the ingredients (enter 'done' to finish):");
        while (true)
        {
            Console.Write("Ingredient name: ");
            string ingredientName = Console.ReadLine();

            if (ingredientName.ToLower() == "done")
                break;

            Console.Write("Calories: ");
            int calories = int.Parse(Console.ReadLine());

            Console.Write("Food group: ");
            string foodGroup = Console.ReadLine();

            Ingredient ingredient = new Ingredient
            {
                Name = ingredientName,
                Calories = calories,
                FoodGroup = foodGroup
            };

            recipe.Ingredients.Add(ingredient);
        }

        recipes.Add(recipe);

        Console.WriteLine("Recipe added successfully!");
    }

    static void DisplayRecipes()
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes found.");
            return;
        }

        Console.WriteLine("Recipes:");

        // Sort recipes by name
        recipes.Sort((r1, r2) => string.Compare(r1.Name, r2.Name));

        // Display recipe names
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i].Name}");
        }

        Console.Write("Enter the recipe number to display: ");
        int recipeNumber = int.Parse(Console.ReadLine());

        if (recipeNumber >= 1 && recipeNumber <= recipes.Count)
        {
            Recipe recipe = recipes[recipeNumber - 1];

            Console.WriteLine();
            Console.WriteLine($"Recipe: {recipe.Name}");
            Console.WriteLine("Ingredients:");

            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"- {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }
            
            int totalCalories = recipe.Ingredients.Sum(i => i.Calories);
            Console.WriteLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Console.WriteLine("Caution: This recipe exceeds 300 calories!");
            }
        }
        else
        {
            Console.WriteLine("Invalid recipe number.");
        }
    }
}