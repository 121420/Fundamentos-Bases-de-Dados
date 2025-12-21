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
    public partial class Relatorio : Form
    {
        private string connectionString;
        public Relatorio()
        {
            InitializeComponent();
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            CarregarVendas();
        }
        private void CarregarVendas()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con =new SqlConnection(connectionString))
            {
                con.Open();
                string queryVendas = "SELECT * FROM vw_RelatorioVendasEfetivas";

                using (SqlDataAdapter adapter = new SqlDataAdapter(queryVendas, con))
                {
                    adapter.Fill(dt);
                }
                Vendas.DataSource = dt;            }
        }
    }
}
