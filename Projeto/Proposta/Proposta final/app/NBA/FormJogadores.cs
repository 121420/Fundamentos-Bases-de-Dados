using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private string ObterCCSelecionado()
        {
            // O campo CC é a chave primária/identificador que vamos usar para operações
            string cc = txtCC.Text.Trim();
            if (string.IsNullOrEmpty(cc) || cc.Length < 8) // Assumindo CC tem um tamanho mínimo
            {
                MessageBox.Show("Por favor, selecione um jogador na lista ou insira um CC válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return cc;
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
            txtID.Enabled = false;



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

                            
                            cmbID_Equipa.DisplayMember = "Nome";
                            cmbID_Equipa.ValueMember = "ID_Equipas";

                    
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

        private void CarregarJogadores(string nomePesquisa = "")
        {
            DataTable jogadoresDT = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string queryJogadores = "SELECT * from Jogadores";

                    if (!string.IsNullOrEmpty(nomePesquisa))
                    {
                        // Adiciona a cláusula WHERE para filtrar pelo Nome_camisola
                        queryJogadores += " WHERE Nome_camisola LIKE @NomeParam";
                    }

                    queryJogadores += " ORDER BY Nome_camisola"; // Ordenar para melhor visualização

                    using (SqlCommand cmd = new SqlCommand(queryJogadores, con))
                    {
                        if (!string.IsNullOrEmpty(nomePesquisa))
                        {
                            // Adiciona o parâmetro SQL para a pesquisa LIKE
                            cmd.Parameters.AddWithValue("@NomeParam", "%" + nomePesquisa + "%");
                        }

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
        private void listajogadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listajogadores_SelectionChanged(object sender, EventArgs e)
        {
            if (listajogadores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = listajogadores.SelectedRows[0];

                txtID.Text = selectedRow.Cells["ID_Jogador"].Value.ToString();
                txtCC.Text = selectedRow.Cells["CC"].Value.ToString();
                txtCC.Enabled = false;

                //ID_Equpas
                object equipaID = selectedRow.Cells["ID_Equipa"].Value;
                if (equipaID != null && equipaID != DBNull.Value)
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


                string chaveImagem = selectedRow.Cells["CC"].Value.ToString();

               

                ResourceManager rm = new ResourceManager("NBA.Properties.Resources", typeof(FormJogadores).Assembly);

                Image imagemDoRecurso = (Image)rm.GetObject(chaveImagem);

                if (imagemDoRecurso != null)
                {
                    // O recurso foi encontrado
                    pbFotoJogador.Image = imagemDoRecurso;
                }
                else
                {
                    pbFotoJogador.Image = Properties.Resources.foto_padrao;

                
                }


                //Conttratos
                DataTable dtContrato = new DataTable();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string idJogador = selectedRow.Cells["ID_Jogador"].Value.ToString();
                    con.Open();
                    string queryContrato = "Select C.ID_contrato,E.Nome,C.data_inicio,C.data_Fim,C.Salario_Total,C.clausula_rescisao From Contrato C" +
                        "   Join Contrato_Jogador CJ ON C.ID_contrato = CJ.ID_contrato" +
                        "   Join Jogadores J ON J.ID_Jogador = CJ.ID_jogador " +
                        "   Join Equipas E ON E.ID_Equipas = CJ.ID_equipa " +
                        "   Where J.ID_Jogador = @ID_jogador";

                    using(SqlCommand cmd = new SqlCommand(queryContrato,con))
                    {
                        object resultado = cmd.Parameters.AddWithValue("@ID_jogador", idJogador);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtContrato);
                        }

                        ContratoJogador.DataSource = dtContrato;
                    }
                }


                //Estatisticas
                DataTable dtEstatisticas = new DataTable();
                string idJogadorEs = selectedRow.Cells["ID_Jogador"].Value.ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string querryEstatisticas = "SELECT SUM(minutos) AS TotaMinutos, SUM(pontos) AS TotalPontos, SUM(assistencias) AS TotalAssisstencia, SUM(ressaltos) AS TotalRessaltos, SUM(roubos) AS TotalRoubos,SUM(blocos) AS TotalBlocos, SUM(Faltas) AS TotalFaltas" +
                        " FROM Estatistica_Jogador_Jogo" +
                        " WHERE ID_jogador = @ID_jogador " +
                        "GROUP BY ID_jogador";

                    using(SqlCommand cmd = new SqlCommand(querryEstatisticas,con))
                    {
                        object EstatisticasDoJogadorSelecionado = cmd.Parameters.AddWithValue("@ID_jogador", idJogadorEs);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtEstatisticas);
                        }

                        Estatistica.DataSource = dtEstatisticas;
                    }
                }
            }
            else
            {
                pbFotoJogador.Image = null;
            }




        }
        

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            string cc = ObterCCSelecionado();
            if (cc == null) return;

            // 1. Obter os dados atualizados do formulário
            string nomeCamisola = txtNomeCamisola.Text.Trim();
            string posicao = cmbPosicao.Text;
            string maoDominante = cmbMaoDominante.Text;

            // Tratamento de valores que podem ser null ou que precisam de conversão
            object idEquipa = cmbID_Equipa.SelectedValue;

            // Converter altura e peso aceitando ponto ou vírgula
            string alturaTexto = txtAltura.Text.Replace('.', ',');
            string pesoTexto = txtPeso.Text.Replace('.', ',');

            float altura, peso;
            int numero;

            if (!float.TryParse(alturaTexto, out altura) ||
                !float.TryParse(pesoTexto, out peso) ||
                !int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Altura, peso ou número estão inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // A query usa a cláusula WHERE para garantir que apenas o jogador com o @CC seja atualizado.
                    string queryAtualizar = "UPDATE Jogadores SET ID_Equipa = @ID_Equipa, Nome_camisola = @Nome_camisola, Posicao = @Posicao, Altura = @Altura, Peso = @Peso, Numero = @Numero, Mao_Dominante = @Mao_Dominante WHERE CC = @CC";

                    using (SqlCommand cmd = new SqlCommand(queryAtualizar, con))
                    {
                        // Verifica se uma equipa foi selecionada
                        if (idEquipa != null && idEquipa != DBNull.Value)
                        {
                            cmd.Parameters.AddWithValue("@ID_Equipa", idEquipa);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ID_Equipa", DBNull.Value); // Permite definir ID_Equipa como NULL
                        }

                        cmd.Parameters.AddWithValue("@Nome_camisola", nomeCamisola);
                        cmd.Parameters.AddWithValue("@Posicao", posicao);
                        cmd.Parameters.AddWithValue("@Altura", altura);
                        cmd.Parameters.AddWithValue("@Peso", peso);
                        cmd.Parameters.AddWithValue("@Numero", numero);
                        cmd.Parameters.AddWithValue("@Mao_Dominante", maoDominante);
                        cmd.Parameters.AddWithValue("@CC", cc);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Jogador atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarJogadores(); // Recarrega a lista
                            LimparCampos(); // Limpa os campos após a atualização
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi atualizado. O jogador pode não existir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar jogador: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            string cc = ObterCCSelecionado();
            if (cc == null) return;

            // Confirmação para evitar exclusões acidentais
            DialogResult result = MessageBox.Show($"Tem certeza que deseja eliminar o jogador com CC: {cc}? Esta ação é irreversível.", "Confirmar Eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        // A query usa a cláusula WHERE para garantir que apenas o jogador com o @CC seja eliminado.
                        string queryEliminar = "DELETE FROM Jogadores WHERE CC = @CC";

                        using (SqlCommand cmd = new SqlCommand(queryEliminar, con))
                        {
                            cmd.Parameters.AddWithValue("@CC", cc);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Jogador eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarJogadores(); // Recarrega a lista
                                LimparCampos(); // Limpa os campos após a eliminação
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registo foi eliminado. O jogador pode não existir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Se houver restrições de chave estrangeira, o jogador pode estar associado a outros dados (ex: estatísticas).
                    MessageBox.Show("Erro SQL ao eliminar jogador. Certifique-se de que não existem dados relacionados: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao eliminar jogador: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarJogadores(txtPesquisa.Text);
        }
        private void LimparCampos()
        {
            txtID.Enabled = false;
            txtID.Text = string.Empty;
            txtCC.Text = string.Empty;
            txtCC.Enabled = true; // Habilita o campo CC para nova inserção
            txtNomeCamisola.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtNumero.Text = string.Empty;
            cmbMaoDominante.SelectedIndex = -1;
            cmbPosicao.SelectedIndex = -1;
            cmbID_Equipa.SelectedIndex = -1;

            // Desselecionar qualquer linha na DataGridView
            listajogadores.ClearSelection();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private int ObterProximoID()
        {
            int proximoID = 1; 

            try
            {
               
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    
                    string queryMaxID = "SELECT MAX(ID_Jogador) FROM Jogadores";

                    using (SqlCommand cmd = new SqlCommand(queryMaxID, con))
                    {
                        
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            
                            proximoID = Convert.ToInt32(resultado) + 1;
                        }
                       
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao obter o próximo ID: " + erro.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Retornar 0 em caso de erro grave para evitar inserções inválidas
                return 0;
            }
            return proximoID;
        }
    
        private void btmInserir_Click(object sender, EventArgs e)
        {

            // --- 1. Geração do ID e Obtenção de Dados ---
            int idJogador = ObterProximoID();

            // Se a obtenção do ID falhar (retorna 0), cancela a operação
            if (idJogador == 0)
            {
                return;
            }

            string cc = txtCC.Text.Trim();
            
            string nomeCamisola = txtNomeCamisola.Text.Trim();
            string posicao = cmbPosicao.Text;
            string maoDominante = cmbMaoDominante.Text;
            object idEquipa = cmbID_Equipa.SelectedValue;

            
            string alturaString = txtAltura.Text.Trim().Replace(',', '.');
            string pesoString = txtPeso.Text.Trim().Replace(',', '.');

            float altura, peso;
            int numero;

            // --- 3. Validação Completa ---
            if (string.IsNullOrEmpty(cc) || string.IsNullOrEmpty(nomeCamisola) || string.IsNullOrEmpty(posicao) || string.IsNullOrEmpty(maoDominante) ||
               
                !float.TryParse(alturaString, NumberStyles.Float, CultureInfo.InvariantCulture, out altura) ||
                !float.TryParse(pesoString, NumberStyles.Float, CultureInfo.InvariantCulture, out peso) ||
                !int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios e verifique se Altura e Peso estão no formato numérico correto (ponto ou vírgula).", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            // --- 4. Inserção no Banco de Dados ---
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // ID_Jogador foi adicionado à query
                    string queryInserir = "INSERT INTO Jogadores (ID_Jogador, CC, ID_Equipa, Nome_camisola, Posicao, Altura, Peso, Numero, Mao_Dominante) VALUES (@ID_Jogador, @CC, @ID_Equipa, @Nome_camisola, @Posicao, @Altura, @Peso, @Numero, @Mao_Dominante)";

                    using (SqlCommand cmd = new SqlCommand(queryInserir, con))
                    {
                        // O ID agora vem do método ObterProximoID()
                        cmd.Parameters.AddWithValue("@ID_Jogador", idJogador);

                        cmd.Parameters.AddWithValue("@CC", cc);

                        // Tratamento de ID_Equipa (pode ser NULL) - Correção da captura
                        if (idEquipa != null && idEquipa != DBNull.Value)
                        {
                            cmd.Parameters.AddWithValue("@ID_Equipa", idEquipa);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ID_Equipa", DBNull.Value); // Insere NULL se não houver equipa
                        }

                        // Adicionar outros parâmetros
                        cmd.Parameters.AddWithValue("@Nome_camisola", nomeCamisola);
                        cmd.Parameters.AddWithValue("@Posicao", posicao);
                        cmd.Parameters.AddWithValue("@Altura", altura); // O valor float será passado corretamente
                        cmd.Parameters.AddWithValue("@Peso", peso);
                        cmd.Parameters.AddWithValue("@Numero", numero);
                        cmd.Parameters.AddWithValue("@Mao_Dominante", maoDominante);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Feedback
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Jogador inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarJogadores();
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registo foi inserido. Verifique os dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro SQL ao inserir jogador: " + ex.Message, "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir jogador: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMaoDominante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Contrato_Click(object sender, EventArgs e)
        {

        }
    }
}
