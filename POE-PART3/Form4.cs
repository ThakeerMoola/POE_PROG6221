using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_PART3
{
    public partial class Form4 : Form
    {
        public delegate void CalorieNotification(int totalCalories);

        public event CalorieNotification OnCalorieExceeded;

        public List<Arrays> recipes = new List<Arrays>();

        public Form4(List<Arrays> recipeData)
        {
            InitializeComponent();
            recipes = recipeData;

        }

        public Form4()
        {
            InitializeComponent();
        }
        private void FilterRecipes()
        {
            string ingredient = textBox1.Text.Trim();
            string foodGroup = comboBox1.SelectedItem?.ToString();
            int maxCalories;

            if (!int.TryParse(textBox2.Text.Trim(), out maxCalories))
            {
                MessageBox.Show("Invalid maximum calories value.");
                return;
            }

            List<Arrays> filteredRecipes = new List<Arrays>();

            foreach (Arrays recipe in recipes)
            {
                bool includeRecipe = true;

                if (!string.IsNullOrEmpty(ingredient))
                {
                    if (!recipe.ingredients.Contains(ingredient))
                    {
                        includeRecipe = false;
                    }
                }

                if (!string.IsNullOrEmpty(foodGroup))
                {
                    if (!recipe.foodgroup.Contains(foodGroup))
                    {
                        includeRecipe = false;
                    }
                }

                if (recipe.calories.Any(calorie => calorie > maxCalories))
                {
                    includeRecipe = false;
                }

                if (includeRecipe)
                {
                    filteredRecipes.Add(recipe);
                }
            }

            if (filteredRecipes.Count == 0)
            {
                MessageBox.Show("No recipes match the given criteria.");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("**************");
                listBox1.Items.Add("*Filtered Recipes:*");
                listBox1.Items.Add("**************");

                for (int i = 0; i < filteredRecipes.Count; i++)
                {
                    listBox1.Items.Add($"{i + 1}. {string.Join(", ", filteredRecipes[i].recipename)}");
                }

                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of the recipe you want to view (or '0' to go back):");

                if (int.TryParse(userInput, out int recipeNumber))
                {
                    if (recipeNumber >= 1 && recipeNumber <= filteredRecipes.Count)
                    {
                        Arrays selectedRecipe = filteredRecipes[recipeNumber - 1];
                        string recipeDetails = GetRecipeDetails(selectedRecipe);

                        MessageBox.Show(recipeDetails, string.Join(", ", selectedRecipe.recipename));
                    }
                    else if (recipeNumber == 0)
                    {
                        return; // Go back to the main menu
                    }
                    else
                    {
                        MessageBox.Show("Invalid recipe number.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input.");
                }
            }
        }
        private string GetRecipeDetails(Arrays recipe)
        {
            StringBuilder details = new StringBuilder();
            details.AppendLine("Recipe Details:");
            details.AppendLine($"Recipe Name: {string.Join(", ", recipe.recipename)}");
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
            details.AppendLine("Steps:");
            for (int i = 0; i < recipe.steps.Count; i++)
            {
                details.AppendLine($"{i + 1}. {recipe.steps[i]}");
            }

            return details.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterRecipes();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

