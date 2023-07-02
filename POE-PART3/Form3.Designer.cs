namespace POE_PART3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(46, 760);
            button1.Name = "button1";
            button1.Size = new Size(189, 34);
            button1.TabIndex = 40;
            button1.Text = "Add Ingredients";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 434);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(263, 30);
            textBox3.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 437);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 38;
            label4.Text = "Quantity:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 385);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 30);
            textBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 389);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 36;
            label1.Text = "Name Of Ingredients:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Starchy foods", "Vegetables and fruits", "Dry beans, peas, lentils and soya", "Chicken, fish, meat and eggs", "Milk and dairy products", "Fats and oil", "Water" });
            comboBox1.Location = new Point(280, 613);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 31);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(481, 679);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(62, 23);
            textBox6.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(280, 552);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(263, 30);
            textBox5.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 679);
            label8.Name = "label8";
            label8.Size = new Size(228, 23);
            label8.TabIndex = 32;
            label8.Text = "Number Of Steps Involved:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 616);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 31;
            label7.Text = "food Group:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 555);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 30;
            label6.Text = "Calories:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 492);
            label5.Name = "label5";
            label5.Size = new Size(202, 23);
            label5.TabIndex = 28;
            label5.Text = "Units Of Measurements:";
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(293, 760);
            button2.Name = "button2";
            button2.Size = new Size(250, 34);
            button2.TabIndex = 41;
            button2.Text = "Display Current Recipe";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(769, 247);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 492);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 30);
            textBox2.TabIndex = 43;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Window;
            textBox7.Location = new Point(280, 328);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(263, 30);
            textBox7.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 333);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 46;
            label2.Text = "Recipe Name:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(767, 867);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "Form3";
            Text = "Recipe Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox7;
        private Label label2;
    }
}