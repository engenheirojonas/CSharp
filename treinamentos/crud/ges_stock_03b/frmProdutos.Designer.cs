namespace gestao_stock_03
{
    partial class frmProdutos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtID = new TextBox();
            txtQtdMinima = new TextBox();
            label3 = new Label();
            txtQuantidade = new TextBox();
            label4 = new Label();
            txtPrecoVenda = new TextBox();
            label5 = new Label();
            txtNome = new TextBox();
            label6 = new Label();
            dgvProdutos = new DataGridView();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnImprimir = new Button();
            cmbCategoria = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            cmbFornecedor = new ComboBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            txtPrecoCompra = new TextBox();
            label7 = new Label();
            btnExportar = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bodoni MT Condensed", 12F);
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtID
            // 
            txtID.Font = new Font("Bodoni MT Condensed", 12F);
            txtID.Location = new Point(38, 12);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(89, 26);
            txtID.TabIndex = 1;
            // 
            // txtQtdMinima
            // 
            txtQtdMinima.Font = new Font("Bodoni MT Condensed", 12F);
            txtQtdMinima.Location = new Point(114, 208);
            txtQtdMinima.Name = "txtQtdMinima";
            txtQtdMinima.Size = new Size(176, 26);
            txtQtdMinima.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT Condensed", 12F);
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 4;
            label3.Text = "Quantidade Mínima";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Bodoni MT Condensed", 12F);
            txtQuantidade.Location = new Point(90, 167);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(200, 26);
            txtQuantidade.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT Condensed", 12F);
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 6;
            label4.Text = "Quantidade";
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Font = new Font("Bodoni MT Condensed", 12F);
            txtPrecoVenda.Location = new Point(83, 123);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(207, 26);
            txtPrecoVenda.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT Condensed", 12F);
            label5.Location = new Point(12, 126);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 8;
            label5.Text = "Preço venda";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Bodoni MT Condensed", 12F);
            txtNome.Location = new Point(58, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(234, 26);
            txtNome.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT Condensed", 12F);
            label6.Location = new Point(14, 57);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 10;
            label6.Text = "Nome";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(309, 12);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(671, 260);
            dgvProdutos.TabIndex = 12;
            dgvProdutos.CellClick += dgvProdutos_CellClick_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(309, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(402, 287);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Atualizar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(494, 286);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(575, 286);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(866, 286);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(114, 23);
            btnImprimir.TabIndex = 17;
            btnImprimir.Text = "Controlo de Stock";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "", "Opera", "Administraçao", "Finanças" });
            cmbCategoria.Location = new Point(114, 249);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(176, 23);
            cmbCategoria.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bodoni MT Condensed", 12F);
            label10.Location = new Point(12, 249);
            label10.Name = "label10";
            label10.Size = new Size(51, 19);
            label10.TabIndex = 27;
            label10.Text = "Categoria";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bodoni MT Condensed", 12F);
            label11.Location = new Point(12, 288);
            label11.Name = "label11";
            label11.Size = new Size(61, 19);
            label11.TabIndex = 29;
            label11.Text = "Fornecedor";
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Items.AddRange(new object[] { "", "Opera", "Administraçao", "Finanças" });
            cmbFornecedor.Location = new Point(114, 288);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(176, 23);
            cmbFornecedor.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT Condensed", 12F);
            label2.Location = new Point(143, 19);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 30;
            label2.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Bodoni MT Condensed", 12F);
            txtCodigo.Location = new Point(190, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(102, 26);
            txtCodigo.TabIndex = 31;
            // 
            // txtPrecoCompra
            // 
            txtPrecoCompra.Font = new Font("Bodoni MT Condensed", 12F);
            txtPrecoCompra.Location = new Point(122, 91);
            txtPrecoCompra.Name = "txtPrecoCompra";
            txtPrecoCompra.Size = new Size(168, 26);
            txtPrecoCompra.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bodoni MT Condensed", 12F);
            label7.Location = new Point(12, 94);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 32;
            label7.Text = "Preço Compra";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(729, 286);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(131, 23);
            btnExportar.TabIndex = 34;
            btnExportar.Text = "Exportar para Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(665, 286);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 23);
            btnMenu.TabIndex = 35;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // frmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 321);
            Controls.Add(btnMenu);
            Controls.Add(btnExportar);
            Controls.Add(txtPrecoCompra);
            Controls.Add(label7);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(cmbFornecedor);
            Controls.Add(label10);
            Controls.Add(cmbCategoria);
            Controls.Add(btnImprimir);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(dgvProdutos);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(txtPrecoVenda);
            Controls.Add(label5);
            Controls.Add(txtQuantidade);
            Controls.Add(label4);
            Controls.Add(txtQtdMinima);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmProdutos";
            Text = "Form1";
            Load += FormProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtQtdMinima;
        private Label label3;
        private TextBox txtQuantidade;
        private Label label4;
        private TextBox txtPrecoVenda;
        private Label label5;
        private TextBox txtNome;
        private Label label6;
        private DataGridView dgvProdutos;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnImprimir;
        private ComboBox cmbCategoria;
        private Label label10;
        private Label label11;
        private ComboBox cmbFornecedor;
        private TextBox txtCodigo;
        private TextBox txtPrecoCompra;
        private Label label7;
        private Button btnExportar;
        private Button btnMenu;
    }
}
