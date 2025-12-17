using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class FormJogos : Form
    {
        private string connectionString;
        public FormJogos()
        {
            InitializeComponent();
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";
        }
        //Load
        private void FormJogos_Load(object sender, EventArgs e)
        {
            cmbFase.Items.AddRange(new string[] {"Regular Season" });
            txtIdJogo.Enabled = false;
            

            CarregarEquipasDropDowns();
            CarregarListaJogos();
            cmbEquipaFora.SelectedIndex = -1;
            cmbEquipaCasa.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        //Funcoes
        private void CarregarListaJogos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                con.Open();

                string query = "SELECT * FROM Jogo";

                using(SqlDataAdapter adapter = new SqlDataAdapter(query,con))
                {
                    adapter.Fill(dt);

                    listaJogos.DataSource = dt;
                }
            }

        }
        private void CarregarEquipasDropDowns()
        {
            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    DataTable dt = new DataTable();
                    con.Open();

                    string querry = "SELECT  ID_Equipas,Nome FROM Equipas ORDER BY Nome";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(querry, con))
                    {
                        adapter.Fill(dt);

                        //Equipa casa
                        cmbEquipaCasa.DataSource = dt;
                        cmbEquipaCasa.DisplayMember = "Nome";
                        cmbEquipaCasa.ValueMember = "ID_Equipas";

                        //Equipa Fora
                        DataTable dtEquipaFora = dt.Copy();
                        cmbEquipaFora.DataSource = dtEquipaFora;
                        cmbEquipaFora.DisplayMember = "Nome";
                        cmbEquipaFora.ValueMember = "ID_Equipas";

                        

                    }
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao carregar Equipas" + erro.Message);
            }
        }

        private void listaJogos_SelectionChanged(object sender, EventArgs e)
        {
            if(listaJogos.SelectedRows.Count > 0)
            {
                DataGridViewRow selected = listaJogos.SelectedRows[0];

                txtIdJogo.Text = selected.Cells["ID_Jogo"].Value.ToString();
                txtIdEstadio.Text = selected.Cells["ID_Estadio"].Value.ToString();

                //Equipa Casa
                Object EquipaCasa = selected.Cells["ID_equipa_Casa"].Value;
                if(EquipaCasa != null && EquipaCasa != DBNull.Value)
                {
                    int idEquipaCasa = Convert.ToInt32(EquipaCasa);

                    cmbEquipaCasa.SelectedValue = idEquipaCasa;
                }
                //Equipa Fora
                Object EquipaFora = selected.Cells["ID_equipa_Fora"].Value;
                if (EquipaFora != null && EquipaFora != DBNull.Value)
                {
                    int idEquipaFora = Convert.ToInt32(EquipaFora);

                    cmbEquipaFora.SelectedValue = idEquipaFora;
                }

                txtPontosCasa.Text = selected.Cells["pontos_casa"].Value.ToString();
                txtPontosFora.Text = selected.Cells["pontos_Fora"].Value.ToString();

                string fase = selected.Cells["fase"].Value.ToString();
                cmbFase.SelectedIndex = cmbFase.FindStringExact(fase);

                if (selected.Cells["dataHora_jogo"].Value != DBNull.Value)
                {
                    DateTime dataNasc = (DateTime)selected.Cells["dataHora_jogo"].Value;
                    txtData.Text = dataNasc.ToString("dd/MM/yyyy HH:mm:ss");
                }
                string idTemporada = selected.Cells["ID_Temporada"].Value.ToString();
                txtIDTemporada.Text = idTemporada;
            }
        }

        private void listaJogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void LimparCampo()
        {
            txtIdJogo.Text = string.Empty;
            txtIdJogo.Enabled = true;
            txtIdEstadio.Text = string.Empty;
            txtData.Text = string.Empty;
            cmbEquipaCasa.SelectedIndex = -1;
            cmbEquipaFora.SelectedIndex = -1;
            txtPontosCasa.Text = string.Empty;
            txtPontosFora.Text = string.Empty;
            cmbFase.SelectedIndex = -1;
            txtIDTemporada.Text = string.Empty;
            
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btmInserir_Click(object sender, EventArgs e)
        {

            string dataString = txtData.Text.Trim(); // Mudei para txtDataHora para clareza
            DateTime dataJogo;

            // Define o formato esperado (Dia/Mês/Ano Hora:Minuto - 24h)
            const string formatoEsperado = "dd/MM/yyyy HH:mm";

            // Tenta converter a string para um objeto DateTime
            if (!DateTime.TryParseExact(dataString,
                                        formatoEsperado,
                                        CultureInfo.InvariantCulture, // Use InvariantCulture para garantir que o formato seja lido exatamente como "dd/MM/yyyy"
                                        DateTimeStyles.None,
                                        out dataJogo))
            {
                MessageBox.Show($"Formato de Data/Hora inválido. Use o formato: {formatoEsperado} (Ex: 17/02/2025 19:30).", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Pára a inserção se o formato estiver errado
            }


            string idJogo = txtIdJogo.Text.Trim();
            string idEstadio = txtIdEstadio.Text.Trim();

            object idEquipaCasa = cmbEquipaCasa.SelectedValue;
            object idEquipaFora = cmbEquipaFora.SelectedValue;
            
            string pontosCasa = txtPontosCasa.Text.Trim();
            string pontoFora = txtPontosFora.Text.Trim();
            string fase = cmbFase.Text;
            string idtemporada = txtIDTemporada.Text.Trim();

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO JOGO (ID_Jogo,dataHora_jogo,ID_estadio,ID_equipa_Casa,ID_equipa_Fora,pontos_casa,pontos_fora,fase,ID_Temporada) Values (@ID_Jogo,@dataHora_jogo,@ID_estadio,@ID_equipa_Casa,@ID_equipa_Fora,@pontos_casa,@pontos_fora,@fase,@ID_Temporada)";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Jogo", idJogo);
                        cmd.Parameters.AddWithValue("dataHora_jogo", dataJogo);
                        cmd.Parameters.AddWithValue("@ID_estadio", idEstadio);
                        cmd.Parameters.AddWithValue("@ID_equipa_Casa", idEquipaCasa);
                        cmd.Parameters.AddWithValue("@ID_equipa_Fora", idEquipaFora);
                        cmd.Parameters.AddWithValue("@pontos_casa", pontosCasa);
                        cmd.Parameters.AddWithValue("@pontos_fora", pontoFora);
                        cmd.Parameters.AddWithValue("@fase", fase);
                        cmd.Parameters.AddWithValue("@ID_Temporada", idtemporada);


                        int rowaffect = cmd.ExecuteNonQuery();

                        if (rowaffect > 0)
                        {
                            MessageBox.Show("Jogo Adicionado COm Sucesso !", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            LimparCampo();
                            CarregarListaJogos();
                            
                        }
                    }
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro SQL " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao inserir Pessoa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            string idJogoString = txtIdJogo.Text.Trim();
            string dataString = txtData.Text.Trim();
            DateTime dataJogo;

            const string formatoEsperado = "dd/MM/yyyy HH:mm";

            if (string.IsNullOrEmpty(idJogoString))
            {
                MessageBox.Show("Selecione um Jogo para atualizar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParseExact(dataString,
                                        formatoEsperado,
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out dataJogo))
            {
                MessageBox.Show($"Formato de Data/Hora inválido. Use o formato: {formatoEsperado} (Ex: 17/02/2025 19:30).", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           object idEquipaCasaObj = cmbEquipaCasa.SelectedValue;
            object idEquipaForaObj = cmbEquipaFora.SelectedValue;

            
            if (idEquipaCasaObj == null || idEquipaForaObj == null)
            {
                MessageBox.Show("Selecione as Equipas Casa e Fora.", "Erro de Seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idJogo, idEstadio, pontosCasa, pontosFora, idTemporada;

            if (!int.TryParse(txtIdJogo.Text.Trim(), out idJogo) ||
                !int.TryParse(txtIdEstadio.Text.Trim(), out idEstadio) ||
                !int.TryParse(txtPontosCasa.Text.Trim(), out pontosCasa) ||
                !int.TryParse(txtPontosFora.Text.Trim(), out pontosFora) ||
                !int.TryParse(txtIDTemporada.Text.Trim(), out idTemporada))
            {
                MessageBox.Show("Certifique-se de que o ID do Jogo, ID do Estádio, Pontos e ID da Temporada são números inteiros válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
            string fase = cmbFase.Text;

           
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryUpdate = @"
                UPDATE JOGO SET 
                    dataHora_jogo = @DataHora, 
                    ID_estadio = @ID_Estadio, 
                    ID_equipa_Casa = @ID_Casa, 
                    ID_equipa_Fora = @ID_Fora, 
                    pontos_casa = @PontosCasa, 
                    pontos_fora = @PontosFora, 
                    fase = @Fase, 
                    ID_Temporada = @ID_Temporada
                WHERE ID_Jogo = @ID_Jogo";

                    using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                    {
                        //  Parâmetros
                        cmd.Parameters.AddWithValue("@ID_Jogo", idJogo); 
                        cmd.Parameters.AddWithValue("@DataHora", dataJogo);
                        cmd.Parameters.AddWithValue("@ID_Estadio", idEstadio);
                        cmd.Parameters.AddWithValue("@ID_Casa", idEquipaCasaObj);
                        cmd.Parameters.AddWithValue("@ID_Fora", idEquipaForaObj); 
                        cmd.Parameters.AddWithValue("@PontosCasa", pontosCasa);
                        cmd.Parameters.AddWithValue("@PontosFora", pontosFora);
                        cmd.Parameters.AddWithValue("@Fase", fase);
                        cmd.Parameters.AddWithValue("@ID_Temporada", idTemporada);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Jogo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarListaJogos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi atualizado. Verifique o ID do Jogo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao atualizar Jogo: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar Jogo: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            string idJogoString = txtIdJogo.Text.Trim();
            int idJogo;

            if (string.IsNullOrEmpty(idJogoString))
            {
                MessageBox.Show("Selecione um Jogo (preenchendo o ID do Jogo) para eliminar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idJogoString, out idJogo))
            {
                MessageBox.Show("O ID do Jogo deve ser um número inteiro válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                $"Tem certeza que deseja eliminar o Jogo com ID: {idJogo}?",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryDelete = "DELETE FROM JOGO WHERE ID_Jogo = @ID_Jogo";

                    using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Jogo", idJogo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Jogo eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampo();
                            CarregarListaJogos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi eliminado. O ID do Jogo pode não existir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao eliminar Jogo: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao eliminar Jogo: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class DataTime
    {
    }
}
