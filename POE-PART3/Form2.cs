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

    public partial class Form2 : Form
    {
        public static List<Arrays> recipes = new List<Arrays>(); //calling arraylist class 
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Arrays recipe = new Arrays();



            recipe.recipename.Add(textBox1.Text);
            int amount;

            if (int.TryParse(textBox2.Text, out amount))
            {

                for (int i = 0; i < amount; i++)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    // Your loop code goes here
                }
            }
            else
            {
                MessageBox.Show("Invalid input for amount.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
