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
            cmbLicensa.Items.AddRange(new string[] { "Nivel A","Nivel B","Nivel C","Nivel A+","Nivel B+","Nivel C+","Nivel Pro"}); 
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
    }
    }

