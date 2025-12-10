namespace NBA
{
    partial class FormJogos
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.btmInserir = new System.Windows.Forms.Button();
            this.listaJogos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdEstadio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdJogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPontosCasa = new System.Windows.Forms.TextBox();
            this.txtPontosFora = new System.Windows.Forms.TextBox();
            this.cmbEquipaFora = new System.Windows.Forms.ComboBox();
            this.cmbEquipaCasa = new System.Windows.Forms.ComboBox();
            this.cmbFase = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaJogos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogos";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(830, 134);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(736, 22);
            this.txtPesquisa.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(827, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 89;
            this.label11.Text = "Pesquisa";
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtualizar.Location = new System.Drawing.Point(377, 400);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(107, 33);
            this.btmAtualizar.TabIndex = 88;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            // 
            // btmEliminar
            // 
            this.btmEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.Location = new System.Drawing.Point(510, 400);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(107, 33);
            this.btmEliminar.TabIndex = 87;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(623, 400);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(107, 33);
            this.Limpar.TabIndex = 86;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // btmInserir
            // 
            this.btmInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserir.Location = new System.Drawing.Point(249, 400);
            this.btmInserir.Name = "btmInserir";
            this.btmInserir.Size = new System.Drawing.Size(107, 33);
            this.btmInserir.TabIndex = 85;
            this.btmInserir.Text = "Inserir";
            this.btmInserir.UseVisualStyleBackColor = true;
            // 
            // listaJogos
            // 
            this.listaJogos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listaJogos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaJogos.Location = new System.Drawing.Point(830, 170);
            this.listaJogos.Name = "listaJogos";
            this.listaJogos.RowHeadersWidth = 51;
            this.listaJogos.RowTemplate.Height = 24;
            this.listaJogos.Size = new System.Drawing.Size(1116, 361);
            this.listaJogos.TabIndex = 81;
            this.listaJogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaJogos_CellContentClick);
            this.listaJogos.SelectionChanged += new System.EventHandler(this.listaJogos_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 79;
            this.label9.Text = "Fase:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(585, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 24);
            this.label8.TabIndex = 77;
            this.label8.Text = "Equipa Fora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 75;
            this.label7.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 73;
            this.label6.Text = "Equipa Casa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 72;
            this.label5.Text = "Data Hora:";
            // 
            // txtIdEstadio
            // 
            this.txtIdEstadio.Location = new System.Drawing.Point(427, 139);
            this.txtIdEstadio.Name = "txtIdEstadio";
            this.txtIdEstadio.Size = new System.Drawing.Size(153, 22);
            this.txtIdEstadio.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "ID Estadio";
            // 
            // txtIdJogo
            // 
            this.txtIdJogo.Location = new System.Drawing.Point(250, 139);
            this.txtIdJogo.Name = "txtIdJogo";
            this.txtIdJogo.Size = new System.Drawing.Size(154, 22);
            this.txtIdJogo.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "ID Jogo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2009, 67);
            this.panel1.TabIndex = 65;
            // 
            // txtPontosCasa
            // 
            this.txtPontosCasa.Location = new System.Drawing.Point(427, 224);
            this.txtPontosCasa.Name = "txtPontosCasa";
            this.txtPontosCasa.Size = new System.Drawing.Size(58, 22);
            this.txtPontosCasa.TabIndex = 91;
            // 
            // txtPontosFora
            // 
            this.txtPontosFora.Location = new System.Drawing.Point(523, 224);
            this.txtPontosFora.Name = "txtPontosFora";
            this.txtPontosFora.Size = new System.Drawing.Size(57, 22);
            this.txtPontosFora.TabIndex = 92;
            // 
            // cmbEquipaFora
            // 
            this.cmbEquipaFora.FormattingEnabled = true;
            this.cmbEquipaFora.Location = new System.Drawing.Point(589, 224);
            this.cmbEquipaFora.Name = "cmbEquipaFora";
            this.cmbEquipaFora.Size = new System.Drawing.Size(170, 24);
            this.cmbEquipaFora.TabIndex = 94;
            // 
            // cmbEquipaCasa
            // 
            this.cmbEquipaCasa.FormattingEnabled = true;
            this.cmbEquipaCasa.Location = new System.Drawing.Point(250, 224);
            this.cmbEquipaCasa.Name = "cmbEquipaCasa";
            this.cmbEquipaCasa.Size = new System.Drawing.Size(154, 24);
            this.cmbEquipaCasa.TabIndex = 95;
            // 
            // cmbFase
            // 
            this.cmbFase.FormattingEnabled = true;
            this.cmbFase.Location = new System.Drawing.Point(249, 323);
            this.cmbFase.Name = "cmbFase";
            this.cmbFase.Size = new System.Drawing.Size(155, 24);
            this.cmbFase.TabIndex = 96;
            this.cmbFase.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(589, 140);
            this.txtData.Mask = "00/00/0000 90:00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(170, 22);
            this.txtData.TabIndex = 98;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // FormJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2009, 543);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmbFase);
            this.Controls.Add(this.cmbEquipaCasa);
            this.Controls.Add(this.cmbEquipaFora);
            this.Controls.Add(this.txtPontosFora);
            this.Controls.Add(this.txtPontosCasa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btmAtualizar);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.btmInserir);
            this.Controls.Add(this.listaJogos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdEstadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdJogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormJogos";
            this.Text = "FormJogos";
            this.Load += new System.EventHandler(this.FormJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaJogos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button btmInserir;
        private System.Windows.Forms.DataGridView listaJogos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdEstadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdJogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPontosCasa;
        private System.Windows.Forms.TextBox txtPontosFora;
        private System.Windows.Forms.ComboBox cmbEquipaFora;
        private System.Windows.Forms.ComboBox cmbEquipaCasa;
        private System.Windows.Forms.ComboBox cmbFase;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}