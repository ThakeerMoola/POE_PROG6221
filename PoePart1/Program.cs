

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

            recipe.recipe(); //calling the recipe class
            recipe.IngredientDetails(); // calling the ingredient class
        }
    }
}

