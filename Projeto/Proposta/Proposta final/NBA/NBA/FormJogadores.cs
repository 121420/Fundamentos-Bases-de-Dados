using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NBA
{
    public partial class FormJogadores : Form
    {
        private string connectionString;
        public FormJogadores()
        {
            InitializeComponent();
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormJogadores_Load(object sender, EventArgs e)
        {
            cmbMaoDominante.Items.AddRange(new string[] { "Direita", "Esquerda" });
            cmbPosicao.Items.AddRange(new string[] { "Base (PG)", "Extremo (SF)", "Poste (C)", "Extremo-Base (SG)", "Extremo-P. (PF)" });
           


            //carregar Equipas
            CarregarEquipas();
            CarregarJogadores();

        }
        private void CarregarEquipas()
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryEquipas = "SELECT ID_Equipas,Nome From Equipas ORDER BY Nome ";

                    using (SqlCommand cmd = new SqlCommand(queryEquipas, con))
                    {
                       using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                       { 
                            adapter.Fill(DT);

                            cmbID_Equipa.DataSource = DT;
                       }

                        
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Equipas: " + erro.Message);
            }
        }
        private void CarregarJogadores()
        {
            DataTable jogadoresDT = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryJogadore = "SELECT * from Jogadores";

                    using (SqlCommand cmd = new SqlCommand(queryJogadore, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        adapter.Fill(jogadoresDT);

                        listajogadores.DataSource = jogadoresDT;
                        cmbID_Equipa.DisplayMember = "Nome";
                        cmbID_Equipa.ValueMember = "ID_Equipas";

                    }


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Jogadores" + erro.Message);
            }
        }

        private void listajogadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listajogadores_SelectionChanged(object sender, EventArgs e)
        {
            if(listajogadores.SelectedRows.Count >0)
            {
                DataGridViewRow selectedRow = listajogadores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID_Jogador"].Value.ToString();
                txtCC.Text = selectedRow.Cells["CC"].Value.ToString();
                txtCC.Enabled = false;

                //ID_Equpas
                object equipaID = selectedRow.Cells["ID_Equipa"].Value;
                if(equipaID != null && equipaID != DBNull.Value)
                {
                    int idEquipa = Convert.ToInt32(equipaID);

                    cmbID_Equipa.SelectedValue = idEquipa;
                }
                else { cmbID_Equipa.SelectedIndex = -1; }

                  
                txtNomeCamisola.Text = selectedRow.Cells["Nome_camisola"].Value.ToString();

                string posicao = selectedRow.Cells["Posicao"].Value.ToString();
                cmbPosicao.SelectedIndex = cmbPosicao.FindStringExact(posicao);


                txtAltura.Text = selectedRow.Cells["Altura"].Value.ToString();
                txtPeso.Text = selectedRow.Cells["Peso"].Value.ToString();
                txtNumero.Text = selectedRow.Cells["Numero"].Value.ToString();


                string maoDominante = selectedRow.Cells["Mao_Dominante"].Value.ToString();
                cmbMaoDominante.SelectedIndex = cmbMaoDominante.FindStringExact(maoDominante);


            }
        }
    }
}
