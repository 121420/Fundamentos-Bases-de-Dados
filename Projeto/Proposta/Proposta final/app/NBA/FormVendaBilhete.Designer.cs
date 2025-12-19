namespace NBA
{
    partial class FormVendaBilhete
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btmConfirmar = new System.Windows.Forms.Button();
            this.txtIDJogo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblJogo = new System.Windows.Forms.Label();
            this.lblEstadio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "CC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Setor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lugar";
            // 
            // btmConfirmar
            // 
            this.btmConfirmar.Location = new System.Drawing.Point(432, 331);
            this.btmConfirmar.Name = "btmConfirmar";
            this.btmConfirmar.Size = new System.Drawing.Size(223, 23);
            this.btmConfirmar.TabIndex = 11;
            this.btmConfirmar.Text = "Confirmar Venda";
            this.btmConfirmar.UseVisualStyleBackColor = true;
            this.btmConfirmar.Click += new System.EventHandler(this.btmConfirmar_Click);
            // 
            // txtIDJogo
            // 
            this.txtIDJogo.Location = new System.Drawing.Point(432, 147);
            this.txtIDJogo.Name = "txtIDJogo";
            this.txtIDJogo.Size = new System.Drawing.Size(100, 22);
            this.txtIDJogo.TabIndex = 12;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(555, 147);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(100, 22);
            this.txtCC.TabIndex = 13;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(435, 210);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 22);
            this.txtLugar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Jogo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblJogo
            // 
            this.lblJogo.AutoSize = true;
            this.lblJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo.Location = new System.Drawing.Point(49, 142);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(51, 20);
            this.lblJogo.TabIndex = 17;
            this.lblJogo.Text = "label6";
            this.lblJogo.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblEstadio
            // 
            this.lblEstadio.AutoSize = true;
            this.lblEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadio.Location = new System.Drawing.Point(50, 193);
            this.lblEstadio.Name = "lblEstadio";
            this.lblEstadio.Size = new System.Drawing.Size(51, 20);
            this.lblEstadio.TabIndex = 19;
            this.lblEstadio.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Estadio";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(48, 257);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(51, 20);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data Hora";
            // 
            // cmbSetor
            // 
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(555, 208);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(100, 24);
            this.cmbSetor.TabIndex = 23;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(432, 267);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 22);
            this.txtPreco.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Preco";
            // 
            // FormVendaBilhete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSetor);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstadio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblJogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtIDJogo);
            this.Controls.Add(this.btmConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVendaBilhete";
            this.Text = "FormVendaBilhete";
            this.Load += new System.EventHandler(this.FormVendaBilhete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmConfirmar;
        private System.Windows.Forms.TextBox txtIDJogo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.Label lblEstadio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
    }
}