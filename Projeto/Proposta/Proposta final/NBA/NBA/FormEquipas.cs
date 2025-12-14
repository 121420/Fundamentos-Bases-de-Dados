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
    public partial class FormEquipas : Form
    {
        string connectionString;
        public FormEquipas()
        {
            connectionString = @"Server=tcp:mednat.ieeta.pt,8101;Database=p4g4;User ID=p4g4;Password=-121420127986@KR;Encrypt=False;";
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormEquipas_Load(object sender, EventArgs e)
        {
            
            cmbConferencia.Items.AddRange(new string[] {"Oeste","Leste"});
            CarregarEquipas();
            CarregaCidades();
            carregarLigas();
            cmbCidade.SelectedIndex = -1;
            cmbIDLiga.SelectedIndex = -1;
        }
        //CArregar
        private void CarregarEquipas(string nomePesquisa = "")
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string queryEquipas = "SELECT * FROM Equipas";

                if (!string.IsNullOrEmpty(nomePesquisa))
                {
                    // Adiciona a cláusula WHERE para filtrar pelo Nome_camisola
                    queryEquipas += " WHERE Nome LIKE @NomeParam";
                }
                using (SqlCommand cmd = new SqlCommand(queryEquipas,con))
                {
                    if (!string.IsNullOrEmpty(nomePesquisa))
                    {
                        // Adiciona o parâmetro SQL para a pesquisa LIKE
                        cmd.Parameters.AddWithValue("@NomeParam", "%" + nomePesquisa + "%");
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    listaEquipas.DataSource = dt;  
                }

            }
        }
        private void CarregaCidades()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = "SELECT Distinct Cidade FROM Equipas";
                using(SqlDataAdapter adapter = new SqlDataAdapter(query,con))
                {
                    adapter.Fill(dt);
                }
                cmbCidade.DisplayMember = "Cidade";
                cmbCidade.ValueMember = "Cidade";
                cmbCidade.DataSource = dt;
            }
        }
        private void carregarLigas()
        {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = "Select ID_liga From Equipas GROUP BY ID_liga";

                using(SqlDataAdapter adapter = new SqlDataAdapter(query,con))
                {
                    adapter.Fill(dt);
                }
                cmbIDLiga.DisplayMember = "ID_liga";
                cmbIDLiga.ValueMember = "ID_liga";
                cmbIDLiga.DataSource = dt;

            }
        }
        //
        private void listaEquipas_SelectionChanged(object sender, EventArgs e)
        {
            if(listaEquipas.SelectedRows.Count > 0)
            {
                DataGridViewRow seleted = listaEquipas.SelectedRows[0];

                txtIdEquipa.Text = seleted.Cells["ID_Equipas"].Value.ToString();
                txtNome.Text = seleted.Cells["Nome"].Value.ToString();

                string stringCidade = seleted.Cells["Cidade"].Value.ToString();
                cmbCidade.SelectedIndex = cmbCidade.FindStringExact(stringCidade);

                string stringConferencia = seleted.Cells["Conferencia"].Value.ToString();
                cmbConferencia.SelectedIndex = cmbConferencia.FindStringExact(stringConferencia);

                object ID_liga = seleted.Cells["ID_Liga"].Value;
                cmbIDLiga.SelectedValue = ID_liga;
            }
        }

        private void listaEquipas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LimparCampo()
        {
            txtIdEquipa.Text = string.Empty;
            txtNome.Text = string.Empty;
            cmbCidade.SelectedIndex = -1;
            cmbConferencia.SelectedIndex = -1;
            cmbIDLiga.SelectedIndex = -1;
        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btmInserir_Click(object sender, EventArgs e)
        {
            
            string idEquipa = txtIdEquipa.Text.Trim();
            string nome = txtNome.Text.Trim();
            string conferencia = cmbConferencia.Text;
            string cidade = cmbCidade.Text;
            object idLigaValue = cmbIDLiga.SelectedValue;

            if (string.IsNullOrEmpty(nome) || idLigaValue == null)
            {
                MessageBox.Show("O Nome e a Liga são campos obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                INSERT INTO Equipas (ID_Equipas, Nome, Conferencia, Cidade, ID_liga)
                VALUES (@ID_Equipas, @Nome, @Conferencia, @Cidade, @ID_liga)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Equipas", idEquipa);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Conferencia", conferencia);
                        cmd.Parameters.AddWithValue("@Cidade", cidade);
                        cmd.Parameters.AddWithValue("@ID_liga", idLigaValue);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipa Adicionada Com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampo();
                            CarregarEquipas();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao inserir Equipa: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir Equipa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            string idEquipaString = txtIdEquipa.Text.Trim();
            object idLigaValue = cmbIDLiga.SelectedValue;

            if (string.IsNullOrEmpty(idEquipaString) || idLigaValue == null)
            {
                MessageBox.Show("Selecione a Equipa (ID) e a Liga para atualizar.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text.Trim();
            string conferencia = cmbConferencia.Text;
            string cidade = cmbCidade.Text;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryUpdate = @"
                UPDATE Equipas SET 
                    Nome = @Nome, 
                    Conferencia = @Conferencia, 
                    Cidade = @Cidade, 
                    ID_liga = @ID_liga
                WHERE ID_Equipas = @ID_Equipas";

                    using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Equipas", idEquipaString);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Conferencia", conferencia);
                        cmd.Parameters.AddWithValue("@Cidade", cidade);
                        cmd.Parameters.AddWithValue("@ID_liga", idLigaValue);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarEquipas();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi atualizado. Verifique o ID da Equipa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao atualizar Equipa: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar Equipa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            string idEquipaString = txtIdEquipa.Text.Trim();

            if (string.IsNullOrEmpty(idEquipaString))
            {
                MessageBox.Show("Selecione uma Equipa (preenchendo o ID) para eliminar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show(
                $"Tem certeza que deseja eliminar a Equipa com ID: {idEquipaString}?",
                "Confirmar Eliminação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryDelete = "DELETE FROM Equipas WHERE ID_Equipas = @ID_Equipas";

                    using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Equipas", idEquipaString);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipa eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampo();
                            CarregarEquipas();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi eliminado. O ID da Equipa pode não existir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao eliminar Equipa (Verifique se há jogadores ou jogos associados): " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao eliminar Equipa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            CarregarEquipas(pesquisa);
        }
    }
}
