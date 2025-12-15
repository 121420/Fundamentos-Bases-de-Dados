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
            this.classificacao = new System.Windows.Forms.DataGridView();
            this.btmTodos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificacao)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 54);
            this.panel1.TabIndex = 86;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btmOeste
            // 
            this.btmOeste.Location = new System.Drawing.Point(509, 144);
            this.btmOeste.Name = "btmOeste";
            this.btmOeste.Size = new System.Drawing.Size(75, 23);
            this.btmOeste.TabIndex = 90;
            this.btmOeste.Text = "Oeste";
            this.btmOeste.UseVisualStyleBackColor = true;
            this.btmOeste.Click += new System.EventHandler(this.btmOeste_Click);
            // 
            // btmLeste
            // 
            this.btmLeste.Location = new System.Drawing.Point(428, 144);
            this.btmLeste.Name = "btmLeste";
            this.btmLeste.Size = new System.Drawing.Size(75, 23);
            this.btmLeste.TabIndex = 89;
            this.btmLeste.Text = "Leste";
            this.btmLeste.UseVisualStyleBackColor = true;
            this.btmLeste.Click += new System.EventHandler(this.btmLeste_Click);
            // 
            // Conferencia
            // 
            this.Conferencia.AutoSize = true;
            this.Conferencia.Location = new System.Drawing.Point(345, 149);
            this.Conferencia.Name = "Conferencia";
            this.Conferencia.Size = new System.Drawing.Size(64, 13);
            this.Conferencia.TabIndex = 91;
            this.Conferencia.Text = "Conferencia";
            this.Conferencia.Click += new System.EventHandler(this.label2_Click);
            // 
            // classificacao
            // 
            this.classificacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.classificacao.BackgroundColor = System.Drawing.Color.White;
            this.classificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classificacao.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classificacao.Location = new System.Drawing.Point(348, 180);
            this.classificacao.Name = "classificacao";
            this.classificacao.Size = new System.Drawing.Size(523, 388);
            this.classificacao.TabIndex = 88;
            this.classificacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.classificacao_CellContentClick);
            // 
            // btmTodos
            // 
            this.btmTodos.Location = new System.Drawing.Point(590, 144);
            this.btmTodos.Name = "btmTodos";
            this.btmTodos.Size = new System.Drawing.Size(75, 23);
            this.btmTodos.TabIndex = 92;
            this.btmTodos.Text = "All";
            this.btmTodos.UseVisualStyleBackColor = true;
            this.btmTodos.Click += new System.EventHandler(this.btmTodos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Conferencia);
            this.panel2.Controls.Add(this.btmLeste);
            this.panel2.Controls.Add(this.btmOeste);
            this.panel2.Controls.Add(this.classificacao);
            this.panel2.Controls.Add(this.btmTodos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1464, 646);
            this.panel2.TabIndex = 93;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClassificacao";
            this.Text = "FormLigas";
            this.Load += new System.EventHandler(this.FormClassificacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificacao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btmOeste;
        private System.Windows.Forms.Button btmLeste;
        private System.Windows.Forms.Label Conferencia;
        private System.Windows.Forms.DataGridView classificacao;
        private System.Windows.Forms.Button btmTodos;
        private System.Windows.Forms.Panel panel2;
    }
}