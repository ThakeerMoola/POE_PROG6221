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
            try
            {
                if (recipes.Count == 0)
                {
                    MessageBox.Show("\nNo recipes available to display.");
                }
                else
                {
                    StringBuilder recipeList = new StringBuilder();
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

                    string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the number of your favorite recipe dish you want to view (or '0' to go back):");

                    if (int.TryParse(userInput, out int recipeNumber))
                    {
                        if (recipeNumber >= 1 && recipeNumber <= sortedRecipes.Count)
                        {
                            Arrays selectedRecipe = sortedRecipes[recipeNumber - 1];
                            string recipeDetails = GetRecipeDetails(selectedRecipe);

                            MessageBox.Show(recipeDetails, string.Join(", ", selectedRecipe.recipename[0]));

                            // Calorie Counter
                            double totalCalories = 0.0;

                            for (int i = 0; i < selectedRecipe.calories.Count; i++)
                            {
                                int ingredientCalories = selectedRecipe.calories[i];
                                totalCalories += ingredientCalories;
                            }

                            string calorieMessage;
                            if (totalCalories > 100)
                            {
                                calorieMessage = $"Low-calorie intake, this recipe is perfect for people on a diet, {totalCalories} calories.";
                            }
                            else if (totalCalories > 100 && totalCalories <= 300)
                            {
                                calorieMessage = $"Medium-calorie intake, this recipe is suitable for most people. {totalCalories} calories.";
                            }
                            else
                            {
                                calorieMessage = $"High calorie intake, Not suitable on a daily, {totalCalories} calories.";
                            }

                            MessageBox.Show(calorieMessage, "Calorie Intake");
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

