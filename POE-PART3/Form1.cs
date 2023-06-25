using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POE_PART3
{
    public partial class Form1 : Form
    {
        public delegate void CalorieNotification(int totalCalories);

        public event CalorieNotification OnCalorieExceeded;

        public List<Arrays> recipes = new List<Arrays>(); //calling arraylist class 

        public Form1()
        {
            InitializeComponent();
            recipes = new List<Arrays>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            Form3 form3 = new Form3();
            form3.OnCalorieExceeded += HandleCalorieExceeded; // Subscribe to the event
            form3.ShowDialog(this);

        }

        private void HandleCalorieExceeded(int totalCalories)
        {
            // Handle the event here
            MessageBox.Show($"Calorie limit exceeded: {totalCalories} calories", "Calorie Exceeded");
        }

        
   

    private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to clear all recipe data";
            string title = "Clear Recipe Data";
            //MessageBox.Show(message, title);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                MessageBox.Show("all data have been cleaered");
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            //if user enters 0 or if no recipes is entered, application will display no recipes
            if (recipes.Count == 0)
            {
                MessageBox.Show("\nNo recipes available to display.");
            }
            else
            {
                MessageBox.Show("**************\n*All Recipes:*\n**************");

                // Sorting the recipes list in alphabetical order by recipe name
                List<Arrays> sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();

                string recipeList = "";
                for (int i = 0; i < sortedRecipes.Count; i++)
                {
                    recipeList += $"{i + 1}. {sortedRecipes[i].RecipeName}\n";
                }

                MessageBox.Show(recipeList, "Recipe List");

                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of your favorite recipe dish you want to view (or '0' to go back):");

                if (int.TryParse(userInput, out int recipeNumber))
                {
                    if (recipeNumber >= 1 && recipeNumber <= sortedRecipes.Count)
                    {
                        Arrays selectedRecipe = sortedRecipes[recipeNumber - 1];
                        string recipeDetails = GetRecipeDetails(selectedRecipe);
                        MessageBox.Show(recipeDetails, selectedRecipe.RecipeName);
                    }
                    else if (recipeNumber == 0)
                    {
                        return; // Go back to the main menu
                    }
                    else
                    {
                        MessageBox.Show("\nInvalid recipe number.");
                    }
                }
                else
                {
                    MessageBox.Show("\nInvalid input.");
                }
            }
        }

        private string GetRecipeDetails(Arrays recipe)
        {
            string details = $"Recipe Ingredients:\n{string.Join(", ", recipe.ingredients)}\n\n";
            details += $"Food Group: {string.Join(", ", recipe.foodgroup)}\n";
            details += $"Quantity: {string.Join(", ", recipe.quantity)} {string.Join(", ", recipe.units)}\n";
            details += $"Calories: {string.Join(", ", recipe.calories)}\n";
            details += $"Steps: {string.Join(", ", recipe.steps)}";
            return details;
        }
    }
}