using System;
using PoePart2;

namespace PoePart2
{
    internal class Calories
    {
        // Event handler method for calorie notification
        public static void CalorieExceededNotification(int totalCalories)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"This recipe has {totalCalories} calories which is a high intake, exceeding the recommended limit.");

            Console.ResetColor();
        }
    }
}

