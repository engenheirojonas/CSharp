// Importa o namespace do MySQL instalado via NuGet
using MySql.Data.MySqlClient;
using System.Data;


namespace conexao_mysql_01
{
    public partial class Form1 : Form
    {
        // Altere os dados da string de conexão de acordo com o seu servidor MySQL
        private string connectionString = "Server=localhost;Database=bd_cadastroprodutos;Uid=root;Pwd='';";

        public Form1()
        {
            InitializeComponent();
        }

        // Evento executado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        // Método responsável por ler os dados do banco e exibir no DataGridView (READ)
        private void CarregarDados()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, nome, codigo_barras, preco, quantidade, categoria FROM produtos";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvProdutos.DataSource = dt; // Vincula os dados ao componente visual
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que o usuário clicou em uma linha válida e não no cabeçalho
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];

                txtId.Text = row.Cells["id"].Value.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtCodigo.Text = row.Cells["codigo_barras"].Value.ToString();
                txtPreco.Text = row.Cells["preco"].Value.ToString();
                txtQde.Value = Convert.ToInt32(row.Cells["quantidade"].Value);
                cbCategoria.SelectedItem = row.Cells["categoria"].Value.ToString();
            }

        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCodigo.Clear();
            txtPreco.Value = 0;
            txtQde.Value = 0;
            cbCategoria.SelectedIndex = -1; // Remove seleção do ComboBox
            txtNome.Focus(); // Coloca o cursor de volta no campo nome
        }


        // Botão Salvar - Insere um novo produto (CREATE)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação simples de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Por favor, preencha o Nome e o Preço.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Query parametrizada para evitar SQL Injection
                    string query = "INSERT INTO produtos (nome, codigo_barras, preco, quantidade, categoria) " +
                                   "VALUES (@nome, @codigo, @preco, @quantidade, @categoria)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                        cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQde.Value));
                        cmd.Parameters.AddWithValue("@categoria", cbCategoria.SelectedItem?.ToString() ?? "");

                        cmd.ExecuteNonQuery(); // Executa o comando no banco
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                CarregarDados(); // Atualiza a tabela
                LimparCampos();  // Limpa o formulário
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Botão Editar - Atualiza os dados de um produto existente (UPDATE)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um produto na tabela para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE produtos SET nome=@nome, codigo_barras=@codigo, preco=@preco, " +
                                   "quantidade=@quantidade, categoria=@categoria WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                        cmd.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQde.Value));
                        cmd.Parameters.AddWithValue("@categoria", cbCategoria.SelectedItem?.ToString() ?? "");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Botão Excluir - Remove o produto selecionado (DELETE)
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione um produto na tabela para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmação de segurança com o usuário
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM produtos WHERE id=@id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    CarregarDados();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
