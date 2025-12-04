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

namespace NBA
{
    public partial class FormPessoas : Form
    {
        private string connectionString;
        public FormPessoas()
        {
            InitializeComponent();
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";


        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPessoas_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.AddRange(new string[] { "Masculino", "Feminino" });

            //chamada das funcoes
            CarregarPessoas();
        }

        private void CarregarPessoas()
        {
            DataTable DT = new DataTable();

            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string querry = "SELECT CC ,Nome,data_nascimento,Nacionalidade,Genero,Telefone,Email FROM Pessoas";

                    using (SqlCommand cmd = new SqlCommand(querry,con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(DT);

                        listaPessoas.DataSource = DT;


                    }
                        
                }

            }catch(Exception error)
            {
                MessageBox.Show("Erro ao carregar Pessoas " + error.Message);
            }
        }

        private void listaPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void txtCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaPessoas_SelectionChanged(object sender, EventArgs e)
        {
            //verifica se tem pelo menos 1 linha
            if (listaPessoas.SelectedRows.Count > 0)
            {
                //obter a primeira linha selecionado
                DataGridViewRow selectedRow = listaPessoas.SelectedRows[0];

                //prenechimento das txtbox e combobox

                txtCC.Text = selectedRow.Cells["CC"].Value.ToString();
                txtNome.Text = selectedRow.Cells["Nome"].Value.ToString();

                //Data Nascimento

                if (selectedRow.Cells["data_nascimento"].Value != DBNull.Value)
                {
                    DateTime dataNasc = (DateTime)selectedRow.Cells["data_nascimento"].Value;
                    mskData.Text = dataNasc.ToString("yyyy/MM/dd");
                }

                txtNacionalidade.Text = selectedRow.Cells["Nacionalidade"].Value.ToString();

                string genero = selectedRow.Cells["Genero"].Value.ToString();
                cmbGenero.SelectedIndex = cmbGenero.FindStringExact(genero);

                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtTelefone.Text = selectedRow.Cells["Telefone"].Value.ToString();


                txtCC.Enabled = false;
    
            }
        }
    }
}
