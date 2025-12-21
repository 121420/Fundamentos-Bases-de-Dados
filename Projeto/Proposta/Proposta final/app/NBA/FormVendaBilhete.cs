using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class FormVendaBilhete : Form
    {
        
        private int _idJogo;
        private int _idEstadio;
        private string connectionString;
        public FormVendaBilhete(int idJogo)
        {
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";

            InitializeComponent();
            _idJogo = idJogo;

            AtualizarLugaresDisponiveis(idJogo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDadosJogo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT E1.Nome AS Casa, E2.Nome AS Fora, 
                                Es.Nome AS Estadio, J.dataHora_jogo
                         FROM Jogo J
                         JOIN Equipas E1 ON E1.ID_Equipas = J.ID_Equipa_Casa
                         JOIN Equipas E2 ON E2.ID_Equipas = J.ID_Equipa_Fora
                         JOIN Estadios Es ON Es.ID_Estadio = J.ID_Estadio
                         WHERE J.ID_Jogo = @ID_Jogo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Jogo", _idJogo);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            lblJogo.Text = $"{dr["Casa"]} vs {dr["Fora"]}";
                            lblEstadio.Text = dr["Estadio"].ToString();
                            lblData.Text = Convert.ToDateTime(dr["dataHora_jogo"]).ToShortDateString();
                           
                        }
                    }
                }
            }
        }

        private void FormVendaBilhete_Load(object sender, EventArgs e)
        {
            
            CarregarDadosJogo();
            txtIDJogo.Text = _idJogo.ToString();
            txtIDJogo.ReadOnly = true;

            cmbSetor.Items.AddRange(new string[] { "A1", "A2" ,"B1", "B2", "C1", "C2", "D1", "D2" });
        }
        private void AtualizarLugaresDisponiveis(int idJogo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Chamamos a função diretamente num SELECT
                string query = "SELECT dbo.fn_BilhetesRestantes(@ID_Jogo)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Jogo", idJogo);
                    int restantes = (int)cmd.ExecuteScalar();

                    lblBilhetesRestantes.Text = $"Lugares restantes: {restantes}";

                    // Feedback visual: se for 0, bloqueia o botão de venda
                    btmConfirmar.Enabled = (restantes > 0);
                    if (restantes <= 0) lblBilhetesRestantes.ForeColor = Color.Red;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btmConfirmar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 1. Verificar se o CC existe
                string queryCheck = "SELECT COUNT(*) FROM Pessoas WHERE CC = @CC";
                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, con))
                {
                    cmdCheck.Parameters.AddWithValue("@CC", txtCC.Text);
                    int existe = (int)cmdCheck.ExecuteScalar();

                    if (existe == 0)
                    {
                        // 2. Se não existir, pergunta se quer cadastrar
                        DialogResult dr = MessageBox.Show("Este CC não existe. Deseja cadastrar esta pessoa agora?",
                            "Utilizador não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            // 3. Abre o formulário de Pessoas passando o CC
                            // Nota: Precisas de ajustar o construtor do FormPessoas para receber o CC
                            FormPessoas frmPessoas = new FormPessoas(txtCC.Text,1);
                            frmPessoas.ShowDialog(); // ShowDialog trava esta janela até a outra fechar

                            // Após fechar, o utilizador pode tentar clicar em "Vender" novamente
                            return;
                        }
                        else { return; }
                    }
                }
                ExecutarVenda();
            }
        }
        private void ExecutarVenda()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 1. Gerar o próximo ID do Bilhete
                    int proximoId = 1;
                    string queryMaxId = "SELECT MAX(ID_bilhete) FROM Bilhete";
                    using (SqlCommand cmdId = new SqlCommand(queryMaxId, con))
                    {
                        object res = cmdId.ExecuteScalar();
                        if (res != DBNull.Value && res != null)
                            proximoId = Convert.ToInt32(res) + 1;
                    }

                    string queryEtadio = @"SELECT ID_Estadio " +
                          "FROM Jogo " +
                          "WHERE ID_Jogo = @ID_Jogo";
                    using (SqlCommand cmd2 = new SqlCommand(queryEtadio, con))
                    {
                        cmd2.Parameters.AddWithValue("@ID_Jogo", _idJogo);
                        object result = cmd2.ExecuteScalar();

                        if (result != null)
                            _idEstadio = Convert.ToInt32(result);
                    }

                    // 3. Chamada da Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("sp_VenderBilhete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Bilhete", proximoId);
                        cmd.Parameters.AddWithValue("@ID_Estadio", _idEstadio); // Usa o valor real buscado
                        cmd.Parameters.AddWithValue("@ID_Jogo", _idJogo);
                        cmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(txtPreco.Text));
                        cmd.Parameters.AddWithValue("@Lugar", txtLugar.Text);
                        cmd.Parameters.AddWithValue("@Setor", cmbSetor.Text);
                        cmd.Parameters.AddWithValue("@CC", Convert.ToInt32(txtCC.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bilhete vendido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                // Captura erros de lotação da SP ou erros de chave estrangeira
                MessageBox.Show("Erro no Banco: " + ex.Message, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro técnico: " + ex.Message);
            }
            this.Close();
        }
    }
}
