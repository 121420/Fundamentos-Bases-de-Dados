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
            cmbPosicao.Items.AddRange(new string[] { "Base (PG)", "Extremo (SF)", "Poste (C)", "Extremo-Base(SG)", "Extremo-P (PF)" });
            cmbID_Equipa.DisplayMember = "Nome";
            cmbID_Equipa.ValueMember = "ID_Equipas";


            //carregar Equipas
            CarregarEquipas();
            CarregarJogadores();

        }
        private void CarregarEquipas()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryEquipas = "SELECT ID_Equipas,Nome From Equipas ORDER BY Nome ";

                    using (SqlCommand cmd = new SqlCommand(queryEquipas, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbID_Equipa.Items.Clear(); // limpar a combobox

                            while (reader.Read())
                            {
                                cmbID_Equipa.Items.Add(new { Id = reader.GetInt32(0), Nome = reader.GetString(1) });
                            }

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
                    }


                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar Jogadores" + erro.Message);
            }
        }
    }
}
