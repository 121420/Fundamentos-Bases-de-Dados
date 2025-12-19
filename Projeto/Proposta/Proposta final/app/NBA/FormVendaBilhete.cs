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
    public partial class FormVendaBilhete : Form
    {
        
        private int _idJogo;
        private int _idEstadio;
        private string connectionString;
        public FormVendaBilhete(int idJogo)
        {
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";

            InitializeComponent();
            _idJogo = idJogo;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDadosJogo()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT E1.Nome AS Casa, E2.Nome AS Fora, 
                                Es.Nome AS Estadio, J.dataHora_jogo
                         FROM Jogo J
                         JOIN Equipas E1 ON E1.ID_Equipas = J.ID_Equipa_Casa
                         JOIN Equipas E2 ON E2.ID_Equipas = J.ID_Equipa_Fora
                         JOIN Estadios Es ON Es.ID_Estadio = J.ID_Estadio
                         WHERE J.ID_Jogo = @ID_Jogo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_Jogo", _idJogo);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            lblJogo.Text = $"{dr["Casa"]} vs {dr["Fora"]}";
                            lblEstadio.Text = dr["Estadio"].ToString();
                            lblData.Text = Convert.ToDateTime(dr["dataHora_jogo"]).ToShortDateString();
                           
                        }
                    }
                }
            }
        }

        private void FormVendaBilhete_Load(object sender, EventArgs e)
        {
            CarregarDadosJogo();
            txtIDJogo.Text = _idJogo.ToString();
            txtIDJogo.ReadOnly = true;

            cmbSetor.Items.AddRange(new string[] { "A1", "A2" ,"B1", "B2", "C1", "C2", "D1", "D2" });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btmConfirmar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                int proximoId = 1;
                string queryMaxId = "SELECT MAX(ID_bilhete) FROM Bilhete";
                using (SqlCommand cmdId = new SqlCommand(queryMaxId, con))
                {
                    object res = cmdId.ExecuteScalar();
                    if (res != DBNull.Value && res != null)
                    {
                        proximoId = Convert.ToInt32(res) + 1;
                    }
                }
                string query = @"
                    INSERT INTO Bilhete
                    (ID_bilhete,ID_estadio, ID_Jogo, setor, lugar, preco, vendido, CC)
                    VALUES
                    (@ID_bilhete,@ID_estadio, @ID_Jogo, @setor, @lugar, @preco, 1, @CC)";

                string queryEtadio = @"SELECT ID_Estadio " +
                         "FROM Jogo " +
                         "WHERE ID_Jogo = @ID_Jogo";
                using (SqlCommand cmd2 = new SqlCommand(queryEtadio, con))
                {
                    cmd2.Parameters.AddWithValue("@ID_Jogo", _idJogo);
                    object result = cmd2.ExecuteScalar();
                    
                    if (result != null)
                        _idEstadio = Convert.ToInt32(result);
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_bilhete", proximoId);
                    cmd.Parameters.AddWithValue("@ID_estadio", _idEstadio);

                    cmd.Parameters.AddWithValue("@ID_Jogo", _idJogo);
                    cmd.Parameters.AddWithValue("@setor", cmbSetor.Text);
                    cmd.Parameters.AddWithValue("@lugar", txtLugar.Text);
                    cmd.Parameters.AddWithValue("@preco", txtPreco.Text); // depois automatizamos
                    cmd.Parameters.AddWithValue("@CC", txtCC.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Bilhete vendido com sucesso!");
            this.Close();
        }
    }
}
