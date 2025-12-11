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
            cmbEquipaFora.SelectedIndex = -1;
            cmbEquipaCasa.SelectedIndex = -1;

            CarregarEquipasDropDowns();
            CarregarListaJogos();
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

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btmInserir_Click(object sender, EventArgs e)
        {
            string idJogo = txtIdJogo.Text.Trim();
            string idEstadio = txtIdEstadio.Text.Trim();
            string data = txtData.Text.Trim();
            string equipaCasa = cmbEquipaCasa.Text;
            string equipaFora = cmbEquipaFora.Text;
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
                        cmd.Parameters.AddWithValue("dataHora_jogo", data);
                        cmd.Parameters.AddWithValue("@ID_estadio", idEstadio);
                        cmd.Parameters.AddWithValue("@ID_equipa_Casa", equipaCasa);
                        cmd.Parameters.AddWithValue("@ID_equipa_Fora", equipaFora);
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
                    MessageBox.Show("Erro SQL (CC duplicado ou formato inválido): " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao inserir Pessoa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
