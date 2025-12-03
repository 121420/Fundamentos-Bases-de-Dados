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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btm_jogos = new System.Windows.Forms.Button();
            this.btm_ligas = new System.Windows.Forms.Button();
            this.btm_Equipas = new System.Windows.Forms.Button();
            this.btm_Treinadores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btm_Jogador = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fundo = new System.Windows.Forms.PictureBox();
            this.PainelContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btm_jogos);
            this.panel1.Controls.Add(this.btm_ligas);
            this.panel1.Controls.Add(this.btm_Equipas);
            this.panel1.Controls.Add(this.btm_Treinadores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btm_Jogador);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 560);
            this.panel1.TabIndex = 0;
            // 
            // btm_jogos
            // 
            this.btm_jogos.FlatAppearance.BorderSize = 0;
            this.btm_jogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_jogos.ForeColor = System.Drawing.Color.White;
            this.btm_jogos.Image = ((System.Drawing.Image)(resources.GetObject("btm_jogos.Image")));
            this.btm_jogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_jogos.Location = new System.Drawing.Point(-3, 417);
            this.btm_jogos.Name = "btm_jogos";
            this.btm_jogos.Size = new System.Drawing.Size(217, 57);
            this.btm_jogos.TabIndex = 8;
            this.btm_jogos.Text = "Jogos";
            this.btm_jogos.UseVisualStyleBackColor = true;
            this.btm_jogos.Click += new System.EventHandler(this.btm_jogos_Click);
            // 
            // btm_ligas
            // 
            this.btm_ligas.FlatAppearance.BorderSize = 0;
            this.btm_ligas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_ligas.ForeColor = System.Drawing.Color.White;
            this.btm_ligas.Image = ((System.Drawing.Image)(resources.GetObject("btm_ligas.Image")));
            this.btm_ligas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_ligas.Location = new System.Drawing.Point(-3, 364);
            this.btm_ligas.Name = "btm_ligas";
            this.btm_ligas.Size = new System.Drawing.Size(217, 64);
            this.btm_ligas.TabIndex = 7;
            this.btm_ligas.Text = "Ligas";
            this.btm_ligas.UseVisualStyleBackColor = true;
            this.btm_ligas.Click += new System.EventHandler(this.btm_ligas_Click);
            // 
            // btm_Equipas
            // 
            this.btm_Equipas.FlatAppearance.BorderSize = 0;
            this.btm_Equipas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Equipas.ForeColor = System.Drawing.Color.White;
            this.btm_Equipas.Image = ((System.Drawing.Image)(resources.GetObject("btm_Equipas.Image")));
            this.btm_Equipas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Equipas.Location = new System.Drawing.Point(-3, 310);
            this.btm_Equipas.Name = "btm_Equipas";
            this.btm_Equipas.Size = new System.Drawing.Size(217, 60);
            this.btm_Equipas.TabIndex = 6;
            this.btm_Equipas.Text = "Equipas";
            this.btm_Equipas.UseVisualStyleBackColor = true;
            this.btm_Equipas.Click += new System.EventHandler(this.btm_Equipas_Click);
            // 
            // btm_Treinadores
            // 
            this.btm_Treinadores.FlatAppearance.BorderSize = 0;
            this.btm_Treinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Treinadores.ForeColor = System.Drawing.Color.White;
            this.btm_Treinadores.Image = ((System.Drawing.Image)(resources.GetObject("btm_Treinadores.Image")));
            this.btm_Treinadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Treinadores.Location = new System.Drawing.Point(-3, 257);
            this.btm_Treinadores.Name = "btm_Treinadores";
            this.btm_Treinadores.Size = new System.Drawing.Size(217, 57);
            this.btm_Treinadores.TabIndex = 5;
            this.btm_Treinadores.Text = "Treinadores";
            this.btm_Treinadores.UseVisualStyleBackColor = true;
            this.btm_Treinadores.Click += new System.EventHandler(this.btm_Treinadores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Painel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btm_Jogador
            // 
            this.btm_Jogador.FlatAppearance.BorderSize = 0;
            this.btm_Jogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Jogador.ForeColor = System.Drawing.Color.White;
            this.btm_Jogador.Image = ((System.Drawing.Image)(resources.GetObject("btm_Jogador.Image")));
            this.btm_Jogador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm_Jogador.Location = new System.Drawing.Point(0, 196);
            this.btm_Jogador.Name = "btm_Jogador";
            this.btm_Jogador.Size = new System.Drawing.Size(217, 63);
            this.btm_Jogador.TabIndex = 3;
            this.btm_Jogador.Text = "Jogadores";
            this.btm_Jogador.UseVisualStyleBackColor = true;
            this.btm_Jogador.Click += new System.EventHandler(this.btm_Jogador_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 135);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fundo);
            this.panel4.Controls.Add(this.PainelContent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1282, 560);
            this.panel4.TabIndex = 3;
            // 
            // fundo
            // 
            this.fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundo.Image = ((System.Drawing.Image)(resources.GetObject("fundo.Image")));
            this.fundo.Location = new System.Drawing.Point(0, 0);
            this.fundo.Name = "fundo";
            this.fundo.Size = new System.Drawing.Size(1282, 560);
            this.fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundo.TabIndex = 3;
            this.fundo.TabStop = false;
            this.fundo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PainelContent
            // 
            this.PainelContent.BackColor = System.Drawing.Color.Transparent;
            this.PainelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelContent.Location = new System.Drawing.Point(0, 0);
            this.PainelContent.Name = "PainelContent";
            this.PainelContent.Size = new System.Drawing.Size(1282, 560);
            this.PainelContent.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox fundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btm_Jogador;
        private System.Windows.Forms.Button btm_jogos;
        private System.Windows.Forms.Button btm_ligas;
        private System.Windows.Forms.Button btm_Equipas;
        private System.Windows.Forms.Button btm_Treinadores;
        private System.Windows.Forms.Panel PainelContent;
    }
}

