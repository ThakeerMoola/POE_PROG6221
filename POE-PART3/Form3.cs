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
    public partial class Form3 : Form
    {
        public delegate void CalorieNotification(int totalCalories);

        public event CalorieNotification OnCalorieExceeded;

         // Remove the 'static' keyword
        public List<Arrays> recipes = new List<Arrays>();


      

        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arrays recipe = new Arrays();
            recipes.Add(recipe);

            recipe.ingredients.Add(textBox1.Text);
            recipe.units.Add(textBox2.Text);
            recipe.quantity.Add(Convert.ToInt32(textBox3.Text));
            recipe.calories.Add(Convert.ToInt32(textBox5.Text));
            recipe.steps.Add(textBox6.Text);
            recipe.foodgroup.Add(comboBox1.SelectedItem.ToString());

            Form1 form1 = this.Owner as Form1;
            form1.recipes.Add(recipe);
            MessageBox.Show("Ingredients added successfully", "Test Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (recipes.Count > 0)
            {
                Arrays recipe = recipes[0];

                
               

                List<int> calories = recipe.calories;
                int totalCalories = calories.Sum();

                string caption = "Word Processor";

                MessageBox.Show(null,
                    caption + "--------------------------------------------------------------\n" +
                    $"Recipe Ingredients for {string.Join(", ", recipe.recipename)}:\n" +
                    "--------------------------------------------------------------\n" +
                    $"Ingredients: {string.Join(", ", recipe.ingredients)}\n" +
                    $"Food Group: {string.Join(",", recipe.foodgroup)}\n" +
                    $"Quantity: {string.Join(", ", recipe.quantity)} {string.Join(", ", recipe.units)}\n" +
                    $"Calories: {string.Join(", ", recipe.calories)}\n" +
                    $"\nTotal Calories: {totalCalories}\n" +
                    $"Steps: {string.Join(", ", recipe.steps)}",
                    "Recipe Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (totalCalories < 100)
                {
                    MessageBox.Show("Low-calorie intake, this recipe is perfect for people on a diet",
                        "Calorie Intake",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (totalCalories > 100 && totalCalories <= 300)
                {
                    MessageBox.Show("Medium-calorie intake, this recipe is suitable for most people",
                        "Calorie Intake",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // If the total calories exceed 300, raise the event to notify the user
                    OnCalorieExceeded?.Invoke(totalCalories);
                }
            }
            else
            {
                MessageBox.Show("No recipes available.",
                    "Recipe Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            Close();  // Close Form3
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
