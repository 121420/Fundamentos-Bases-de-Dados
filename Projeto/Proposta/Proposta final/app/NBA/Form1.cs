using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void AbrirFormularioNoPainel(Form FormFilho)
        {
            //Limpar o painel e 
            this.PainelContent.Controls.Clear();
            this.PainelContent.BringToFront();
            //configurar
            FormFilho.TopLevel = false;
            FormFilho.FormBorderStyle = FormBorderStyle.None;
            FormFilho.Dock = DockStyle.Fill;     // Faz o formulário filho preencher todo o painel

            // 3. Adiciona o formulário filho aos controles do painel
            this.PainelContent.Controls.Add(FormFilho);
            this.PainelContent.Tag = FormFilho; // Armazena a referência (opcional, mas útil)

            // 4. Mostra o formulário
            FormFilho.Show();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btm_ligas_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormClassificacao());
        }

        private void btm_Jogador_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormJogadores());
        }

        private void btm_Treinadores_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormTreinadores());
        }

        private void btm_Equipas_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormEquipas());
        }

        private void btm_jogos_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormJogos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.PainelContent.Controls.Clear();
            this.fundo.Show();
            this.fundo.BringToFront();

            
        }

        private void Btm_Ligas_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormClassificacao());

        }

        private void btm_Pessoas_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new FormPessoas());
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmBilheste_Click(object sender, EventArgs e)
        {
            AbrirFormularioNoPainel(new Bilhestes());
        }
    }
}
