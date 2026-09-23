using MySql.Data.MySqlClient;
using sisfatura_03.conexao;
using System.Data;
using System.IO;
using System.Drawing.Printing;

namespace sisfatura_03
{
    public partial class frmPrincipal : Form
    {
        private DataTable dtItens;

        //-------------------------------------------------------------------------------------------//

        // Variável global para controlar a paginação do A4
        private int indexItemAtual = 0;
        private int idFaturaGerada = 1024; // Exemplo de ID


        // Caminho do logótipo (Pode ser alterado para uma propriedade ou campo de configuração)
        private string caminhoLogo = Path.Combine(Application.StartupPath, "lorem.png");

        //--------------------------------------------------------------------------------------------------//

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
            if (txtProdId.Text == "" || txtQde.Text == "" || txtPreco.Text == "" || cboProduto.SelectedValue == null)
            {
                MessageBox.Show("Preencha produtos na sua carrinha de compra.");
            }
            else
            {
                // Exemplo de captura de controlos da interface
                int produtoId = Convert.ToInt32(txtProdId.Text);
                string descricao = cboProduto.Text;
                int qtd = Convert.ToInt32(txtQde.Text);
                decimal preco = Convert.ToDecimal(txtPreco.Text);
                decimal subtotal = qtd * preco;

                dtItens.Rows.Add(produtoId, descricao, qtd, preco, subtotal);
                CalcularTotalFatura();

                Limpar();
            }
        }

