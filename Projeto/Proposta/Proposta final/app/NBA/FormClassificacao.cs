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
    public partial class FormClassificacao : Form
    {
        string connectionString;
        public FormClassificacao()
        {
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";
            InitializeComponent();
            
        }

        private void txtidLiga_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormClassificacao_Load(object sender, EventArgs e)
        {
            CarregarClassificacao("");
        }
        private void CarregarClassificacao(string conferencia = "")
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM ClassificacaoEquipas";

                    if (!string.IsNullOrEmpty(conferencia))
                    {
                        // Usamos um parâmetro (@Conferencia) para evitar SQL Injection
                        query += " WHERE Conferencia = @Conferencia";
                    }
                    query += " ORDER BY Percentagem_Vitoria DESC, V DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 4. Se houver filtro, adiciona o parâmetro SQL
                        if (!string.IsNullOrEmpty(conferencia))
                        {
                            cmd.Parameters.AddWithValue("@Conferencia", conferencia);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    classificacao.DataSource = dt;
                }

                if (classificacao.Columns.Contains("Percentagem_Vitoria"))
                {
                    classificacao.Columns["Percentagem_Vitoria"].DefaultCellStyle.Format = "P3"; // Exibe com 3 casas decimais (ex: .800)
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao carregar a classificação: " + erro.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btmLeste_Click(object sender, EventArgs e)
        {
            CarregarClassificacao("leste");
        }

        private void btmOeste_Click(object sender, EventArgs e)
        {
            CarregarClassificacao("Oeste");
        }

        private void btmTodos_Click(object sender, EventArgs e)
        {
            CarregarClassificacao("");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void classificacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
