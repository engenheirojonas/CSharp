using MySql.Data.MySqlClient;
using System.Data;

namespace conexao_mysql_01
{
    public partial class FormProdutos : Form
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private ConexaoBD bd = new ConexaoBD();

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            AtualizarGrade();
        }

        // Carrega as Categorias e Fornecedores nas ComboBoxes
        private void CarregarCombos()
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                conn.Open();

                // Categorias
                MySqlDataAdapter daCat = new MySqlDataAdapter("SELECT id, nome FROM Categorias", conn);
                DataTable dtCat = new DataTable();
                daCat.Fill(dtCat);
                cmbCategoria.DataSource = dtCat;
                cmbCategoria.DisplayMember = "nome";
                cmbCategoria.ValueMember = "id";

                // Fornecedores
                MySqlDataAdapter daForn = new MySqlDataAdapter("SELECT id, nome FROM Fornecedores", conn);
                DataTable dtForn = new DataTable();
                daForn.Fill(dtForn);
                cmbFornecedor.DataSource = dtForn;
                cmbFornecedor.DisplayMember = "nome";
                cmbFornecedor.ValueMember = "id";
            }
        }

        private void AtualizarGrade()
        {
            dgvProdutos.DataSource = produtoDAO.ListarTodos();
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtCodigo.Clear();
            txtNome.Clear();
            txtPrecoCompra.Clear();
            txtPrecoVenda.Clear();
            txtQuantidade.Text = "0";
            txtQtdMinima.Text = "5";
            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
            if (cmbFornecedor.Items.Count > 0) cmbFornecedor.SelectedIndex = 0;
        }


        // Evento do botão Salvar (CREATE)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool sucesso = produtoDAO.Inserir(
                    txtCodigo.Text,
                    txtNome.Text,
                    Convert.ToDecimal(txtPrecoCompra.Text),
                    Convert.ToDecimal(txtPrecoVenda.Text),
                    Convert.ToInt32(txtQuantidade.Text),
                    Convert.ToInt32(txtQtdMinima.Text),
                    Convert.ToInt32(cmbCategoria.SelectedValue),
                    Convert.ToInt32(cmbFornecedor.SelectedValue)
                );

                if (sucesso)
                {
                    MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrade();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Evento do botão EDITAR (Atualizar)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Selecione um produto na lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool sucesso = produtoDAO.Atualizar(
                    Convert.ToInt32(txtID.Text),
                    txtCodigo.Text,
                    txtNome.Text,
                    Convert.ToDecimal(txtPrecoCompra.Text),
                    Convert.ToDecimal(txtPrecoVenda.Text),
                    Convert.ToInt32(txtQuantidade.Text),
                    Convert.ToInt32(txtQtdMinima.Text),
                    Convert.ToInt32(cmbCategoria.SelectedValue),
                    Convert.ToInt32(cmbFornecedor.SelectedValue)
                );

                if (sucesso)
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrade();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento do botão ELIMINAR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Selecione um produto na lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Tem a certeza que deseja eliminar este produto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (produtoDAO.Eliminar(Convert.ToInt32(txtID.Text)))
                {
                    MessageBox.Show("Produto eliminado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrade();
                    LimparCampos();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Clique na linha do DataGridView preenche os campos do formulário
        private void dgvProdutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvProdutos.Rows[e.RowIndex];
                txtID.Text = linha.Cells["id"].Value.ToString();
                txtCodigo.Text = linha.Cells["codigo_barras"].Value.ToString();
                txtNome.Text = linha.Cells["nome"].Value.ToString();
                txtPrecoCompra.Text = linha.Cells["preco_compra"].Value.ToString();
                txtPrecoVenda.Text = linha.Cells["preco_venda"].Value.ToString();
                txtQuantidade.Text = linha.Cells["quantidade_atual"].Value.ToString();
                txtQtdMinima.Text = linha.Cells["quantidade_minima"].Value.ToString();

                cmbCategoria.Text = linha.Cells["Categoria"].Value.ToString();
                cmbFornecedor.Text = linha.Cells["Fornecedor"].Value.ToString();
            }

        }
    }
}
