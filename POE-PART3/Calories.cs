using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART3
{
    internal class Calories
    {
        // Event handler method for calorie notification
        public static void CalorieExceededNotification(int totalCalories)
        {

            MessageBox.Show($"This recipe has {totalCalories} calories which is a high intake, exceeding the recommended limit.");

            
        }
    }
}
