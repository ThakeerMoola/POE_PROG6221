using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1
{
    internal class Recipe
    {

        //class repice created, this displays the welcome message for the recipe application
        public void recipe()
        {

            Console.WriteLine("---------------------------------------------------" +
                "\nWelcome to Recipe World, your house to tasty foods!\n" +
                "---------------------------------------------------\n");

        }

        //this method prompts the user for ingredient details and prints the ingredient list and instructions
        public void IngredientDetails()
        {
            //prompts the user to enter the number of ingredients needed
            Console.WriteLine("\nPlease enter the number of ingredients for your special dish: ");


            //parsing an integer through the readline statement, user only allowed to enter a number, or else error!
            int amount = int.Parse(Console.ReadLine());




            //arrays to ingredients, units and quantites needed 
            string[] ingredients = new string[amount];
            string[] units = new string[amount];
            double[] quantity = new double[amount];

            // Loop through the number of ingredients and prompt the user to enter each ingredient's details
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"\nEnter ingredient {i + 1} name:");
                ingredients[i] = Console.ReadLine();

                Console.WriteLine($"\nEnter quantity for {ingredients[i]}:");
                quantity[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nEnter units of measurement for {ingredients[i]}:");
                units[i] = Console.ReadLine();
            }



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


            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($" {ingredients[i]} - {quantity[i]}{units[i]}\n");

            }


            Console.WriteLine("--------------------------------\n" +
            "Instructions:\n" +
            "--------------------------------\n");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($" Step {i + 1}: {steps[i]}\n");

            }



            Console.WriteLine("Enter your required scaling factor for the recipe (0.5, 2, 3) or '4' to clear recipe or '5' to reset quantites and 6 to exit application:");

            string input = Console.ReadLine();

            if (input == "4")
            {
                for (int i = 0; i < amount; i++)
                {
                    ingredients[i] = default;
                    quantity[i] = default;
                    units[i] = default;
                }
                for (int i = 0; i < numsteps; i++)
                {
                    steps[i] = default;

                    Console.WriteLine($" {ingredients[i]} - {quantity[i]} {units[i]}\n");



                }
                IngredientDetails();


            }
            else if (input == "5")
            {
                for (int i = 0; i < quantity.Length; i++)
                {
                    quantity[i] /= 2;

                    Console.WriteLine($" {ingredients[i]} - {quantity[i]} {units[i]}\n");
                }




            }
            else if (input == "6")
            {

                System.Environment.Exit(-1);
                Console.ReadKey();

            }


            else
            {
                double scalingfactor = double.Parse(input);

                Console.WriteLine("--------------------------------\n" +
         "Scaled Recipe:\n" +
         "--------------------------------\n");

                for (int i = 0; i < amount; i++)
                {
                    quantity[i] *= scalingfactor;



                    Console.WriteLine($" {ingredients[i]} - {quantity[i]}{units[i]}\n");
                }
            }
        }
    }
}











