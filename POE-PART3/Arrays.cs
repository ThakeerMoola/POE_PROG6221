using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART3
{
    public class Arrays
    {
        public string RecipeName { get; set; }
        public List<string> recipename;
        public List<string> ingredients;
        public List<string> units;
        public List<double> quantity;
        public List<int> calories;
        public List<string> foodgroup;
        public List<string> steps;

        public Arrays()
        {
            recipename = new List<string>();    
            ingredients = new List<string>();
            units = new List<string>();
            quantity = new List<double>();
            calories = new List<int>();
            foodgroup = new List<string>();
            steps = new List<string>();
        }
    }
}