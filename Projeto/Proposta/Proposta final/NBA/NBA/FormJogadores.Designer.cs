namespace NBA
{
    partial class FormJogadores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCamisola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listajogadores = new System.Windows.Forms.DataGridView();
            this.cmbID_Equipa = new System.Windows.Forms.ComboBox();
            this.cmbMaoDominante = new System.Windows.Forms.ComboBox();
            this.cmbPosicao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.btmInserir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listajogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogadores";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1919, 67);
            this.panel1.TabIndex = 1;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(407, 138);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(136, 22);
            this.txtCC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "CC:";
            // 
            // txtNomeCamisola
            // 
            this.txtNomeCamisola.Location = new System.Drawing.Point(250, 206);
            this.txtNomeCamisola.Name = "txtNomeCamisola";
            this.txtNomeCamisola.Size = new System.Drawing.Size(461, 22);
            this.txtNomeCamisola.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome Camisola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posição:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(407, 273);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(136, 22);
            this.txtAltura.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(570, 273);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(141, 22);
            this.txtPeso.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(250, 346);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(136, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mao Dominante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(566, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID Equipa";
            // 
            // listajogadores
            // 
            this.listajogadores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listajogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listajogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listajogadores.Location = new System.Drawing.Point(742, 179);
            this.listajogadores.Name = "listajogadores";
            this.listajogadores.RowHeadersWidth = 51;
            this.listajogadores.RowTemplate.Height = 24;
            this.listajogadores.Size = new System.Drawing.Size(922, 361);
            this.listajogadores.TabIndex = 20;
            this.listajogadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listajogadores_CellContentClick);
            this.listajogadores.SelectionChanged += new System.EventHandler(this.listajogadores_SelectionChanged);
            // 
            // cmbID_Equipa
            // 
            this.cmbID_Equipa.FormattingEnabled = true;
            this.cmbID_Equipa.Location = new System.Drawing.Point(570, 135);
            this.cmbID_Equipa.Name = "cmbID_Equipa";
            this.cmbID_Equipa.Size = new System.Drawing.Size(121, 24);
            this.cmbID_Equipa.TabIndex = 21;
            // 
            // cmbMaoDominante
            // 
            this.cmbMaoDominante.FormattingEnabled = true;
            this.cmbMaoDominante.Location = new System.Drawing.Point(407, 346);
            this.cmbMaoDominante.Name = "cmbMaoDominante";
            this.cmbMaoDominante.Size = new System.Drawing.Size(121, 24);
            this.cmbMaoDominante.TabIndex = 22;
            this.cmbMaoDominante.SelectedIndexChanged += new System.EventHandler(this.cmbMaoDominante_SelectedIndexChanged);
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(250, 273);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 24);
            this.cmbPosicao.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(250, 138);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(742, 143);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(736, 22);
            this.txtPesquisa.TabIndex = 64;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(739, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Pesquisa";
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtualizar.Location = new System.Drawing.Point(377, 399);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(107, 33);
            this.btmAtualizar.TabIndex = 62;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            this.btmAtualizar.Click += new System.EventHandler(this.btmAtualizar_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.Location = new System.Drawing.Point(510, 399);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(107, 33);
            this.btmEliminar.TabIndex = 61;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(623, 399);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(107, 33);
            this.Limpar.TabIndex = 60;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // btmInserir
            // 
            this.btmInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserir.Location = new System.Drawing.Point(249, 399);
            this.btmInserir.Name = "btmInserir";
            this.btmInserir.Size = new System.Drawing.Size(107, 33);
            this.btmInserir.TabIndex = 59;
            this.btmInserir.Text = "Inserir";
            this.btmInserir.UseVisualStyleBackColor = true;
            this.btmInserir.Click += new System.EventHandler(this.btmInserir_Click);
            // 
            // FormJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 550);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btmAtualizar);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.btmInserir);
            this.Controls.Add(this.cmbPosicao);
            this.Controls.Add(this.cmbMaoDominante);
            this.Controls.Add(this.cmbID_Equipa);
            this.Controls.Add(this.listajogadores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeCamisola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormJogadores";
            this.Text = "FormJogadores";
            this.Load += new System.EventHandler(this.FormJogadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listajogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCamisola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView listajogadores;
        private System.Windows.Forms.ComboBox cmbID_Equipa;
        private System.Windows.Forms.ComboBox cmbMaoDominante;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button btmInserir;
    }
}