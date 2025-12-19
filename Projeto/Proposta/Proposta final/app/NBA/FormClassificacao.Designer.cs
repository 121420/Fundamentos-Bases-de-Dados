namespace NBA
{
    partial class FormClassificacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btmOeste = new System.Windows.Forms.Button();
            this.btmLeste = new System.Windows.Forms.Button();
            this.Conferencia = new System.Windows.Forms.Label();
            this.btmTodos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultadosJogos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.classificacao = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classificacao";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 66);
            this.panel1.TabIndex = 86;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btmOeste
            // 
            this.btmOeste.Location = new System.Drawing.Point(517, 187);
            this.btmOeste.Margin = new System.Windows.Forms.Padding(4);
            this.btmOeste.Name = "btmOeste";
            this.btmOeste.Size = new System.Drawing.Size(100, 28);
            this.btmOeste.TabIndex = 90;
            this.btmOeste.Text = "Oeste";
            this.btmOeste.UseVisualStyleBackColor = true;
            this.btmOeste.Click += new System.EventHandler(this.btmOeste_Click);
            // 
            // btmLeste
            // 
            this.btmLeste.Location = new System.Drawing.Point(409, 187);
            this.btmLeste.Margin = new System.Windows.Forms.Padding(4);
            this.btmLeste.Name = "btmLeste";
            this.btmLeste.Size = new System.Drawing.Size(100, 28);
            this.btmLeste.TabIndex = 89;
            this.btmLeste.Text = "Leste";
            this.btmLeste.UseVisualStyleBackColor = true;
            this.btmLeste.Click += new System.EventHandler(this.btmLeste_Click);
            // 
            // Conferencia
            // 
            this.Conferencia.AutoSize = true;
            this.Conferencia.Location = new System.Drawing.Point(298, 193);
            this.Conferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Conferencia.Name = "Conferencia";
            this.Conferencia.Size = new System.Drawing.Size(79, 16);
            this.Conferencia.TabIndex = 91;
            this.Conferencia.Text = "Conferencia";
            this.Conferencia.Click += new System.EventHandler(this.label2_Click);
            // 
            // btmTodos
            // 
            this.btmTodos.Location = new System.Drawing.Point(625, 187);
            this.btmTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btmTodos.Name = "btmTodos";
            this.btmTodos.Size = new System.Drawing.Size(100, 28);
            this.btmTodos.TabIndex = 92;
            this.btmTodos.Text = "All";
            this.btmTodos.UseVisualStyleBackColor = true;
            this.btmTodos.Click += new System.EventHandler(this.btmTodos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ResultadosJogos);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Conferencia);
            this.panel2.Controls.Add(this.btmLeste);
            this.panel2.Controls.Add(this.btmOeste);
            this.panel2.Controls.Add(this.classificacao);
            this.panel2.Controls.Add(this.btmTodos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 795);
            this.panel2.TabIndex = 93;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1074, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Resultados Dos Jogos";
            // 
            // ResultadosJogos
            // 
            this.ResultadosJogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultadosJogos.BackgroundColor = System.Drawing.Color.White;
            this.ResultadosJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadosJogos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResultadosJogos.Location = new System.Drawing.Point(1077, 223);
            this.ResultadosJogos.Margin = new System.Windows.Forms.Padding(4);
            this.ResultadosJogos.Name = "ResultadosJogos";
            this.ResultadosJogos.RowHeadersWidth = 51;
            this.ResultadosJogos.Size = new System.Drawing.Size(782, 478);
            this.ResultadosJogos.TabIndex = 94;
            this.ResultadosJogos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultadosJogos_CellContentClick);
            this.ResultadosJogos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ResultadosJogos_CellFormatting);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 795);
            this.panel3.TabIndex = 93;
            // 
            // classificacao
            // 
            this.classificacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classificacao.BackgroundColor = System.Drawing.Color.White;
            this.classificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classificacao.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classificacao.Location = new System.Drawing.Point(297, 223);
            this.classificacao.Margin = new System.Windows.Forms.Padding(4);
            this.classificacao.Name = "classificacao";
            this.classificacao.RowHeadersWidth = 51;
            this.classificacao.Size = new System.Drawing.Size(751, 478);
            this.classificacao.TabIndex = 88;
            this.classificacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classificacao_CellContentClick);
            // 
            // FormClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 795);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormClassificacao";
            this.Text = "FormLigas";
            this.Load += new System.EventHandler(this.FormClassificacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadosJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btmOeste;
        private System.Windows.Forms.Button btmLeste;
        private System.Windows.Forms.Label Conferencia;
        private System.Windows.Forms.Button btmTodos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ResultadosJogos;
        private System.Windows.Forms.DataGridView classificacao;
    }
}