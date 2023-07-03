using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace POE_PART3
{
    //this is the Subdcriber Class

    public partial class Form1 : Form
    {
        public delegate void CalorieNotification(int totalCalories); //notification for the total calories

        public event CalorieNotification OnCalorieExceeded;

        public List<Arrays> recipes = new List<Arrays>(); //calling arraylist class 
        private double calorie;

        public Form1() //form 1
        {
            InitializeComponent();
            recipes = new List<Arrays>();
        }
        //The publisher class 
        private void button1_Click(object sender, EventArgs e) //button action for form 3 to open
        {



            Form3 form3 = new Form3(); //making instance of form 3
            form3.ShowDialog(this); //showinf form 3 


        }

        public void HandleCalorieExceeded(int totalCalories)
        {
            // Handling the event
            MessageBox.Show($"Calorie limit exceeded: {totalCalories} calories", "Calorie Exceeded"); //calorie encounter once exceeded
        }




        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //exits the windows form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (recipes.Count > 0) //if statement and for loop for recipes, looping through it
                {
                    // Clear all recipe data
                    recipes.Clear();

                    MessageBox.Show("Recipe data cleared successfully", "Clear Recipe Data", MessageBoxButtons.OK, MessageBoxIcon.Information); //messagebox to user 
                }
                else
                {
                    MessageBox.Show("No recipes available.", "Recipe Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();  // Close Form3
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //try statement for handling exceptions
            {
                if (recipes.Count == 0) //if statement and for loop for recipes, looping through it
                { 
                    MessageBox.Show("\nNo recipes available to display."); //message to user if no recipe data is available
                }
                else
                {
                    StringBuilder recipeList = new StringBuilder(); //string builder to append data
                    recipeList.AppendLine("**************");
                    recipeList.AppendLine("*All Recipes:*");
                    recipeList.AppendLine("**************");

                    // Sorting the recipes list in alphabetical order by recipe name
                    List<Arrays> sortedRecipes = recipes.OrderBy(r => r.recipename[0]).ToList();

                    for (int i = 0; i < sortedRecipes.Count; i++)
                    {
                        recipeList.AppendLine($"{i + 1}. {string.Join(", ", sortedRecipes[i].recipename[0])}");
                    }

                    MessageBox.Show(recipeList.ToString(), "Recipe List");

                    string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of your favorite recipe dish you want to view (or '0' to go back):"); //prompting user for input

                    if (int.TryParse(userInput, out int recipeNumber))
                    {
                        if (recipeNumber >= 1 && recipeNumber <= sortedRecipes.Count)
                        {
                            Arrays selectedRecipe = sortedRecipes[recipeNumber - 1];
                            string recipeDetails = GetRecipeDetails(selectedRecipe);

                            MessageBox.Show(recipeDetails, string.Join(", ", selectedRecipe.recipename[0]));

                            // Calorie Counter
                            double totalCalories = 0.0;

                            for (int i = 0; i < selectedRecipe.calories.Count; i++)// for loop for the calories
                            {
                                int ingredientCalories = selectedRecipe.calories[i];
                                totalCalories += ingredientCalories;
                            }

                            string calorieMessage; //calorie encounter message to user
                            if (totalCalories > 100) //if statement if under 100
                            {
                                calorieMessage = $"Low-calorie intake, this recipe is perfect for people on a diet, {totalCalories} calories."; //calorie message
                            }
                            else if (totalCalories > 100 && totalCalories <= 300) 
                            {
                                calorieMessage = $"Medium-calorie intake, this recipe is suitable for most people. {totalCalories} calories."; //calorie message
                            }
                            else
                            {
                                calorieMessage = $"High calorie intake, Not suitable on a daily, {totalCalories} calories."; //calorie message
                            }

                            MessageBox.Show(calorieMessage, "Calorie Intake");  //calorie message
                        }
                        else if (recipeNumber == 0)
                        {
                            return; // Go back to the main menu
                        }
                        else
                        {
                            MessageBox.Show("\nInvalid recipe number."); // invalid message for invalid number
                        }
                    }
                    else
                    {
                        MessageBox.Show("\nInvalid input.");
                    }
                }
            }
            catch (Exception ex) //catch statement for handling the try
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            private string GetRecipeDetails(Arrays recipe) //recipe data details
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine("Recipe Details:");
            details.AppendLine($"Recipe Name: {string.Join(", ", recipe.recipename[0])}");
            details.AppendLine();
            details.AppendLine("Recipe Ingredients:");
            for (int i = 0; i < recipe.ingredients.Count; i++)
            {
                string ingredient = recipe.ingredients[i];
                string foodGroup = recipe.foodgroup[i];

                string quantity = recipe.quantity[i].ToString();
                string unit = recipe.units[i];
                string calorie = recipe.calories[i].ToString();

                details.AppendLine($"Ingredient {i + 1}:");
                details.AppendLine($"  - Name: {ingredient}");
                details.AppendLine($"  - Food Group: {foodGroup}");
                details.AppendLine($"  - Quantity: {quantity} {unit}");
                details.AppendLine($"  - Calories: {calorie}");
                details.AppendLine("--------------------------------");
            }

            for (int i = 0; i < recipe.steps.Count; i++)
            {
                details.Append("Steps");
                details.AppendLine($"{i + 1}. {recipe.steps[i]}");
            }

            return details.ToString();
        }
    
       



        private void button5_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(recipes); //showinf form 4
            form4.ShowDialog();
        }
    }
}


