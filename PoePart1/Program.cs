

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
                recipe.recipeDisplay(); // call recipeDisplay method


            }
        }
    }











//// to call methods from a class eg class recipe, 
















////        Console.WriteLine("Recipe added successfully!");
////        Console.WriteLine("Recipe name: " + name);
////        Console.WriteLine("Ingredients:");

////        for (int i = 0; i < amount; i++)
////        {
////            Console.WriteLine("- " + ingredients[i]);
////        }

////        Console.ReadLine();


////        Console.WriteLine("the number of steps involved");
////        int steps = int.Parse(Console.ReadLine());

////        String[] step = new String[steps];
////        for (int s = 0; s < steps; s++)
////        {
////            Console.WriteLine("step " + (s + 1) + "with a description"+ " :");
////            step[s] = Console.ReadLine();
////        }
////        Console.WriteLine("steps added successfully! " );

////        for (int s = 0; s < steps; s++)
////        {
////            Console.WriteLine("- " + step[s]);
////        }

////        Console.ReadLine();


////    }
////}



////        Console.WriteLine("for each of the steps, provide us with a description of what the user should do");
////        String description = Console.ReadLine();

////        Console.WriteLine("the number of ingredients used for this special dish are as follows\n" +
////            "--------------------------------------------------------\n");
////        Console.WriteLine("number of ingredients : " +amount);
////        Console.WriteLine("ingredients used for this dish : " +name);

////        Console.WriteLine("units of measurements for the ingrediant : " + units);
////        Console.WriteLine("steps involved :" + steps);
////        Console.WriteLine("description on how to make the special dish : " + description);

////    }
////}

//// call im main class from child class
////recipe obj = new recipe();
////obj.display();
////obj.scalling;