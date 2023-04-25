using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    internal class Recipe
    {
        private string[] ingredients;
        private string[] units;
        private double[] quantity;
        private string[] steps;
        //class repicedisplay created
        public void recipe()
        {

            Console.WriteLine("---------------------------------------------------" +
                "\nWelcome to Recipe World, your house to tasty foods!\n" +
                "---------------------------------------------------\n");
        }

        public void getIngredients()
        {

            Console.WriteLine("\nPlease enter the number of ingredients for your special dish: ");


            //parsing an integer through the readline statement, user only aloowed to enter a number, or else error!
            int amount = int.Parse(Console.ReadLine());




            //array to save ingredients and loop the amount of ingredients needed
            string[] ingredients = new string[amount];
            string[] units = new string[amount];
            double[] quantity = new double[amount];

            //loop fo the information entered by user 
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"\nEnter ingredient {i + 1} name:");
                ingredients[i] = Console.ReadLine();

                Console.WriteLine($"\nEnter quantity for {ingredients[i]}:");
                quantity[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nEnter units of measurement for {ingredients[i]}:");
                units[i] = Console.ReadLine();
            }
        }

        public void getsteps()
        {

            Console.WriteLine("\nPlease enter the number of steps involved in this recipe:");
            int numsteps = int.Parse(Console.ReadLine());

            string[] steps = new string[numsteps];

            for (int i = 0; i < numsteps; i++)
            {
                Console.WriteLine($"\nEnter step {i + 1} and a description:");
                steps[i] = Console.ReadLine();
            }


            Console.WriteLine("--------------------------------\n" +
                "Ingredients:\n" +
                "--------------------------------\n");
        }


        public void Display()
        {


            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($" {ingredients[i]} - {quantity[i]} {units[i]}\n");

            }

            Console.WriteLine("--------------------------------\n" +
                "Instructions:\n" +
                "--------------------------------\n");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($" Step {i + 1}. {steps[i]}\n");
            }
        }



        public void ClearQuantities()
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] = 0;
            }
            Console.WriteLine("Quantities reset.");
        }

        public void ClearRecipe()
        {
            ingredients = null;
            units = null;
            quantity = null;
            steps = null;
            Console.WriteLine("Recipe cleared.");
        }

        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < quantity.Length; i++)
            {
                quantity[i] *= factor;
            }
            Console.WriteLine($"Recipe scaled by a factor of {factor}.");
        }

        public void RecipeMenu()
        {
            Console.WriteLine("Enter scaling factor (0.5, 2, or 3)\n" +
                    " '4' to reset quantities\n '5' to clear recipe:");

            string input = Console.ReadLine();

            switch (input)
            {
                case "4":
                    ClearQuantities();
                    break;

                case "5":
                    ClearRecipe();
                    break;

                default:
                    double scalingFactor = double.Parse(input);
                    ScaleRecipe(scalingFactor);
                    break;
            }
        }
    }
}




