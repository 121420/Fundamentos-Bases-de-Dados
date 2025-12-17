namespace NBA
{
    partial class FormTreinadores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLicensa = new System.Windows.Forms.ComboBox();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.btmInserir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.Label();
            this.txtIdTreinador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaTreiadores = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnosExperiencia = new System.Windows.Forms.TextBox();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTreiadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 54);
            this.panel1.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipas";
            // 
            // cmbLicensa
            // 
            this.cmbLicensa.FormattingEnabled = true;
            this.cmbLicensa.Location = new System.Drawing.Point(180, 325);
            this.cmbLicensa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLicensa.Name = "cmbLicensa";
            this.cmbLicensa.Size = new System.Drawing.Size(116, 21);
            this.cmbLicensa.TabIndex = 110;
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtualizar.Location = new System.Drawing.Point(273, 375);
            this.btmAtualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(80, 27);
            this.btmAtualizar.TabIndex = 107;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            this.btmAtualizar.Click += new System.EventHandler(this.btmAtualizar_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.Location = new System.Drawing.Point(372, 375);
            this.btmEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(80, 27);
            this.btmEliminar.TabIndex = 106;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(458, 375);
            this.Limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(80, 27);
            this.Limpar.TabIndex = 105;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // btmInserir
            // 
            this.btmInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserir.Location = new System.Drawing.Point(177, 375);
            this.btmInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmInserir.Name = "btmInserir";
            this.btmInserir.Size = new System.Drawing.Size(80, 27);
            this.btmInserir.TabIndex = 104;
            this.btmInserir.Text = "Inserir";
            this.btmInserir.UseVisualStyleBackColor = true;
            this.btmInserir.Click += new System.EventHandler(this.btmInserir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 103;
            this.label6.Text = "Licensa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 102;
            this.label5.Text = "Especialidade";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(176, 249);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(122, 18);
            this.txt.TabIndex = 101;
            this.txt.Text = "Anos Experiencia";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(177, 162);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(116, 20);
            this.txtNome.TabIndex = 100;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa.Location = new System.Drawing.Point(305, 191);
            this.aa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(30, 18);
            this.aa.TabIndex = 99;
            this.aa.Text = "CC";
            // 
            // txtIdTreinador
            // 
            this.txtIdTreinador.Location = new System.Drawing.Point(180, 214);
            this.txtIdTreinador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdTreinador.Name = "txtIdTreinador";
            this.txtIdTreinador.Size = new System.Drawing.Size(116, 20);
            this.txtIdTreinador.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 97;
            this.label2.Text = "ID Treinador";
            // 
            // ListaTreiadores
            // 
            this.ListaTreiadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaTreiadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaTreiadores.Location = new System.Drawing.Point(633, 154);
            this.ListaTreiadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaTreiadores.Name = "ListaTreiadores";
            this.ListaTreiadores.RowTemplate.Height = 24;
            this.ListaTreiadores.Size = new System.Drawing.Size(611, 280);
            this.ListaTreiadores.TabIndex = 112;
            this.ListaTreiadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaTreiadores_CellContentClick);
            this.ListaTreiadores.SelectionChanged += new System.EventHandler(this.ListaTreiadores_SelectionChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(633, 123);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(612, 20);
            this.txtPesquisa.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(632, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 113;
            this.label11.Text = "Pesquisa";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(308, 214);
            this.txtCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(116, 20);
            this.txtCC.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 116;
            this.label3.Text = "Nome";
            // 
            // txtAnosExperiencia
            // 
            this.txtAnosExperiencia.Location = new System.Drawing.Point(178, 265);
            this.txtAnosExperiencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnosExperiencia.Name = "txtAnosExperiencia";
            this.txtAnosExperiencia.Size = new System.Drawing.Size(116, 20);
            this.txtAnosExperiencia.TabIndex = 117;
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(308, 265);
            this.txtEspecialidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(116, 20);
            this.txtEspecialidade.TabIndex = 118;
            // 
            // FormTreinadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 541);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.txtAnosExperiencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ListaTreiadores);
            this.Controls.Add(this.cmbLicensa);
            this.Controls.Add(this.btmAtualizar);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.btmInserir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.txtIdTreinador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTreinadores";
            this.Text = "FormTreinadores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTreiadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLicensa;
        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button btmInserir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.TextBox txtIdTreinador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ListaTreiadores;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnosExperiencia;
        private System.Windows.Forms.TextBox txtEspecialidade;
    }
}