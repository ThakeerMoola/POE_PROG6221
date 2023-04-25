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
                Console.WriteLine($" {ingredients[i]} - {quantity[i]} {units[i]}\n");

            }


            Console.WriteLine("--------------------------------\n" +
            "Instructions:\n" +
            "--------------------------------\n");

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($" Step {i + 1}. {steps[i]}\n");

            }




            Console.WriteLine("Enter scaling factor (0.5, 2, or 3)\n" +
            " '4' to reset quantities\n '5' to clear recipe:");

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
                getIngredients();

            }
            else if (input == "5")
            {
                for (int i = 0; i < amount; i++)
                {
                    quantity[i] /= 2;

                    Console.WriteLine($" {ingredients[i]} - {quantity[i]} {units[i]}\n");

                }
                getIngredients();

            }
            else if (input == "6")
            {
               
                System.Environment.Exit(0);
                Console.ReadKey();

            }
        

                else
                {
                    double scalingfactor = double.Parse(input);
                    for (int i = 0; i < amount; i++)
                    {
                        quantity[i] *= scalingfactor;

                        Console.WriteLine($" {ingredients[i]} - {quantity[i]}{units[i]}\n");

                    }
                    getIngredients();
                }
            }
        }
    }











