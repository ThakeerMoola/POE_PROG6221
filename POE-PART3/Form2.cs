using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace POE_PART3 { 
 public partial class Form2 : Form
{
    public delegate void CalorieNotification(int totalCalories);

    public event CalorieNotification OnCalorieExceeded;



    public List<Arrays> recipes = new List<Arrays>(); //calling arraylist class 

    public Form2()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {


        //Arrays recipe = new Arrays();
        //recipes.Add(recipe);
        //recipe.recipename.Add(textBox1.Text);

        //    Form1 form1 = this.Owner as Form1;
        //    form1.recipes.Add(recipe);

        //    DialogResult = DialogResult.OK; // Set DialogResult to OK
        //    Close();  // Close Form2

        //    Form3 form3 = new Form3();
        //    form3.ShowDialog(); // Show Form3 as a modal dialog


            
        }
}
}

