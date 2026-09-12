namespace conexao_mysql_01
{
    partial class Form1
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
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbCategoria = new ComboBox();
            label6 = new Label();
            txtPreco = new NumericUpDown();
            txtQde = new NumericUpDown();
            dgvProdutos = new DataGridView();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtId.Location = new Point(46, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(187, 22);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtNome.Location = new Point(83, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 22);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 170);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 6;
            label3.Text = "Preco";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtCodigo.Location = new Point(83, 127);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 22);
            txtCodigo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(17, 126);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 4;
            label4.Text = "Codigo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(17, 216);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 8;
            label5.Text = "Quantidade";
            // 
            // cbCategoria
            // 
            cbCategoria.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Electronicos", "Alimentos", "Electrodomestico" });
            cbCategoria.Location = new Point(100, 263);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(133, 24);
            cbCategoria.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(17, 263);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 11;
            label6.Text = "Categoria";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(72, 173);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(161, 23);
            txtPreco.TabIndex = 12;
            // 
            // txtQde
            // 
            txtQde.Location = new Point(114, 219);
            txtQde.Name = "txtQde";
            txtQde.Size = new Size(119, 23);
            txtQde.TabIndex = 13;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(249, 12);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(627, 297);
            dgvProdutos.TabIndex = 14;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(19, 315);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(141, 23);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Guardar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(339, 315);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(141, 23);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Deletar";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(178, 315);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(141, 23);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Atualizar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(506, 315);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(141, 23);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar os campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 350);
            Controls.Add(btnLimpar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(dgvProdutos);
            Controls.Add(txtQde);
            Controls.Add(txtPreco);
            Controls.Add(label6);
            Controls.Add(cbCategoria);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQde).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private Label label4;
        private Label label5;
        private ComboBox cbCategoria;
        private Label label6;
        private NumericUpDown txtPreco;
        private NumericUpDown txtQde;
        private DataGridView dgvProdutos;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnLimpar;
    }
}
