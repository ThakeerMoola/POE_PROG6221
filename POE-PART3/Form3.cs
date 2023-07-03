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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace POE_PART3
{
    //this is the Subdcriber Class
    public partial class Form3 : Form
    {
        public delegate void CalorieNotification(int totalCalories);

        public event CalorieNotification OnCalorieExceeded;

       
        public List<Arrays> recipes = new List<Arrays>(); //calling arraylist




        public Form3()
        {
            InitializeComponent();
        }

        // Event handler for button1 click
        private void button1_Click(object sender, EventArgs e)// this is the publisher class
        {
            try
            {
                if (recipes.Count == 0) // Check if the recipes list is empty
                {
                    Arrays recipe = new Arrays();
                    recipes.Add(recipe);
                }

                Arrays currentRecipe = recipes[0];

                currentRecipe.recipename.Add(textBox7.Text); // Add recipe name to the current recipe
                currentRecipe.ingredients.Add(textBox1.Text); // Add ingredient to the current recipe
                currentRecipe.units.Add(textBox2.Text); // Add unit to the current recipe
                currentRecipe.quantity.Add(Convert.ToInt32(textBox3.Text)); // Add quantity to the current recipe
                currentRecipe.calories.Add(Convert.ToInt32(textBox5.Text)); // Add calories to the current recipe

                int numSteps;
                if (int.TryParse(textBox6.Text, out numSteps) && numSteps > 0) // Parse and validate the number of steps
                {
                    for (int i = 0; i < numSteps; i++)
                    {
                        string step = Microsoft.VisualBasic.Interaction.InputBox($"Enter Step {i + 1} for {textBox1.Text}:");
                        currentRecipe.steps.Add(step); // Add each step to the current recipe
                    }
                }
                else
                {
                    MessageBox.Show("Invalid number of steps.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                currentRecipe.foodgroup.Add(comboBox1.SelectedItem.ToString()); // Add food group to the current recipe
                textBox7.Enabled = false;

                Form1 form1 = this.Owner as Form1;
                form1.recipes.Add(currentRecipe); // Add the current recipe to Form1's recipes list
                MessageBox.Show("Ingredients added successfully", "Test Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for button2 click
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (recipes.Count > 0) // Check if there are any recipes available
                {
                    Arrays recipe = recipes[0]; // Get the first recipe

                    List<int> calories = recipe.calories;
                    int totalCalories = calories.Sum(); // Calculate the total calories of the recipe

                    StringBuilder message = new StringBuilder();

                    message.AppendLine("Recipe Details");
                    message.AppendLine("--------------------------------");
                    message.AppendLine($"Recipe Name: {string.Join(", ", recipe.recipename[0])}");
                    message.AppendLine("--------------------------------");
                    message.AppendLine("Ingredients:");

                    for (int i = 0; i < recipe.ingredients.Count; i++)
                    {
                        double quantity = (double)recipe.quantity[i];
                        string ingredient = recipe.ingredients[i];
                        string foodGroup = recipe.foodgroup[i];

                        string unit = recipe.units[i];
                        int calorie = recipe.calories[i];

                        message.AppendLine($"Ingredient {i + 1}:");
                        message.AppendLine($"  - Name: {ingredient}");
                        message.AppendLine($"  - Food Group: {foodGroup}");
                        message.AppendLine($"  - Quantity: {quantity} {unit}");
                        message.AppendLine($"  - Calories: {calorie}");
                        message.AppendLine("--------------------------------");
                    }

                    message.AppendLine($"Total Calories: {totalCalories}");
                    message.AppendLine("--------------------------------");
                    message.AppendLine("Steps:");
                    message.AppendLine(string.Join(", ", recipe.steps));

                    string caption = "Recipe Details";

                    MessageBox.Show(message.ToString(), caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Rest of the code...
                }
                else
                {
                    MessageBox.Show("No recipes available.", "Recipe Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Close();  // Close Form3
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}