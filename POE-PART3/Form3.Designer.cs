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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(125, 663);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 40;
            button1.Text = "Add Ingredients";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(217, 319);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 322);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 38;
            label4.Text = "Quantity:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 280);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 36;
            label1.Text = "Name Of Ingredients:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Starchy foods", "Vegetables and fruits", "Dry beans, peas, lentils and soya", "Chicken, fish, meat and eggs", "Milk and dairy products", "Fats and oil", "Water" });
            comboBox1.Location = new Point(217, 478);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 28);
            comboBox1.TabIndex = 35;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(217, 530);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(211, 109);
            textBox6.TabIndex = 34;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(217, 422);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 27);
            textBox5.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 533);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 32;
            label8.Text = "Steps Involved:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 478);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 31;
            label7.Text = "food Group:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 425);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 30;
            label6.Text = "Calories:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 370);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 28;
            label5.Text = "Units Of Measurements:";
            // 
            // button2
            // 
            button2.Location = new Point(324, 663);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 41;
            button2.Text = "Display Recipe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(735, 248);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 370);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 43;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(737, 803);
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
            Name = "Form3";
            Text = "Form3";
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
    }
}