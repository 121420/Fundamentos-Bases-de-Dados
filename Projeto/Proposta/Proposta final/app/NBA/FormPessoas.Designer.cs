namespace NBA
{
    partial class FormPessoas
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaPessoas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btmInserir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.listaPessoas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pessoas";
            // 
            // listaPessoas
            // 
            this.listaPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listaPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaPessoas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listaPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPessoas.Location = new System.Drawing.Point(58, 139);
            this.listaPessoas.Margin = new System.Windows.Forms.Padding(2);
            this.listaPessoas.Name = "listaPessoas";
            this.listaPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.listaPessoas.RowTemplate.Height = 24;
            this.listaPessoas.Size = new System.Drawing.Size(675, 293);
            this.listaPessoas.TabIndex = 44;
            this.listaPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaPessoas_CellContentClick);
            this.listaPessoas.SelectionChanged += new System.EventHandler(this.listaPessoas_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 54);
            this.panel1.TabIndex = 28;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(61, 93);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(50, 13);
            this.lblPesquisa.TabIndex = 57;
            this.lblPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(63, 110);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(553, 20);
            this.txtPesquisa.TabIndex = 58;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCC);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 512);
            this.panel2.TabIndex = 59;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(187, 117);
            this.txtCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(112, 20);
            this.txtCC.TabIndex = 32;
            this.txtCC.TextChanged += new System.EventHandler(this.txtCC_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtPesquisa);
            this.panel4.Controls.Add(this.listaPessoas);
            this.panel4.Controls.Add(this.lblPesquisa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(653, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 512);
            this.panel4.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "CC:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cmbGenero);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.mskData);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTelefone);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btmAtualizar);
            this.panel3.Controls.Add(this.txtNacionalidade);
            this.panel3.Controls.Add(this.btmEliminar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.Limpar);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btmInserir);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 512);
            this.panel3.TabIndex = 33;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(428, 228);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(107, 21);
            this.cmbGenero.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nome:";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(188, 228);
            this.mskData.Margin = new System.Windows.Forms.Padding(2);
            this.mskData.Mask = "0000/00/00";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(112, 20);
            this.mskData.TabIndex = 56;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(188, 173);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 20);
            this.txtNome.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data Nascimento";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(428, 287);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(107, 20);
            this.txtTelefone.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nacionalidade";
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtualizar.Location = new System.Drawing.Point(284, 330);
            this.btmAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(80, 27);
            this.btmAtualizar.TabIndex = 51;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            this.btmAtualizar.Click += new System.EventHandler(this.btmAtualizar_Click);
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(314, 228);
            this.txtNacionalidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(103, 20);
            this.txtNacionalidade.TabIndex = 37;
            // 
            // btmEliminar
            // 
            this.btmEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.Location = new System.Drawing.Point(382, 330);
            this.btmEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(80, 27);
            this.btmEliminar.TabIndex = 50;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(423, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Genero:";
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(467, 330);
            this.Limpar.Margin = new System.Windows.Forms.Padding(2);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(80, 27);
            this.Limpar.TabIndex = 49;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Email:";
            // 
            // btmInserir
            // 
            this.btmInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserir.Location = new System.Drawing.Point(188, 330);
            this.btmInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btmInserir.Name = "btmInserir";
            this.btmInserir.Size = new System.Drawing.Size(80, 27);
            this.btmInserir.TabIndex = 48;
            this.btmInserir.Text = "Inserir";
            this.btmInserir.UseVisualStyleBackColor = true;
            this.btmInserir.Click += new System.EventHandler(this.btmInserir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(423, 265);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Telefone";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 287);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // FormPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPessoas";
            this.Text = "FormPessoas";
            this.Load += new System.EventHandler(this.FormPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPessoas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaPessoas;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btmInserir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
    }
}