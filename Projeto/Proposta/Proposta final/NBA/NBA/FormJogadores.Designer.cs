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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(1719, 67);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(442, 136);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(136, 22);
            this.txtCC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "CC:";
            // 
            // txtNomeCamisola
            // 
            this.txtNomeCamisola.Location = new System.Drawing.Point(285, 204);
            this.txtNomeCamisola.Name = "txtNomeCamisola";
            this.txtNomeCamisola.Size = new System.Drawing.Size(461, 22);
            this.txtNomeCamisola.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome Camisola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posição:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(442, 271);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(136, 22);
            this.txtAltura.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(605, 271);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(141, 22);
            this.txtPeso.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(285, 344);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(136, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mao Dominante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(601, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID Equipa";
            // 
            // listajogadores
            // 
            this.listajogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listajogadores.Location = new System.Drawing.Point(809, 136);
            this.listajogadores.Name = "listajogadores";
            this.listajogadores.RowHeadersWidth = 51;
            this.listajogadores.RowTemplate.Height = 24;
            this.listajogadores.Size = new System.Drawing.Size(859, 361);
            this.listajogadores.TabIndex = 20;
            // 
            // cmbID_Equipa
            // 
            this.cmbID_Equipa.FormattingEnabled = true;
            this.cmbID_Equipa.Location = new System.Drawing.Point(605, 133);
            this.cmbID_Equipa.Name = "cmbID_Equipa";
            this.cmbID_Equipa.Size = new System.Drawing.Size(121, 24);
            this.cmbID_Equipa.TabIndex = 21;
            // 
            // cmbMaoDominante
            // 
            this.cmbMaoDominante.FormattingEnabled = true;
            this.cmbMaoDominante.Location = new System.Drawing.Point(442, 344);
            this.cmbMaoDominante.Name = "cmbMaoDominante";
            this.cmbMaoDominante.Size = new System.Drawing.Size(121, 24);
            this.cmbMaoDominante.TabIndex = 22;
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Location = new System.Drawing.Point(285, 271);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 24);
            this.cmbPosicao.TabIndex = 23;
            // 
            // FormJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 550);
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
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
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
    }
}