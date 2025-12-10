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
    }
}