        private void Limpar()
        {
            txtProdId.Clear();
            cboCliente.SelectedIndex = -1;
            cboProduto.SelectedIndex = -1;
            txtQde.Clear();
            txtPreco.Clear();

            txtProdId.Focus();
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

        //------------------------------------Imprimir com Layout A4-------------------------------------------------
        // Chamada para Impressão A4
        private void btnImprimirA4_Click(object sender, EventArgs e)
        {
            FinalizarVendaNoBanco();

            // IMPORTANTE: Reiniciar o índice antes de começar a imprimir
            indexItemAtual = 0;

            PrintDocument pd = new PrintDocument();

            // !!! ESTA É A LINHA CRUCIAL QUE FALTA !!!
            // Garante que o índice volta a 0 sempre que a impressão (ou PDF) é iniciada
            pd.BeginPrint += (s, ea) => { indexItemAtual = 0; };

            pd.PrintPage += new PrintPageEventHandler(ImprimirLayoutA4Multipagina);

            // O seu código para escolher a impressora PDF e imprimir...
            // pd.Print();

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }


        // -----------------------------------------------------------------
        // LAYOUT A4 - SUPORTE A MÚLTIPLAS PÁGINAS E LOGÓTIPO
        // -----------------------------------------------------------------
        private void ImprimirLayoutA4Multipagina(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial", 18, FontStyle.Bold);
            Font fontSubtitulo = new Font("Arial", 12, FontStyle.Bold);
            Font fontCorpo = new Font("Arial", 10, FontStyle.Regular);
            Font fontNegrito = new Font("Arial", 10, FontStyle.Bold);

            int x = 50;
            int y = 50;
            int limiteInferior = 1050; // Limite vertical seguro da folha A4 antes de quebrar a página

            // 1. DESENHAR LOGÓTIPO (Se existir o ficheiro)
            if (System.IO.File.Exists(caminhoLogo))
            {
                try
                {
                    // Evita bloquear o arquivo: carregar via stream
                    using (var fs = new FileStream(caminhoLogo, FileMode.Open, FileAccess.Read))
                    using (var logo = Image.FromStream(fs))
                    {
                        // Desenha o logótipo no canto superior esquerdo com tamanho 150x60 pixels
                        g.DrawImage(logo, x, y, 150, 60);
                    }
                    y += 75; // Ajusta o Y para não sobrepor o texto se a imagem foi desenhada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem do logotipo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    y += 30; // Ajuste mínimo em caso de erro para o texto não ficar colado ao topo
                }
            }
            else
            {
                // AVISO DE DIAGNÓSTICO: Mostra-lhe exatamente onde o programa está à procura da imagem.
                // Pode remover ou comentar esta linha 'MessageBox' assim que o problema estiver resolvido.
                MessageBox.Show($"O ficheiro do logótipo não foi encontrado!\n\nColoque a imagem 'lorem.png' nesta pasta:\n{caminhoLogo}", "Imagem Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                y += 30; // Ajuste mínimo para o cabeçalho começar bem mesmo sem imagem
            }

            // 2. CABEÇALHO DA EMPRESA
            g.DrawString("EMPRESA DEMO LDA", fontTitulo, Brushes.Black, x, y); y += 30;
            g.DrawString("NIF: 500100200 | Tel: 910 000 000", fontCorpo, Brushes.Black, x, y); y += 20;
            g.DrawString("Rua Principal, Nº 123 - Cidade", fontCorpo, Brushes.Black, x, y); y += 35;

            g.DrawLine(Pens.Black, x, y, 750, y); y += 10;

            // 3. DADOS DA FATURA E CLIENTE
            g.DrawString($"FATURA Nº: {idFaturaGerada}", fontSubtitulo, Brushes.Black, x, y);
            g.DrawString($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}", fontCorpo, Brushes.Black, 550, y); y += 25;
            g.DrawString($"Cliente: {cboCliente.Text}", fontCorpo, Brushes.Black, x, y); y += 30;

            g.DrawLine(Pens.Black, x, y, 750, y); y += 10;

            // 4. CABEÇALHO DA TABELA
            g.DrawString("Descrição", fontNegrito, Brushes.Black, x, y);
            g.DrawString("Qtd", fontNegrito, Brushes.Black, x + 350, y);
            g.DrawString("P. Unit", fontNegrito, Brushes.Black, x + 450, y);
            g.DrawString("Subtotal", fontNegrito, Brushes.Black, x + 600, y);
            y += 20;
            g.DrawLine(Pens.Gray, x, y, 750, y); y += 10;

            // 5. CICLO DE ITENS COM CONTROLO DE PAGINAÇÃO
            bool temMaisPaginas = false;

            while (indexItemAtual < dtItens.Rows.Count)
            {
                // Verifica se o Y ultrapassou o limite seguro da página atual
                if (y > limiteInferior)
                {
                    temMaisPaginas = true;
                    break; // Sai do ciclo para forçar a criação de uma nova folha
                }

                DataRow row = dtItens.Rows[indexItemAtual];

                g.DrawString(row["Descrição"].ToString(), fontCorpo, Brushes.Black, x, y);
                g.DrawString(row["Quantidade"].ToString(), fontCorpo, Brushes.Black, x + 350, y);
                g.DrawString(Convert.ToDecimal(row["Preço Unit."]).ToString("C2"), fontCorpo, Brushes.Black, x + 450, y);
                g.DrawString(Convert.ToDecimal(row["Subtotal"]).ToString("C2"), fontCorpo, Brushes.Black, x + 600, y);

                y += 25; // Avança a linha
                indexItemAtual++; // Incrementa para o próximo produto na próxima iteração/página
            }

            // 6. FINALIZAÇÃO DA PÁGINA
            if (temMaisPaginas)
            {
                // Se existirem mais itens, avisa o motor de impressão para abrir uma nova folha em branco
                e.HasMorePages = true;
            }
            else
            {
                // Se for a última página, imprime o totalizador final
                e.HasMorePages = false;

                // Repõe o índice a zero porque a impressão desta fatura terminou com sucesso
                indexItemAtual = 0;

                y += 20;
                g.DrawLine(Pens.Black, x, y, 750, y); y += 10;
                g.DrawString($"TOTAL DA FATURA: {CalcularTotalFatura():C2}", fontSubtitulo, Brushes.Black, x + 500, y);
            }
        }




        //-------------------------------Imprimir com Layout Térmico (80mm)-------------------------------------------------

        // Antes de chamar o Print(), calcula-se a altura ideal somando
        // o cabeçalho, o rodapé e o número de itens multiplicado pelo
        // espaço que cada um ocupa:
        private void GerarPdfTermico(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();

            // 1. Definir a largura padrão de 80mm (aprox. 315 centésimos de polegada)
            int larguraTalon = 315;

            // 2. Calcular a altura dinâmica baseada no número de itens
            int alturaCabecalho = 200;
            int alturaRodape = 150;
            int alturaPorItem = 25; // Espaço vertical que cada linha consome

            int alturaTotalNecessaria = alturaCabecalho + (dtItens.Rows.Count * alturaPorItem) + alturaRodape;

            // 3. Aplicar o tamanho personalizado ao documento (Evita cortes no PDF)
            pd.DefaultPageSettings.PaperSize = new PaperSize("CustomTermico", larguraTalon, alturaTotalNecessaria);

            // Garantir que o índice começa do zero
            indexItemAtual = 0;

            pd.PrintPage += new PrintPageEventHandler(ImprimirLayoutTermicoDinamico);

            // Código para salvar/imprimir em PDF aqui...
            // pd.Print();
        }



        // Chamada para Impressão Térmica (80mm)
        private void btnImprimirTermica_Click(object sender, EventArgs e)
        {
            FinalizarVendaNoBanco();

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Termica80mm", 315, 800);
            pd.PrintPage += new PrintPageEventHandler(ImprimirLayoutTermicoDinamico);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }

        // -----------------------------------------------------------------
        // LAYOUT TÉRMICO - LOGÓTIPO PRETO E BRANCO
        // -----------------------------------------------------------------
        private void ImprimirLayoutTermicoDinamico(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Tipografias mais pequenas adequadas para talão de 80mm
            Font fontTitulo = new Font("Arial", 12, FontStyle.Bold);
            Font fontCorpo = new Font("Arial", 9, FontStyle.Regular);
            Font fontNegrito = new Font("Arial", 9, FontStyle.Bold);

            int x = 10; // Margem esquerda reduzida para talão
            int y = 10;
            int larguraDisponivel = 295; // Largura útil para texto/linhas

            // 1. LOGÓTIPO (Reduzido para caber no talão)
            if (System.IO.File.Exists(caminhoLogo))
            {
                try
                {
                    using (var fs = new FileStream(caminhoLogo, FileMode.Open, FileAccess.Read))
                    using (var logo = Image.FromStream(fs))
                    {
                        // Reduzido para 100x40 para não estourar a largura do talão
                        g.DrawImage(logo, x + 90, y, 100, 40);
                    }
                    y += 50;
                }
                catch { y += 10; }
            }

            // 2. CABEÇALHO DA EMPRESA (Centrado ou à esquerda)
            g.DrawString("EMPRESA DEMO LDA", fontTitulo, Brushes.Black, x, y); y += 20;
            g.DrawString("NIF: 500100200 | Tel: 910 000 000", fontCorpo, Brushes.Black, x, y); y += 15;
            g.DrawLine(Pens.Black, x, y, larguraDisponivel, y); y += 8;

            // 3. DADOS DA FATURA
            g.DrawString($"FATURA Nº: {idFaturaGerada}", fontNegrito, Brushes.Black, x, y); y += 15;
            g.DrawString($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}", fontCorpo, Brushes.Black, x, y); y += 20;
            g.DrawLine(Pens.Black, x, y, larguraDisponivel, y); y += 8;

            // 4. CABEÇALHO DA TABELA DO TALÃO
            g.DrawString("Qtd  Descrição", fontNegrito, Brushes.Black, x, y);
            g.DrawString("Total", fontNegrito, Brushes.Black, x + 230, y);
            y += 15;
            g.DrawLine(Pens.Gray, x, y, larguraDisponivel, y); y += 8;

            // 5. CICLO DE ITENS COMPLETO (Sem interrupção de página)
            foreach (DataRow row in dtItens.Rows)
            {
                string qtd = row["Quantidade"].ToString();
                string desc = row["Descrição"].ToString();
                string subtotal = Convert.ToDecimal(row["Subtotal"]).ToString("C2");

                // Formatação compacta de talão: "1 x Produto Exemplo"
                string linhaTexto = $"{qtd} x {desc}";

                // Se a descrição for muito longa, corta para não sobrepor o total
                if (linhaTexto.Length > 28)
                    linhaTexto = linhaTexto.Substring(0, 25) + "...";

                g.DrawString(linhaTexto, fontCorpo, Brushes.Black, x, y);
                g.DrawString(subtotal, fontCorpo, Brushes.Black, x + 230, y);

                y += 22; // Avança para a próxima linha do item
            }

            // 6. RODAPÉ DA FATURA
            g.DrawLine(Pens.Black, x, y, larguraDisponivel, y); y += 10;
            g.DrawString("TOTAL:", fontTitulo, Brushes.Black, x + 100, y);
            g.DrawString($"{CalcularTotalFatura():C2}", fontTitulo, Brushes.Black, x + 200, y);

            y += 30;
            g.DrawString("Obrigado pela sua preferência!", fontCorpo, Brushes.Black, x + 40, y);

            // Como o tamanho do papel foi calculado sob medida, nunca haverá uma segunda página
            e.HasMorePages = false;
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cboProduto.SelectedValue == null || dtItens.Rows.Count == 0)
            {
                MessageBox.Show("Seleciona o o produto que desejas remover");
            }
            else
            {
                // Exemplo de captura de controlos da interface
                int produtoId = Convert.ToInt32(txtProdId.Text);
                dtItens.Rows.Remove(dtItens.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["ProdutoID"]) == produtoId));

                Limpar();
                ReCalcularTotalFatura();
            }
        }

        private decimal ReCalcularTotalFatura()
        {
            decimal total = 0;

            // Soma o subtotal de cada item que ainda está na tabela
            foreach (DataRow row in dtItens.Rows)
            {
                // Evita erros caso a linha tenha sido marcada como eliminada mas ainda não commitada
                if (row.RowState != DataRowState.Deleted)
                {
                    total += Convert.ToDecimal(row["Subtotal"]);
                }
            }

            // Atualiza a interface com o novo total formatado como moeda
            lblTotal.Text = $"Total: {total:C2}";

            return total;
        }

        private void dgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Garante que o clique não foi no cabeçalho
            {
                DataGridViewRow row = dgvItens.Rows[e.RowIndex];

                txtProdId.Text = row.Cells["ProdutoID"].Value.ToString();
                cboProduto.Text = row.Cells["Descrição"].Value.ToString();
                txtPreco.Text = row.Cells["Preço Unit."].Value.ToString();
                txtQde.Text = row.Cells["Quantidade"].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // 1. Valida se existe um produto selecionado e se a tabela não está vazia
            if (string.IsNullOrEmpty(txtProdId.Text) || dtItens.Rows.Count == 0)
            {
                MessageBox.Show("Selecione o produto que deseja atualizar.");
                return;
            }

            // 2. Captura o ID do produto que está a ser editado
            int produtoId = Convert.ToInt32(txtProdId.Text);

            // 3. Procura a linha correspondente no DataTable
            DataRow linhaParaEditar = dtItens.Rows.Cast<DataRow>().FirstOrDefault(r => Convert.ToInt32(r["ProdutoID"]) == produtoId);

            // 4. Se a linha for encontrada, atualiza os dados
            if (linhaParaEditar != null)
            {
                // Exemplo: Atualizar a quantidade e o preço com base nas caixas de texto
                // Substitui "txtQuantidade" e "txtPreco" pelos nomes reais dos teus controlos
                int novaQuantidade = Convert.ToInt32(txtQde.Text);
                decimal novoPreco = Convert.ToDecimal(txtPreco.Text);

                linhaParaEditar["Quantidade"] = novaQuantidade;
                linhaParaEditar["Preço Unit."] = novoPreco;

                // Se tiveres uma coluna de Total por item, podes calcular também:
                if (dtItens.Columns.Contains("subtotal"))
                {
                    linhaParaEditar["subtotal"] = novaQuantidade * novoPreco;

                }

                // 5. Atualiza a interface e recalcula os totais
                Limpar();
                ReCalcularTotalFatura();

                MessageBox.Show("Produto atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto não encontrado na lista.");
            }
        }
    }
}
