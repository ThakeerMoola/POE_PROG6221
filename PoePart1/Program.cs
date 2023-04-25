

using PoePart1;
using System;

namespace RecipeApplication
{
    class Program
    {
        //main method called
            static void Main(string[] args)
            {
            //an instsance of the recipe class is created 
                Recipe recipe = new Recipe(); // create an instance of Recipe class

            recipe.recipe();
            recipe.getIngredients();
            recipe.getsteps();
            recipe.Display();

            Console.WriteLine("\n\nRecipe menu:");
            recipe.RecipeMenu();


        }
    }
    }
