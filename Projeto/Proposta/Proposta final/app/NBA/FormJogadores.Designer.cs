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
            this.pbFotoJogador = new System.Windows.Forms.PictureBox();
            this.ContratoJogador = new System.Windows.Forms.DataGridView();
            this.Contrato = new System.Windows.Forms.Label();
            this.Estatistica = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listajogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estatistica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1919, 66);
            this.panel1.TabIndex = 1;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(404, 343);
            this.txtCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(136, 22);
            this.txtCC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CC:";
            // 
            // txtNomeCamisola
            // 
            this.txtNomeCamisola.Location = new System.Drawing.Point(248, 342);
            this.txtNomeCamisola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCamisola.Name = "txtNomeCamisola";
            this.txtNomeCamisola.Size = new System.Drawing.Size(136, 22);
            this.txtNomeCamisola.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome Camisola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posição:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(405, 409);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(136, 22);
            this.txtAltura.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(568, 409);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(135, 22);
            this.txtPeso.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(564, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(248, 482);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(136, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(401, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mao Dominante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(563, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID Equipa";
            // 
            // listajogadores
            // 
            this.listajogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listajogadores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listajogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listajogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listajogadores.Location = new System.Drawing.Point(741, 178);
            this.listajogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listajogadores.Name = "listajogadores";
            this.listajogadores.RowHeadersWidth = 51;
            this.listajogadores.RowTemplate.Height = 24;
            this.listajogadores.Size = new System.Drawing.Size(923, 361);
            this.listajogadores.TabIndex = 20;
            this.listajogadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listajogadores_CellContentClick);
            this.listajogadores.SelectionChanged += new System.EventHandler(this.listajogadores_SelectionChanged);
            // 
            // cmbID_Equipa
            // 
            this.cmbID_Equipa.FormattingEnabled = true;
            this.cmbID_Equipa.Location = new System.Drawing.Point(567, 340);
            this.cmbID_Equipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbID_Equipa.Name = "cmbID_Equipa";
            this.cmbID_Equipa.Size = new System.Drawing.Size(135, 24);
            this.cmbID_Equipa.TabIndex = 21;
            // 
            // cmbMaoDominante
            // 
            this.cmbMaoDominante.FormattingEnabled = true;
            this.cmbMaoDominante.Location = new System.Drawing.Point(405, 482);
            this.cmbMaoDominante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaoDominante.Name = "cmbMaoDominante";
            this.cmbMaoDominante.Size = new System.Drawing.Size(121, 24);
            this.cmbMaoDominante.TabIndex = 22;
            this.cmbMaoDominante.SelectedIndexChanged += new System.EventHandler(this.cmbMaoDominante_SelectedIndexChanged);
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(248, 409);
            this.cmbPosicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 24);
            this.cmbPosicao.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(565, 278);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(741, 151);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btmAtualizar.Location = new System.Drawing.Point(375, 535);
            this.btmAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btmEliminar.Location = new System.Drawing.Point(508, 535);
            this.btmEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Limpar.Location = new System.Drawing.Point(621, 535);
            this.Limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btmInserir.Location = new System.Drawing.Point(247, 535);
            this.btmInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmInserir.Name = "btmInserir";
            this.btmInserir.Size = new System.Drawing.Size(107, 33);
            this.btmInserir.TabIndex = 59;
            this.btmInserir.Text = "Inserir";
            this.btmInserir.UseVisualStyleBackColor = true;
            this.btmInserir.Click += new System.EventHandler(this.btmInserir_Click);
            // 
            // pbFotoJogador
            // 
            this.pbFotoJogador.Image = global::NBA.Properties.Resources._10101010;
            this.pbFotoJogador.InitialImage = null;
            this.pbFotoJogador.Location = new System.Drawing.Point(245, 82);
            this.pbFotoJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFotoJogador.Name = "pbFotoJogador";
            this.pbFotoJogador.Size = new System.Drawing.Size(296, 217);
            this.pbFotoJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoJogador.TabIndex = 65;
            this.pbFotoJogador.TabStop = false;
            // 
            // ContratoJogador
            // 
            this.ContratoJogador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContratoJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContratoJogador.Location = new System.Drawing.Point(741, 610);
            this.ContratoJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContratoJogador.Name = "ContratoJogador";
            this.ContratoJogador.Size = new System.Drawing.Size(923, 149);
            this.ContratoJogador.TabIndex = 66;
            // 
            // Contrato
            // 
            this.Contrato.AutoSize = true;
            this.Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrato.Location = new System.Drawing.Point(737, 574);
            this.Contrato.Name = "Contrato";
            this.Contrato.Size = new System.Drawing.Size(66, 18);
            this.Contrato.TabIndex = 67;
            this.Contrato.Text = "Contrato";
            this.Contrato.Click += new System.EventHandler(this.Contrato_Click);
            // 
            // Estatistica
            // 
            this.Estatistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Estatistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Estatistica.Location = new System.Drawing.Point(740, 799);
            this.Estatistica.Name = "Estatistica";
            this.Estatistica.RowTemplate.Height = 24;
            this.Estatistica.Size = new System.Drawing.Size(924, 150);
            this.Estatistica.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(739, 771);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 18);
            this.label12.TabIndex = 69;
            this.label12.Text = "Estatisticas do Jogador";
            // 
            // FormJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 973);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Estatistica);
            this.Controls.Add(this.Contrato);
            this.Controls.Add(this.ContratoJogador);
            this.Controls.Add(this.pbFotoJogador);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJogadores";
            this.Text = "FormJogadores";
            this.Load += new System.EventHandler(this.FormJogadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listajogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estatistica)).EndInit();
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
        private System.Windows.Forms.PictureBox pbFotoJogador;
        private System.Windows.Forms.DataGridView ContratoJogador;
        private System.Windows.Forms.Label Contrato;
        private System.Windows.Forms.DataGridView Estatistica;
        private System.Windows.Forms.Label label12;
    }
}