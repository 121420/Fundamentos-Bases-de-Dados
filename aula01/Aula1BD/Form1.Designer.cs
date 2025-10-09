namespace Aula1BD
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            btnTest = new Button();
            btnHello = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 80);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(574, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(574, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(574, 27);
            textBox4.TabIndex = 4;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(162, 324);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(266, 91);
            btnTest.TabIndex = 5;
            btnTest.Text = "Test Ligação";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(470, 324);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(266, 91);
            btnHello.TabIndex = 6;
            btnHello.Text = "Hello Table";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 139);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "User";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 189);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 525);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnHello);
            Controls.Add(btnTest);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button btnTest;
        private Button btnHello;
        private Label label2;
        private Label label4;
    }
}
