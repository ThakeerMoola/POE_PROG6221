

using PoePart1;
using System;
using System.Numerics;

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
            


            //  recipe.ScaleRecipe();



            Console.WriteLine("\n\nRecipe menu:");
           // recipe.RecipeMenu();


        }
    }
    }
