using MySql.Data.MySqlClient;
using processar_salarios_01.DAO;

//crud

namespace conexao_mysql_01
{
    public partial class Form1 : Form
    {
        private readonly FuncionarioDAO dao = new FuncionarioDAO();
        public Form1()
        {
            InitializeComponent();
            AtualizarGrade();
        }

        // Atualiza o DataGridView com os dados do MySQL
        private void AtualizarGrade()
        {
            try
            {
                dgvFuncionarios.DataSource = dao.ListarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpa os campos de texto do formulário
        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtCargo.Clear();
            txtDepartamento.Clear();
            txtSalarioBruto.Clear();
            txtBonus.Clear();
            txtNome.Focus();
        }

        // Evento do botão Salvar (CREATE)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtSalarioBruto.Text))
                {
                    MessageBox.Show("Preencha obrigatoriamente Nome e Salário Bruto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal bruto = Convert.ToDecimal(txtSalarioBruto.Text);
                decimal bonus = string.IsNullOrEmpty(txtBonus.Text) ? 0 : Convert.ToDecimal(txtBonus.Text);

                if (dao.Inserir(txtNome.Text, txtCargo.Text, txtDepartamento.Text, bruto, bonus))
                {
                    MessageBox.Show("Folha de pagamento processada e salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrade();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de validação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Selecione um funcionário na tabela abaixo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(txtID.Text);
                decimal bruto = Convert.ToDecimal(txtSalarioBruto.Text);
                decimal bonus = Convert.ToDecimal(txtBonus.Text);

                if (dao.Atualizar(id, txtNome.Text, txtCargo.Text, txtDepartamento.Text, bruto, bonus))
                {
                    MessageBox.Show("Dados do funcionário atualizados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrade();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Selecione um funcionário na tabela para o excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    if (dao.Excluir(id))
                    {
                        MessageBox.Show("Registo removido do sistema.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrade();
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow linha = dgvFuncionarios.Rows[e.RowIndex];
                    txtID.Text = linha.Cells["ID"].Value.ToString();
                    txtNome.Text = linha.Cells["Nome"].Value.ToString();
                    txtCargo.Text = linha.Cells["Cargo"].Value.ToString();
                    txtDepartamento.Text = linha.Cells["Departamento"].Value.ToString();
                    txtSalarioBruto.Text = linha.Cells["Salário Bruto"].Value.ToString();
                    txtBonus.Text = linha.Cells["Bónus"].Value.ToString();
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
