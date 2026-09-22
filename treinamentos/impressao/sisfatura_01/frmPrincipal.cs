using MySql.Data.MySqlClient;
using sisfatura_01.conexao;
using System.Data;
using System.Drawing.Printing;

namespace sisfatura_01
{
    public partial class frmPrincipal : Form
    {
        private DataTable dtItens;
        private int idFaturaGerada;

        public frmPrincipal()
        {
            InitializeComponent();
            // Evita executar código que depende de recursos externos em tempo de design
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Runtime)
            {
                ConfigurarTabelaItens();
                CarregarClientes();
                CarregarProdutos();
            }
        }

        private void ConfigurarTabelaItens()
        {
            dtItens = new DataTable();
            dtItens.Columns.Add("ProdutoID", typeof(int));
            dtItens.Columns.Add("Descrição", typeof(string));
            dtItens.Columns.Add("Quantidade", typeof(int));
            dtItens.Columns.Add("Preço Unit.", typeof(decimal));
            dtItens.Columns.Add("Subtotal", typeof(decimal));
            dgvItens.DataSource = dtItens;
        }

        private void CarregarClientes()
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string query = "SELECT id, nome FROM Clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboCliente.DisplayMember = "nome";
                cboCliente.ValueMember = "id";
                cboCliente.DataSource = dt;
            }
        }

        private void CarregarProdutos()
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string query = "SELECT id, descricao FROM produtos";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Preencher o combobox de produtos (usar cboProduto, não cboCliente)
                cboProduto.DisplayMember = "descricao";
                cboProduto.ValueMember = "id";
                cboProduto.DataSource = dt;
            }
        }

        private decimal CalcularTotalFatura()
        {
            decimal total = 0;
            foreach (DataRow row in dtItens.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            lblTotal.Text = $"Total: {total:C2}";
            return total;
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Exemplo de captura de controlos da interface
            int produtoId = Convert.ToInt32(txtProdId.Text);
            string descricao = cboProduto.Text;
            int qtd = Convert.ToInt32(txtQde.Text);
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            decimal subtotal = qtd * preco;

            dtItens.Rows.Add(produtoId, descricao, qtd, preco, subtotal);
            CalcularTotalFatura();
        }

        private void FinalizarVendaNoBanco()
        {
            if (cboCliente.SelectedValue == null || dtItens.Rows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente e adicione itens.");
                return;
            }

            using (var conn = ConexaoBD.ObterConexao())
            {
                using (var transacao = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Inserir a Fatura
                        string queryFatura = "INSERT INTO Faturas (cliente_id, total) VALUES (@clienteId, @total); SELECT LAST_INSERT_ID();";
                        MySqlCommand cmdFatura = new MySqlCommand(queryFatura, conn, transacao);
                        cmdFatura.Parameters.AddWithValue("@clienteId", cboCliente.SelectedValue);
                        cmdFatura.Parameters.AddWithValue("@total", CalcularTotalFatura());

                        idFaturaGerada = Convert.ToInt32(cmdFatura.ExecuteScalar());

                        // 2. Inserir os Itens
                        foreach (DataRow row in dtItens.Rows)
                        {
                            string queryItem = "INSERT INTO Fatura_Itens (fatura_id, produto_id, quantidade, preco_unitario, subtotal) " +
                                               "VALUES (@faturaId, @prodId, @qtd, @preco, @subtotal)";
                            MySqlCommand cmdItem = new MySqlCommand(queryItem, conn, transacao);
                            cmdItem.Parameters.AddWithValue("@faturaId", idFaturaGerada);
                            cmdItem.Parameters.AddWithValue("@prodId", row["ProdutoID"]);
                            cmdItem.Parameters.AddWithValue("@qtd", row["Quantidade"]);
                            cmdItem.Parameters.AddWithValue("@preco", row["Preço Unit."]);
                            cmdItem.Parameters.AddWithValue("@subtotal", row["Subtotal"]);
                            cmdItem.ExecuteNonQuery();
                        }

                        transacao.Commit();
                        MessageBox.Show("Fatura gravada com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        transacao.Rollback();
                        MessageBox.Show("Erro ao gravar fatura: " + ex.Message);
                    }
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarVendaNoBanco();
        }


 //------------------------------------Imprimir com Layout A4-------------------------------------------------
        // Chamada para Impressão A4
        private void btnImprimirA4_Click(object sender, EventArgs e)
        {
            FinalizarVendaNoBanco();

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirLayoutA4);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        // -------------------------------------------------------------
        // LAYOUT DE IMPRESSÃO A4
        // -------------------------------------------------------------
        private void ImprimirLayoutA4(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 18, FontStyle.Bold);
            Font fontSubtitulo = new Font("Arial", 12, FontStyle.Bold);
            Font fontCorpo = new Font("Arial", 10, FontStyle.Regular);
            Font fontNegrito = new Font("Arial", 10, FontStyle.Bold);

            int x = 50; // Margem esquerda
            int y = 50; // Margem superior

            // Cabeçalho da Empresa
            g.DrawString("EMPRESA DEMO LDA", fontTitulo, Brushes.Black, x, y); y += 30;
            g.DrawString("NIF: 500100200 | Tel: 910 000 000", fontCorpo, Brushes.Black, x, y); y += 20;
            g.DrawString("Rua Principal, Nº 123 - Cidade", fontCorpo, Brushes.Black, x, y); y += 40;

            g.DrawLine(Pens.Black, x, y, 750, y); y += 10;

            // Dados da Fatura e Cliente
            g.DrawString($"FATURA Nº: {idFaturaGerada}", fontSubtitulo, Brushes.Black, x, y);
            g.DrawString($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}", fontCorpo, Brushes.Black, 550, y); y += 25;
            g.DrawString($"Cliente: {cboCliente.Text}", fontCorpo, Brushes.Black, x, y); y += 30;

            g.DrawLine(Pens.Black, x, y, 750, y); y += 10;

            // Cabeçalho da Tabela de Itens
            g.DrawString("Descrição", fontNegrito, Brushes.Black, x, y);
            g.DrawString("Qtd", fontNegrito, Brushes.Black, x + 350, y);
            g.DrawString("P. Unit", fontNegrito, Brushes.Black, x + 450, y);
            g.DrawString("Subtotal", fontNegrito, Brushes.Black, x + 600, y);
            y += 20;
            g.DrawLine(Pens.Gray, x, y, 750, y); y += 10;

            // Linhas dos Produtos
            foreach (DataRow row in dtItens.Rows)
            {
                g.DrawString(row["Descrição"].ToString(), fontCorpo, Brushes.Black, x, y);
                g.DrawString(row["Quantidade"].ToString(), fontCorpo, Brushes.Black, x + 350, y);
                g.DrawString(Convert.ToDecimal(row["Preço Unit."]).ToString("C2"), fontCorpo, Brushes.Black, x + 450, y);
                g.DrawString(Convert.ToDecimal(row["Subtotal"]).ToString("C2"), fontCorpo, Brushes.Black, x + 600, y);
                y += 20;
            }

            y += 20;
            g.DrawLine(Pens.Black, x, y, 750, y); y += 10;

            // Totalizador
            g.DrawString($"TOTAL DA FATURA: {CalcularTotalFatura():C2}", fontSubtitulo, Brushes.Black, x + 500, y);
        }


//-------------------------------Imprimir com Layout Térmico (80mm)-------------------------------------------------

        // Chamada para Impressão Térmica (80mm)
        private void btnImprimirTermica_Click(object sender, EventArgs e)
        {
            FinalizarVendaNoBanco();

            PrintDocument pd = new PrintDocument();
            // Define a largura padrão de 80mm (aprox. 315 centésimos de polegada) e altura contínua
            pd.DefaultPageSettings.PaperSize = new PaperSize("Termica80mm", 315, 800);
            pd.PrintPage += new PrintPageEventHandler(ImprimirLayoutTermico);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();

        }

        // -------------------------------------------------------------
        // LAYOUT DE IMPRESSÃO TÉRMICA (Talo/Recibo 80mm)
        // -------------------------------------------------------------
        private void ImprimirLayoutTermico(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Courier New", 12, FontStyle.Bold);
            Font fontCorpo = new Font("Courier New", 9, FontStyle.Regular);
            Font fontNegrito = new Font("Courier New", 9, FontStyle.Bold);

            int x = 10;
            int y = 10;
            int larguraMax = 290; // Área útil aproximada de impressão em 80mm

            // Cabeçalho compactado
            g.DrawString("    EMPRESA DEMO LDA    ", fontTitulo, Brushes.Black, x, y); y += 20;
            g.DrawString("NIF: 500100200 Tel: 910000000", fontCorpo, Brushes.Black, x, y); y += 15;
            g.DrawString(new string('-', 35), fontCorpo, Brushes.Black, x, y); y += 15;

            // Info Fatura
            g.DrawString($"FATURA RECIBO Nº: {idFaturaGerada}", fontNegrito, Brushes.Black, x, y); y += 15;
            g.DrawString($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}", fontCorpo, Brushes.Black, x, y); y += 15;
            g.DrawString($"Cli: {cboCliente.Text}", fontCorpo, Brushes.Black, x, y); y += 20;
            g.DrawString(new string('-', 35), fontCorpo, Brushes.Black, x, y); y += 15;

            // Colunas dos itens
            g.DrawString("Item          Qtd   P.Unit   Total", fontNegrito, Brushes.Black, x, y); y += 15;
            g.DrawString(new string('-', 35), fontCorpo, Brushes.Black, x, y); y += 15;

            // Lista de Produtos
            foreach (DataRow row in dtItens.Rows)
            {
                string desc = row["Descrição"].ToString();
                if (desc.Length > 12) desc = desc.Substring(0, 12); // Trunca texto para não quebrar o layout

                string qtd = row["Quantidade"].ToString();
                string preco = Convert.ToDecimal(row["Preço Unit."]).ToString("N2");
                string sub = Convert.ToDecimal(row["Subtotal"]).ToString("N2");

                // Formatação alinhada por colunas rígidas
                string linha = string.Format("{0,-13} {1,3} {2,8} {3,8}", desc, qtd, preco, sub);
                g.DrawString(linha, fontCorpo, Brushes.Black, x, y);
                y += 15;
            }

            g.DrawString(new string('-', 35), fontCorpo, Brushes.Black, x, y); y += 15;

            // Total
            g.DrawString($"TOTAL: {CalcularTotalFatura():C2}", fontTitulo, Brushes.Black, x + 80, y); y += 30;

            // Rodapé de cortesia
            g.DrawString("  Obrigado pela sua preferência!  ", fontCorpo, Brushes.Black, x, y);
        }

    }
}
