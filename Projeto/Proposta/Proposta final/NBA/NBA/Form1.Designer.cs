namespace NBA
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btm_Jogador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btm_Treinadores = new System.Windows.Forms.Button();
            this.btm_Equipas = new System.Windows.Forms.Button();
            this.btm_jogos = new System.Windows.Forms.Button();
            this.btmClassificacao = new System.Windows.Forms.Button();
            this.btm_Pessoas = new System.Windows.Forms.Button();
            this.btmSair = new System.Windows.Forms.Button();
            this.PainelContent = new System.Windows.Forms.Panel();
            this.fundo = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1707, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fundo);
            this.panel4.Controls.Add(this.PainelContent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1924, 672);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btmSair);
            this.panel1.Controls.Add(this.btm_Pessoas);
            this.panel1.Controls.Add(this.btmClassificacao);
            this.panel1.Controls.Add(this.btm_jogos);
            this.panel1.Controls.Add(this.btm_Equipas);
            this.panel1.Controls.Add(this.btm_Treinadores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btm_Jogador);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 672);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 135);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btm_Jogador
            // 
            this.btm_Jogador.FlatAppearance.BorderSize = 0;
            this.btm_Jogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Jogador.ForeColor = System.Drawing.Color.White;
            this.btm_Jogador.Image = ((System.Drawing.Image)(resources.GetObject("btm_Jogador.Image")));
            this.btm_Jogador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Jogador.Location = new System.Drawing.Point(1, 196);
            this.btm_Jogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_Jogador.Name = "btm_Jogador";
            this.btm_Jogador.Size = new System.Drawing.Size(216, 76);
            this.btm_Jogador.TabIndex = 3;
            this.btm_Jogador.Text = "Jogadores";
            this.btm_Jogador.UseVisualStyleBackColor = true;
            this.btm_Jogador.Click += new System.EventHandler(this.btm_Jogador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Painel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btm_Treinadores
            // 
            this.btm_Treinadores.FlatAppearance.BorderSize = 0;
            this.btm_Treinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Treinadores.ForeColor = System.Drawing.Color.White;
            this.btm_Treinadores.Image = ((System.Drawing.Image)(resources.GetObject("btm_Treinadores.Image")));
            this.btm_Treinadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Treinadores.Location = new System.Drawing.Point(0, 265);
            this.btm_Treinadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_Treinadores.Name = "btm_Treinadores";
            this.btm_Treinadores.Size = new System.Drawing.Size(214, 76);
            this.btm_Treinadores.TabIndex = 5;
            this.btm_Treinadores.Text = "Treinadores";
            this.btm_Treinadores.UseVisualStyleBackColor = true;
            this.btm_Treinadores.Click += new System.EventHandler(this.btm_Treinadores_Click);
            // 
            // btm_Equipas
            // 
            this.btm_Equipas.FlatAppearance.BorderSize = 0;
            this.btm_Equipas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Equipas.ForeColor = System.Drawing.Color.White;
            this.btm_Equipas.Image = ((System.Drawing.Image)(resources.GetObject("btm_Equipas.Image")));
            this.btm_Equipas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Equipas.Location = new System.Drawing.Point(0, 340);
            this.btm_Equipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_Equipas.Name = "btm_Equipas";
            this.btm_Equipas.Size = new System.Drawing.Size(218, 76);
            this.btm_Equipas.TabIndex = 6;
            this.btm_Equipas.Text = "Equipas";
            this.btm_Equipas.UseVisualStyleBackColor = true;
            this.btm_Equipas.Click += new System.EventHandler(this.btm_Equipas_Click);
            // 
            // btm_jogos
            // 
            this.btm_jogos.FlatAppearance.BorderSize = 0;
            this.btm_jogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_jogos.ForeColor = System.Drawing.Color.White;
            this.btm_jogos.Image = ((System.Drawing.Image)(resources.GetObject("btm_jogos.Image")));
            this.btm_jogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_jogos.Location = new System.Drawing.Point(-1, 474);
            this.btm_jogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_jogos.Name = "btm_jogos";
            this.btm_jogos.Size = new System.Drawing.Size(219, 76);
            this.btm_jogos.TabIndex = 8;
            this.btm_jogos.Text = "Jogos";
            this.btm_jogos.UseVisualStyleBackColor = true;
            this.btm_jogos.Click += new System.EventHandler(this.btm_jogos_Click);
            // 
            // btmClassificacao
            // 
            this.btmClassificacao.FlatAppearance.BorderSize = 0;
            this.btmClassificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmClassificacao.ForeColor = System.Drawing.Color.White;
            this.btmClassificacao.Image = ((System.Drawing.Image)(resources.GetObject("btmClassificacao.Image")));
            this.btmClassificacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmClassificacao.Location = new System.Drawing.Point(2, 540);
            this.btmClassificacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmClassificacao.Name = "btmClassificacao";
            this.btmClassificacao.Size = new System.Drawing.Size(215, 77);
            this.btmClassificacao.TabIndex = 9;
            this.btmClassificacao.Text = "Classificacao";
            this.btmClassificacao.UseVisualStyleBackColor = true;
            this.btmClassificacao.Click += new System.EventHandler(this.Btm_Ligas_Click_1);
            // 
            // btm_Pessoas
            // 
            this.btm_Pessoas.FlatAppearance.BorderSize = 0;
            this.btm_Pessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Pessoas.ForeColor = System.Drawing.Color.White;
            this.btm_Pessoas.Image = ((System.Drawing.Image)(resources.GetObject("btm_Pessoas.Image")));
            this.btm_Pessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Pessoas.Location = new System.Drawing.Point(0, 410);
            this.btm_Pessoas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btm_Pessoas.Name = "btm_Pessoas";
            this.btm_Pessoas.Size = new System.Drawing.Size(217, 76);
            this.btm_Pessoas.TabIndex = 10;
            this.btm_Pessoas.Text = "Pessoas";
            this.btm_Pessoas.UseVisualStyleBackColor = true;
            this.btm_Pessoas.Click += new System.EventHandler(this.btm_Pessoas_Click);
            // 
            // btmSair
            // 
            this.btmSair.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btmSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btmSair.FlatAppearance.BorderSize = 0;
            this.btmSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSair.ForeColor = System.Drawing.Color.White;
            this.btmSair.Image = ((System.Drawing.Image)(resources.GetObject("btmSair.Image")));
            this.btmSair.Location = new System.Drawing.Point(0, 621);
            this.btmSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmSair.Name = "btmSair";
            this.btmSair.Size = new System.Drawing.Size(217, 51);
            this.btmSair.TabIndex = 10;
            this.btmSair.UseVisualStyleBackColor = true;
            this.btmSair.Click += new System.EventHandler(this.btmSair_Click);
            // 
            // PainelContent
            // 
            this.PainelContent.BackColor = System.Drawing.Color.Transparent;
            this.PainelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelContent.Location = new System.Drawing.Point(0, 0);
            this.PainelContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PainelContent.Name = "PainelContent";
            this.PainelContent.Size = new System.Drawing.Size(1924, 672);
            this.PainelContent.TabIndex = 4;
            // 
            // fundo
            // 
            this.fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundo.Image = ((System.Drawing.Image)(resources.GetObject("fundo.Image")));
            this.fundo.Location = new System.Drawing.Point(0, 0);
            this.fundo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(1924, 672);
            this.fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundo.TabIndex = 3;
            this.fundo.TabStop = false;
            this.fundo.WaitOnLoad = true;
            this.fundo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PainelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmSair;
        private System.Windows.Forms.Button btm_Pessoas;
        private System.Windows.Forms.Button btmClassificacao;
        private System.Windows.Forms.Button btm_jogos;
        private System.Windows.Forms.Button btm_Equipas;
        private System.Windows.Forms.Button btm_Treinadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btm_Jogador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox fundo;
    }
}

