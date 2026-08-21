namespace login_mysql_01
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            cadastarProdutoToolStripMenuItem = new ToolStripMenuItem();
            listaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            cadastroDosClientesToolStripMenuItem = new ToolStripMenuItem();
            listaDosClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDosFornecedoresToolStripMenuItem = new ToolStripMenuItem();
            listaDosFornecedoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtoToolStripMenuItem, clienteToolStripMenuItem, fornecedorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(626, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastarProdutoToolStripMenuItem, listaDeProdutosToolStripMenuItem, stockToolStripMenuItem });
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(114, 26);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // cadastarProdutoToolStripMenuItem
            // 
            cadastarProdutoToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            cadastarProdutoToolStripMenuItem.Name = "cadastarProdutoToolStripMenuItem";
            cadastarProdutoToolStripMenuItem.Size = new Size(219, 30);
            cadastarProdutoToolStripMenuItem.Text = "cadastar produto";
            // 
            // listaDeProdutosToolStripMenuItem
            // 
            listaDeProdutosToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            listaDeProdutosToolStripMenuItem.Name = "listaDeProdutosToolStripMenuItem";
            listaDeProdutosToolStripMenuItem.Size = new Size(219, 30);
            listaDeProdutosToolStripMenuItem.Text = "Lista de produtos";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(219, 30);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDosClientesToolStripMenuItem, listaDosClientesToolStripMenuItem });
            clienteToolStripMenuItem.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(104, 26);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDosFornecedoresToolStripMenuItem, listaDosFornecedoresToolStripMenuItem });
            fornecedorToolStripMenuItem.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(151, 26);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastroDosClientesToolStripMenuItem
            // 
            cadastroDosClientesToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            cadastroDosClientesToolStripMenuItem.Name = "cadastroDosClientesToolStripMenuItem";
            cadastroDosClientesToolStripMenuItem.Size = new Size(253, 30);
            cadastroDosClientesToolStripMenuItem.Text = "Cadastro dos Clientes";
            // 
            // listaDosClientesToolStripMenuItem
            // 
            listaDosClientesToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            listaDosClientesToolStripMenuItem.Name = "listaDosClientesToolStripMenuItem";
            listaDosClientesToolStripMenuItem.Size = new Size(253, 30);
            listaDosClientesToolStripMenuItem.Text = "Lista dos Clientes";
            // 
            // cadastroDosFornecedoresToolStripMenuItem
            // 
            cadastroDosFornecedoresToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            cadastroDosFornecedoresToolStripMenuItem.Name = "cadastroDosFornecedoresToolStripMenuItem";
            cadastroDosFornecedoresToolStripMenuItem.Size = new Size(290, 30);
            cadastroDosFornecedoresToolStripMenuItem.Text = "Cadastro dos fornecedores";
            // 
            // listaDosFornecedoresToolStripMenuItem
            // 
            listaDosFornecedoresToolStripMenuItem.Font = new Font("Sylfaen", 14.25F);
            listaDosFornecedoresToolStripMenuItem.Name = "listaDosFornecedoresToolStripMenuItem";
            listaDosFornecedoresToolStripMenuItem.Size = new Size(290, 30);
            listaDosFornecedoresToolStripMenuItem.Text = "Lista dos fornecedores";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 315);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem cadastarProdutoToolStripMenuItem;
        private ToolStripMenuItem listaDeProdutosToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem cadastroDosClientesToolStripMenuItem;
        private ToolStripMenuItem listaDosClientesToolStripMenuItem;
        private ToolStripMenuItem cadastroDosFornecedoresToolStripMenuItem;
        private ToolStripMenuItem listaDosFornecedoresToolStripMenuItem;
    }
}