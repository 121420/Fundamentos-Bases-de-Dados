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

        // Dentro da classe FormPessoas
        private void CarregarPessoas(string nomePesquisa = "")
        {
            DataTable DT = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 1. Constrói a query base
                    string query = "SELECT CC ,Nome,data_nascimento,Nacionalidade,Genero,Telefone,Email FROM Pessoas";

                    // 2. Adiciona a cláusula WHERE se houver texto de pesquisa
                    if (!string.IsNullOrEmpty(nomePesquisa))
                    {
                        // Usamos LIKE e % para permitir a pesquisa por parte do nome
                        // Usamos @NomeParam para segurança (parâmetros SQL)
                        query += " WHERE Nome LIKE @NomeParam";
                    }

                    // Opcional: Adicionar ORDER BY para melhor visualização
                    query += " ORDER BY Nome";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 3. Adiciona o parâmetro SQL, se necessário
                        if (!string.IsNullOrEmpty(nomePesquisa))
                        {
                            // Adiciona os caracteres curinga % para pesquisar qualquer parte do nome
                            cmd.Parameters.AddWithValue("@NomeParam", "%" + nomePesquisa + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(DT);

                        listaPessoas.DataSource = DT;
                    }
                }
            }
            catch (Exception error)
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


        /***Botoes***/
        private void LimparCampos()
        {
            txtCC.Text = string.Empty;
            txtNome.Text = string.Empty;
            mskData.Text = string.Empty; // Limpa o MaskedTextBox
            txtNacionalidade.Text = string.Empty;
            cmbGenero.SelectedIndex = -1;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtPesquisa.Text = string.Empty;

            // Essencial para o modo "Inserir": permite que o usuário digite um novo CC
            txtCC.Enabled = true;

            // Desselecionar a linha na DataGridView (para indicar que não está em modo de edição)
            listaPessoas.ClearSelection();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btmInserir_Click(object sender, EventArgs e)
        {
            // 1. Validação dos dados
            string cc = txtCC.Text.Trim();
            string nome = txtNome.Text.Trim();
            string dataNascString = mskData.Text.Replace("/", "").Trim(); // Remove barras
            string nacionalidade = txtNacionalidade.Text.Trim();
            string genero = cmbGenero.Text;
            string email = txtEmail.Text.Trim();
            string telefone = txtTelefone.Text.Trim();

            // Validação básica
            if (string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios (CC, Nome, Género).", "Dados Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentativa de converter a data para DateTime (pode ser null)
            DateTime? dataNasc = null;
            if (dataNascString.Length == 8 && DateTime.TryParse(dataNascString.Insert(4, "/").Insert(7, "/"), out DateTime tempDate))
            {
                dataNasc = tempDate;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryInserir = "INSERT INTO Pessoas (CC, Nome, data_nascimento, Nacionalidade, Genero, Telefone, Email) VALUES (@CC, @Nome, @data_nascimento, @Nacionalidade, @Genero, @Telefone, @Email)";

                    using (SqlCommand cmd = new SqlCommand(queryInserir, con))
                    {
                        cmd.Parameters.AddWithValue("@CC", cc);
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        // Tratamento de Data Nasc. como DBNull.Value se for inválida/vazia
                        cmd.Parameters.AddWithValue("@data_nascimento", (object)dataNasc ?? DBNull.Value);

                        // Campos opcionais/texto que podem ser null ou vazios
                        cmd.Parameters.AddWithValue("@Nacionalidade", string.IsNullOrEmpty(nacionalidade) ? (object)DBNull.Value : nacionalidade);
                        cmd.Parameters.AddWithValue("@Genero", genero); // Género é obrigatório pela validação acima
                        cmd.Parameters.AddWithValue("@Telefone", string.IsNullOrEmpty(telefone) ? (object)DBNull.Value : telefone);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pessoa inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarPessoas();
                            LimparCampos();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL (CC duplicado ou formato inválido): " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir Pessoa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            string cc = txtCC.Text.Trim();

            // 1. Validação: Deve haver um CC existente e o campo CC deve estar desabilitado
            if (string.IsNullOrEmpty(cc) || txtCC.Enabled == true)
            {
                MessageBox.Show("Por favor, selecione uma pessoa na lista para atualizar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obter os dados atualizados
            string nome = txtNome.Text.Trim();
            string dataNascString = mskData.Text.Replace("/", "").Trim();
            string nacionalidade = txtNacionalidade.Text.Trim();
            string genero = cmbGenero.Text;
            string email = txtEmail.Text.Trim();
            string telefone = txtTelefone.Text.Trim();

            // Validação mínima
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Nome e Género não podem estar vazios.", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentativa de converter a data para DateTime
            DateTime? dataNasc = null;
            if (dataNascString.Length == 8 && DateTime.TryParse(dataNascString.Insert(4, "/").Insert(7, "/"), out DateTime tempDate))
            {
                dataNasc = tempDate;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string queryAtualizar = "UPDATE Pessoas SET Nome = @Nome, data_nascimento = @data_nascimento, Nacionalidade = @Nacionalidade, Genero = @Genero, Telefone = @Telefone, Email = @Email WHERE CC = @CC";

                    using (SqlCommand cmd = new SqlCommand(queryAtualizar, con))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@data_nascimento", (object)dataNasc ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nacionalidade", string.IsNullOrEmpty(nacionalidade) ? (object)DBNull.Value : nacionalidade);
                        cmd.Parameters.AddWithValue("@Genero", genero);
                        cmd.Parameters.AddWithValue("@Telefone", string.IsNullOrEmpty(telefone) ? (object)DBNull.Value : telefone);
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);

                        // Chave primária para a cláusula WHERE
                        cmd.Parameters.AddWithValue("@CC", cc);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pessoa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarPessoas();
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi atualizado. O CC pode não existir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar Pessoa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            string cc = txtCC.Text.Trim();

            // 1. Validação: Deve haver um CC existente e o campo CC deve estar desabilitado
            if (string.IsNullOrEmpty(cc) || txtCC.Enabled == true)
            {
                MessageBox.Show("Por favor, selecione uma pessoa na lista para eliminar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmação
            DialogResult result = MessageBox.Show($"Tem certeza que deseja eliminar a pessoa com CC: {cc}? Esta ação é irreversível.", "Confirmar Eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string queryEliminar = "DELETE FROM Pessoas WHERE CC = @CC";

                        using (SqlCommand cmd = new SqlCommand(queryEliminar, con))
                        {
                            cmd.Parameters.AddWithValue("@CC", cc);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Pessoa eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarPessoas();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registo foi eliminado. O CC pode não existir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Trata o erro de chave estrangeira (se a pessoa estiver ligada a Jogadores ou Treinadores)
                    MessageBox.Show("Erro SQL: Não pode eliminar esta pessoa porque está ligada a registos em Jogadores ou Treinadores. Primeiro remova essas associações.", "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao eliminar Pessoa: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarPessoas(txtPesquisa.Text);
        }
    }
}
