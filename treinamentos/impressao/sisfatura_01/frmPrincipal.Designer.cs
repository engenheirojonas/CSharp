namespace sisfatura_01
{
    partial class frmPrincipal
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
            txtNome = new TextBox();
            txtNIF = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGravar = new Button();
            label4 = new Label();
            label5 = new Label();
            txtDescri = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            txtPreco = new TextBox();
            label7 = new Label();
            btnAdicionar = new Button();
            cboProduto = new ComboBox();
            txtProdId = new TextBox();
            cboCliente = new ComboBox();
            label6 = new Label();
            txtQde = new TextBox();
            label8 = new Label();
            label9 = new Label();
            Produto = new Label();
            dgvItens = new DataGridView();
            btnImprimirA4 = new Button();
            btnImprimirTermica = new Button();
            lblTotal = new Label();
            btnFinalizar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 43);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(217, 23);
            txtNome.TabIndex = 1;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(66, 79);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(217, 23);
            txtNIF.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 82);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "NIF :";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDescri);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNIF);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 241);
            panel1.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(196, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 27);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(103, 198);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 27);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(10, 198);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(87, 27);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 123);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 5;
            label4.Text = "Descrição :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 162);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Preço :";
            // 
            // txtDescri
            // 
            txtDescri.Location = new Point(80, 120);
            txtDescri.Name = "txtDescri";
            txtDescri.Size = new Size(203, 23);
            txtDescri.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 9);
            label3.Name = "label3";
            label3.Size = new Size(170, 19);
            label3.TabIndex = 4;
            label3.Text = "CRUD Clientes/Produtos";
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPreco);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnAdicionar);
            panel2.Controls.Add(cboProduto);
            panel2.Controls.Add(txtProdId);
            panel2.Controls.Add(cboCliente);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtQde);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(Produto);
            panel2.Location = new Point(39, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 237);
            panel2.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 143);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 14;
            label10.Text = "Preço Unitario :";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(104, 140);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(112, 23);
            txtPreco.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 33);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 13;
            label7.Text = "Id :";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(56, 204);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(123, 22);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar Item";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cboProduto
            // 
            cboProduto.FormattingEnabled = true;
            cboProduto.Location = new Point(70, 105);
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(146, 23);
            cboProduto.TabIndex = 8;
            // 
            // txtProdId
            // 
            txtProdId.Location = new Point(47, 30);
            txtProdId.Name = "txtProdId";
            txtProdId.Size = new Size(169, 23);
            txtProdId.TabIndex = 12;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(66, 67);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(150, 23);
            cboCliente.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 178);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 5;
            label6.Text = "Quantidade :";
            // 
            // txtQde
            // 
            txtQde.Location = new Point(91, 175);
            txtQde.Name = "txtQde";
            txtQde.Size = new Size(125, 23);
            txtQde.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(56, 7);
            label8.Name = "label8";
            label8.Size = new Size(123, 23);
            label8.TabIndex = 4;
            label8.Text = "Área de Venda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 70);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 0;
            label9.Text = "Cliente :";
            // 
            // Produto
            // 
            Produto.AutoSize = true;
            Produto.Location = new Point(10, 108);
            Produto.Name = "Produto";
            Produto.Size = new Size(56, 15);
            Produto.TabIndex = 2;
            Produto.Text = "Produto :";
            // 
            // dgvItens
            // 
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Location = new Point(308, 50);
            dgvItens.Name = "dgvItens";
            dgvItens.Size = new Size(678, 353);
            dgvItens.TabIndex = 10;
            // 
            // btnImprimirA4
            // 
            btnImprimirA4.Location = new Point(767, 16);
            btnImprimirA4.Name = "btnImprimirA4";
            btnImprimirA4.Size = new Size(93, 27);
            btnImprimirA4.TabIndex = 12;
            btnImprimirA4.Text = "Imprimir A4";
            btnImprimirA4.UseVisualStyleBackColor = true;
            btnImprimirA4.Click += btnImprimirA4_Click;
            // 
            // btnImprimirTermica
            // 
            btnImprimirTermica.Location = new Point(866, 16);
            btnImprimirTermica.Name = "btnImprimirTermica";
            btnImprimirTermica.Size = new Size(120, 27);
            btnImprimirTermica.TabIndex = 13;
            btnImprimirTermica.Text = "Imprimir Térmica";
            btnImprimirTermica.UseVisualStyleBackColor = true;
            btnImprimirTermica.Click += btnImprimirTermica_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Felix Titling", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(308, 430);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 43);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "0";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(752, 475);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(234, 22);
            btnFinalizar.TabIndex = 13;
            btnFinalizar.Text = "Finalizar a Venda";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 509);
            Controls.Add(btnFinalizar);
            Controls.Add(lblTotal);
            Controls.Add(btnImprimirTermica);
            Controls.Add(btnImprimirA4);
            Controls.Add(dgvItens);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPrincipal";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtNIF;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDescri;
        private Panel panel2;
        private Label label6;
        private TextBox txtQde;
        private Label label8;
        private Label label9;
        private Label Produto;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGravar;
        private ComboBox cboCliente;
        private ComboBox cboProduto;
        private Button btnAdicionar;
        private DataGridView dgvItens;
        private Button btnImprimirA4;
        private Button btnImprimirTermica;
        private TextBox txtProdId;
        private Label lblTotal;
        private Button btnFinalizar;
        private Label label7;
        private Label label10;
        private TextBox txtPreco;
    }
}
