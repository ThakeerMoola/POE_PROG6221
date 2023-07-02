namespace POE_PART3
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(294, 707);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(251, 33);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 634);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 1;
            label1.Text = "Ingredient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 634);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 2;
            label2.Text = "Calorie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 634);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 3;
            label3.Text = "Food Group:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 628);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 30);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(401, 630);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 30);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Starchy foods", "Vegetables and fruits", "Dry beans, peas, lentils and soya", "Chicken, fish, meat and eggs", "Milk and dairy products", "Fats and oil", "Water" });
            comboBox1.Location = new Point(668, 628);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 31);
            comboBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(58, 316);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(757, 234);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 248);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(349, 271);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 44;
            label4.Text = "FILTER RECIPE";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(946, 759);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}