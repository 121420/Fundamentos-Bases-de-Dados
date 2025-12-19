namespace NBA
{
    partial class FormEquipas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbIDLiga = new System.Windows.Forms.ComboBox();
            this.cmbConferencia = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.btmInserir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.Label();
            this.txtIdEquipa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listaEquipas = new System.Windows.Forms.DataGridView();
            this.pbFotoEquipa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEquipas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEquipa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1777, 66);
            this.panel1.TabIndex = 66;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pbFotoEquipa);
            this.panel2.Controls.Add(this.cmbIDLiga);
            this.panel2.Controls.Add(this.cmbConferencia);
            this.panel2.Controls.Add(this.cmbCidade);
            this.panel2.Controls.Add(this.btmAtualizar);
            this.panel2.Controls.Add(this.btmEliminar);
            this.panel2.Controls.Add(this.Limpar);
            this.panel2.Controls.Add(this.btmInserir);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.aa);
            this.panel2.Controls.Add(this.txtIdEquipa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 592);
            this.panel2.TabIndex = 67;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbIDLiga
            // 
            this.cmbIDLiga.FormattingEnabled = true;
            this.cmbIDLiga.Location = new System.Drawing.Point(279, 486);
            this.cmbIDLiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIDLiga.Name = "cmbIDLiga";
            this.cmbIDLiga.Size = new System.Drawing.Size(153, 24);
            this.cmbIDLiga.TabIndex = 96;
            // 
            // cmbConferencia
            // 
            this.cmbConferencia.FormattingEnabled = true;
            this.cmbConferencia.Location = new System.Drawing.Point(453, 417);
            this.cmbConferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConferencia.Name = "cmbConferencia";
            this.cmbConferencia.Size = new System.Drawing.Size(153, 24);
            this.cmbConferencia.TabIndex = 95;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(279, 417);
            this.cmbCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(153, 24);
            this.cmbCidade.TabIndex = 94;
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtualizar.Location = new System.Drawing.Point(403, 548);
            this.btmAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(107, 33);
            this.btmAtualizar.TabIndex = 92;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            this.btmAtualizar.Click += new System.EventHandler(this.btmAtualizar_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEliminar.Location = new System.Drawing.Point(535, 548);
            this.btmEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(107, 33);
            this.btmEliminar.TabIndex = 91;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(649, 548);
            this.Limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(107, 33);
            this.Limpar.TabIndex = 90;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // btmInserir
            // 
            this.btmInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmInserir.Location = new System.Drawing.Point(275, 548);
            this.btmInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmInserir.Name = "btmInserir";
            this.btmInserir.Size = new System.Drawing.Size(107, 33);
            this.btmInserir.TabIndex = 89;
            this.btmInserir.Text = "Inserir";
            this.btmInserir.UseVisualStyleBackColor = true;
            this.btmInserir.Click += new System.EventHandler(this.btmInserir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 76;
            this.label6.Text = "ID_Liga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Conferencia";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(273, 392);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(54, 18);
            this.txt.TabIndex = 72;
            this.txt.Text = "Cidade";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(453, 349);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 22);
            this.txtNome.TabIndex = 71;
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa.Location = new System.Drawing.Point(446, 321);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(49, 18);
            this.aa.TabIndex = 70;
            this.aa.Text = "Nome";
            // 
            // txtIdEquipa
            // 
            this.txtIdEquipa.Location = new System.Drawing.Point(279, 349);
            this.txtIdEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEquipa.Name = "txtIdEquipa";
            this.txtIdEquipa.Size = new System.Drawing.Size(153, 22);
            this.txtIdEquipa.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "ID Equipas:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtPesquisa);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.listaEquipas);
            this.panel3.Location = new System.Drawing.Point(805, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 592);
            this.panel3.TabIndex = 68;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(53, 135);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(736, 22);
            this.txtPesquisa.TabIndex = 93;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 92;
            this.label11.Text = "Pesquisa";
            // 
            // listaEquipas
            // 
            this.listaEquipas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaEquipas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.listaEquipas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaEquipas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listaEquipas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEquipas.Location = new System.Drawing.Point(53, 174);
            this.listaEquipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaEquipas.Name = "listaEquipas";
            this.listaEquipas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.listaEquipas.RowTemplate.Height = 24;
            this.listaEquipas.Size = new System.Drawing.Size(1116, 361);
            this.listaEquipas.TabIndex = 91;
            this.listaEquipas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaEquipas_CellContentClick);
            this.listaEquipas.SelectionChanged += new System.EventHandler(this.listaEquipas_SelectionChanged);
            // 
            // pbFotoEquipa
            // 
            this.pbFotoEquipa.Location = new System.Drawing.Point(275, 80);
            this.pbFotoEquipa.Name = "pbFotoEquipa";
            this.pbFotoEquipa.Size = new System.Drawing.Size(331, 195);
            this.pbFotoEquipa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoEquipa.TabIndex = 97;
            this.pbFotoEquipa.TabStop = false;
            // 
            // FormEquipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 658);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEquipas";
            this.Text = "FormEquipas";
            this.Load += new System.EventHandler(this.FormEquipas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEquipas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoEquipa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIdEquipa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button btmInserir;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView listaEquipas;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbIDLiga;
        private System.Windows.Forms.ComboBox cmbConferencia;
        private System.Windows.Forms.PictureBox pbFotoEquipa;
    }
}