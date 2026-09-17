using gestao_stock_02.dao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gestao_stock_02
{
    public partial class frmMovimentacao : Form
    {
        private MovimentacaoDAO movDAO = new MovimentacaoDAO();
        private ConexaoBD bd = new ConexaoBD();

        public frmMovimentacao()
        {
            InitializeComponent();
        }

        private void CarregarProdutos()
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT id, nome FROM Produtos";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProdutos.DataSource = dt;
                cmbProdutos.DisplayMember = "nome";
                cmbProdutos.ValueMember = "id";
            }
        }

        private void AtualizarHistorico()
        {
            dgvHistorico.DataSource = movDAO.ListarHistorico();
        }

        // Verifica de forma silenciosa se existem produtos com falha de stock para alertar o utilizador
        private void VerificarAlertasCriticos()
        {
            DataTable dtAlertas = movDAO.ListarStockBaixo();
            if (dtAlertas.Rows.Count > 0)
            {
                btnVerAlertas.BackColor = Color.LightCoral;
                btnVerAlertas.Text = $"⚠️ Stock Baixo ({dtAlertas.Rows.Count})";
            }
            else
            {
                btnVerAlertas.BackColor = Color.LightGreen;
                btnVerAlertas.Text = "Stock Seguro ✅";
            }
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            AtualizarHistorico();
            VerificarAlertasCriticos();
        }

        private int ObterStockAtual(int produtoId)
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT quantidade_atual FROM Produtos WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", produtoId);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbProdutos.SelectedValue == null || cmbTipo.SelectedItem == null || string.IsNullOrEmpty(txtQuantidade.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int produtoId = Convert.ToInt32(cmbProdutos.SelectedValue);
                string tipo = cmbTipo.SelectedItem.ToString();
                int qtd = Convert.ToInt32(txtQuantidade.Text);
                string motivo = txtMotivo.Text;

                // Validação para não deixar o stock ficar negativo na saída
                if (tipo == "SAÍDA")
                {
                    int stockAtual = ObterStockAtual(produtoId);
                    if (stockAtual < qtd)
                    {
                        MessageBox.Show($"Operação cancelada. Stock insuficiente! Stock atual: {stockAtual}", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (movDAO.RegistrarMovimentacao(produtoId, tipo, qtd, motivo))
                {
                    MessageBox.Show("Movimentação registada e stock atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantidade.Clear();
                    txtMotivo.Clear();
                    AtualizarHistorico();
                    VerificarAlertasCriticos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao movimentar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVerAlertas_Click(object sender, EventArgs e)
        {
            DataTable dt = movDAO.ListarStockBaixo();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Todos os produtos estão com níveis de stock seguros.", "Nenhum Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string lista = "Produtos que atingiram o limite mínimo:\n\n";
            foreach (DataRow row in dt.Rows)
            {
                lista += $"- {row["nome"]} (Qtd Atual: {row["quantidade_atual"]} | Mínimo: {row["quantidade_minima"]})\n";
            }

            MessageBox.Show(lista, "Aviso de Stock Baixo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.Show();
            this.Visible = false;
        }
    }
}
