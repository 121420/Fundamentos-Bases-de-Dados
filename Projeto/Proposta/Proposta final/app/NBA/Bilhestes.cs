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
    public partial class Bilhestes : Form
    {
        private string connectionString;
        public Bilhestes()
        {
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";

            InitializeComponent();
        }

        private void CarregarjogosFuturos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM vw_JogosFuturos";

                using(SqlDataAdapter adap = new SqlDataAdapter(query,con))
                {
                    adap.Fill(dt);
                }

                ListasjogosFuturos.DataSource = dt;
            }

            if (!ListasjogosFuturos.Columns.Contains("btnVender"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnVender";
                btn.HeaderText = "Vender";
                btn.Text = "Vender Bilhete";
                btn.UseColumnTextForButtonValue = true;

                ListasjogosFuturos.Columns.Add(btn);
            }

        }

        private void ListasjogosFuturos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                ListasjogosFuturos.Columns[e.ColumnIndex].Name == "btnVender")
            {
                int idJogo = Convert.ToInt32(
                    ListasjogosFuturos.Rows[e.RowIndex].Cells["ID_Jogo"].Value);

                
                FormVendaBilhete frm = new FormVendaBilhete(idJogo);
                frm.ShowDialog();

               
            }
        }

        private void Bilhestes_Load(object sender, EventArgs e)
        {
            CarregarjogosFuturos();
        }
        private void VenderBilhete(int idBilhete, int idJogo, decimal preco, string lugar)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Configura o comando para usar a Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("sp_VenderBilhete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Adiciona os parâmetros exigidos pela SP
                        cmd.Parameters.AddWithValue("@ID_Bilhete", idBilhete);
                        cmd.Parameters.AddWithValue("@ID_Jogo", idJogo);
                        cmd.Parameters.AddWithValue("@Preco", preco);
                        cmd.Parameters.AddWithValue("@Lugar", lugar);

                        // Executa a SP
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Bilhete vendido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Aqui o C# captura o RAISERROR da tua SP (Ex: 'Estádio Lotado!')
                MessageBox.Show("Erro na base de dados: " + ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
