namespace Forms1FBD2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Picture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(339, 199);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(230, 199);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(188, 159);
            label1.Name = "label1";
            label1.Size = new Size(293, 20);
            label1.TabIndex = 2;
            label1.Text = "We gonna start that business (just press ok)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(167, 139);
            label2.Name = "label2";
            label2.Size = new Size(293, 20);
            label2.TabIndex = 3;
            label2.Text = "We gonna start that business (just press ok)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(140, 119);
            label3.Name = "label3";
            label3.Size = new Size(293, 20);
            label3.TabIndex = 4;
            label3.Text = "We gonna start that business (just press ok)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Tshirts";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(128, 40);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Hoodies";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(249, 40);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(85, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Trousers";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(368, 40);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(89, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Sneakers";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 27);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 296);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 10;
            label4.Text = "Your comments here: ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(381, 326);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 11;
            label5.Text = "Please, don't be dumb";
            // 
            // Picture
            // 
            Picture.Image = (Image)resources.GetObject("Picture.Image");
            Picture.Location = new Point(12, 376);
            Picture.Name = "Picture";
            Picture.Size = new Size(125, 62);
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Picture.TabIndex = 12;
            Picture.TabStop = false;
            Picture.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Picture);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private PictureBox Picture;
    }
}
