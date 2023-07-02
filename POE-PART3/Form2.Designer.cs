namespace POE_PART3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 328);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Add Recipe Name:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 325);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 1;
            //textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(67, 402);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 4;
            button1.Text = "Add Ingredients";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(721, 248);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(229, 402);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 469);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}