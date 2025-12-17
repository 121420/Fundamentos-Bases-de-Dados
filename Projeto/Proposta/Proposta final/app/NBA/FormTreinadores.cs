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
    public partial class FormTreinadores : Form
    {
        string connectionString;
        public FormTreinadores()
        {
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";
            InitializeComponent();
            CarregarTreinadores();
            cmbLicensa.Items.AddRange(new string[] { "Nivel A", "Nivel B", "Nivel C", "Nivel A+", "Nivel B+", "Nivel C+", "Nivel Pro" });
        }
        private void CarregarTreinadores()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT P.Nome,T.CC,T.ID_Treinador,T.Experiencia_anos,T.Especialidade,T.Licenca " +
                    "FROM Treinadores T " +
                    "JOIN Pessoas P ON P.CC = T.CC ";

                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.Fill(dt);
                    }
                    ListaTreiadores.DataSource = dt;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao carregar Treinadores", erro.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaTreiadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdTreinador.Text = string.Empty;
            txtCC.Text = string.Empty;
            txtAnosExperiencia.Text = string.Empty;
            txtEspecialidade.Text = string.Empty;
            cmbLicensa.SelectedIndex = -1;

        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void ListaTreiadores_SelectionChanged(object sender, EventArgs e)
        {
            if (ListaTreiadores.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = ListaTreiadores.SelectedRows[0];

                string CC = selected.Cells["CC"].Value.ToString().Trim();
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    String query = "SELECT Nome FROM Pessoas where CC = @CC ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CC", CC);

                        object resultado = cmd.ExecuteScalar();
                        txtNome.Text = resultado.ToString();
                    }

                }

                txtCC.Text = selected.Cells["CC"].Value.ToString().Trim();
                txtAnosExperiencia.Text = selected.Cells["Experiencia_anos"].Value.ToString();
                txtEspecialidade.Text = selected.Cells["Especialidade"].Value.ToString();

                string licensa = selected.Cells["Licenca"].Value.ToString();
                cmbLicensa.SelectedIndex = cmbLicensa.FindStringExact(licensa);


                txtIdTreinador.Text = selected.Cells["ID_Treinador"].Value.ToString();
            }

        }

        private void btmInserir_Click(object sender, EventArgs e)
        {
            // 1. OBTENÇÃO E VALIDAÇÃO DOS VALORES

            string nome = txtNome.Text.Trim();
            string cc = txtCC.Text.Trim();
            string anosExperienciaStr = txtAnosExperiencia.Text.Trim();
            string especialidade = txtEspecialidade.Text.Trim();
            string idTreinadorStr = txtIdTreinador.Text.Trim();

            // Garantir que a ComboBox tem um item selecionado.
            string licenca = cmbLicensa.SelectedItem?.ToString() ?? string.Empty;

            // Verificação de campos obrigatórios
            if (string.IsNullOrEmpty(cc) ||
                string.IsNullOrEmpty(anosExperienciaStr) || string.IsNullOrEmpty(idTreinadorStr))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Dados em Falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentar converter ID e Anos para números (como fez com DateTime)
            if (!int.TryParse(idTreinadorStr, out int idTreinador))
            {
                MessageBox.Show("O ID do Treinador deve ser um número inteiro válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(anosExperienciaStr, out int anosExperiencia))
            {
                MessageBox.Show("Os Anos de Experiência devem ser um número inteiro válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string insertTreinadoresQuery = "INSERT INTO Treinadores (ID_Treinador, CC, Experiencia_anos, Especialidade, Licenca) VALUES (@ID, @CC_Ref, @Experiencia, @Especialidade, @Licenca)";

  
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();       
                    int rowsAffectedTreinadores = 0;

                    
                        using (SqlCommand cmdTreinadores = new SqlCommand(insertTreinadoresQuery, con))
                        {
                            cmdTreinadores.Parameters.AddWithValue("@ID", idTreinador);
                            cmdTreinadores.Parameters.AddWithValue("@CC_Ref", cc);
                            cmdTreinadores.Parameters.AddWithValue("@Experiencia", anosExperiencia);

                            // Tratamento para campos opcionais/null
                            cmdTreinadores.Parameters.AddWithValue("@Especialidade", string.IsNullOrEmpty(especialidade) ? (object)DBNull.Value : especialidade);
                            cmdTreinadores.Parameters.AddWithValue("@Licenca", string.IsNullOrEmpty(licenca) ? (object)DBNull.Value : licenca);

                            rowsAffectedTreinadores = cmdTreinadores.ExecuteNonQuery();
                        }

                    if (rowsAffectedTreinadores > 0)
                    {
                        MessageBox.Show("Treinador inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        LimparCampos();
                        CarregarTreinadores(); 
                    }
                    else if ( rowsAffectedTreinadores == 0)
                    {
                        
                        MessageBox.Show("Erro: Pessoa inserida, mas falha ao registar como Treinador. Verifique as chaves estrangeiras.", "Aviso de Inconsistência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    string mensagemErro = ex.Number == 2627 ? "Erro de Chave Duplicada (CC ou ID já existe) ou CC nao existe." : ex.Message;
                    MessageBox.Show("Erro SQL: " + mensagemErro, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao inserir Treinador: " + erro.Message, "Erro Geral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            string cc = txtCC.Text.Trim();
            string anosExperienciaStr = txtAnosExperiencia.Text.Trim();
            string especialidade = txtEspecialidade.Text.Trim();
            string idTreinadorStr = txtIdTreinador.Text.Trim(); 
            string licenca = cmbLicensa.SelectedItem?.ToString() ?? string.Empty;

           
            if (string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(anosExperienciaStr) || string.IsNullOrEmpty(idTreinadorStr))
            {
                MessageBox.Show("Por favor, preencha o CC, Anos de Experiência e ID do Treinador para atualizar.", "Dados em Falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (!int.TryParse(idTreinadorStr, out int idTreinador))
            {
                MessageBox.Show("O ID do Treinador deve ser um número inteiro válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(anosExperienciaStr, out int anosExperiencia))
            {
                MessageBox.Show("Os Anos de Experiência devem ser um número inteiro válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           string updateTreinadoresQuery = @"
        UPDATE Treinadores 
        SET 
            ID_Treinador = @ID, 
            Experiencia_anos = @Experiencia, 
            Especialidade = @Especialidade, 
            Licenca = @Licenca 
        WHERE CC = @CC_Chave_Treinador";

           

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    int rowsAffected = 0;

                   
                    using (SqlCommand cmdTreinadores = new SqlCommand(updateTreinadoresQuery, con))
                    {
                        cmdTreinadores.Parameters.AddWithValue("@ID", idTreinador);
                        cmdTreinadores.Parameters.AddWithValue("@Experiencia", anosExperiencia);

                        
                        cmdTreinadores.Parameters.AddWithValue("@Especialidade", string.IsNullOrEmpty(especialidade) ? (object)DBNull.Value : especialidade);
                        cmdTreinadores.Parameters.AddWithValue("@Licenca", string.IsNullOrEmpty(licenca) ? (object)DBNull.Value : licenca);

                       
                        cmdTreinadores.Parameters.AddWithValue("@CC_Chave_Treinador", cc);

                        rowsAffected = cmdTreinadores.ExecuteNonQuery();
                    }

                
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados do Treinador atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        LimparCampos();
                        CarregarTreinadores(); // Recarrega a DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registo de Treinador foi encontrado ou alterado com o CC: " + cc, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    // Captura erros SQL (ex: tentativa de atualizar o ID_Treinador para um valor duplicado, se for uma chave única)
                    MessageBox.Show("Erro SQL durante a atualização: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro geral: " + erro.Message, "Erro Geral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            string cc = txtCC.Text.Trim();

            if (string.IsNullOrEmpty(cc))
            {
                MessageBox.Show("Por favor, carregue ou insira o CC do Treinador que deseja eliminar.", "Chave em Falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                $"Tem certeza que deseja remover as credenciais de Treinador associadas ao CC {cc}? O registo da Pessoa será mantido.",
                "Confirmar Remoção de Treinador",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            
            string deleteTreinadoresQuery = "DELETE FROM Treinadores WHERE CC = @CC_Treinador";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    int rowsAffected = 0;

                    
                    using (SqlCommand cmdTreinadores = new SqlCommand(deleteTreinadoresQuery, con))
                    {
                        cmdTreinadores.Parameters.AddWithValue("@CC_Treinador", cc);
                        rowsAffected = cmdTreinadores.ExecuteNonQuery();
                    }

                 
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registo de Treinador removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                        CarregarTreinadores();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registo de Treinador foi encontrado com o CC: " + cc, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro SQL durante a remoção: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro geral: " + erro.Message, "Erro Geral", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

