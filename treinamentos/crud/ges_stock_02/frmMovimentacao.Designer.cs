namespace gestao_stock_02
{
    partial class frmMovimentacao
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
            label11 = new Label();
            cmbTipo = new ComboBox();
            label10 = new Label();
            cmbProdutos = new ComboBox();
            btnVerAlertas = new Button();
            btnGravar = new Button();
            dgvHistorico = new DataGridView();
            txtQuantidade = new TextBox();
            label4 = new Label();
            txtMotivo = new TextBox();
            label3 = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bodoni MT Condensed", 12F);
            label11.Location = new Point(10, 132);
            label11.Name = "label11";
            label11.Size = new Size(97, 19);
            label11.TabIndex = 40;
            label11.Text = "Tipo de Movimento";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "ENTRADA", "SAÍDA" });
            cmbTipo.Location = new Point(112, 132);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(176, 23);
            cmbTipo.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bodoni MT Condensed", 12F);
            label10.Location = new Point(10, 93);
            label10.Name = "label10";
            label10.Size = new Size(46, 19);
            label10.TabIndex = 38;
            label10.Text = "Produto";
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Items.AddRange(new object[] { "", "Opera", "Administraçao", "Finanças" });
            cmbProdutos.Location = new Point(62, 93);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(226, 23);
            cmbProdutos.TabIndex = 37;
            // 
            // btnVerAlertas
            // 
            btnVerAlertas.Location = new Point(411, 286);
            btnVerAlertas.Name = "btnVerAlertas";
            btnVerAlertas.Size = new Size(262, 23);
            btnVerAlertas.TabIndex = 36;
            btnVerAlertas.Text = "...";
            btnVerAlertas.UseVisualStyleBackColor = true;
            btnVerAlertas.Click += btnVerAlertas_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(307, 286);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 35;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(307, 12);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.Size = new Size(627, 254);
            dgvHistorico.TabIndex = 34;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Bodoni MT Condensed", 12F);
            txtQuantidade.Location = new Point(101, 167);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(187, 26);
            txtQuantidade.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT Condensed", 12F);
            label4.Location = new Point(10, 170);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 32;
            label4.Text = "Quantidade";
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Bodoni MT Condensed", 12F);
            txtMotivo.Location = new Point(55, 208);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(233, 26);
            txtMotivo.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT Condensed", 12F);
            label3.Location = new Point(10, 211);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 30;
            label3.Text = "Motivo";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(785, 286);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(149, 23);
            btnVoltar.TabIndex = 41;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 323);
            Controls.Add(btnVoltar);
            Controls.Add(label11);
            Controls.Add(cmbTipo);
            Controls.Add(label10);
            Controls.Add(cmbProdutos);
            Controls.Add(btnVerAlertas);
            Controls.Add(btnGravar);
            Controls.Add(dgvHistorico);
            Controls.Add(txtQuantidade);
            Controls.Add(label4);
            Controls.Add(txtMotivo);
            Controls.Add(label3);
            Name = "frmMovimentacao";
            Text = "MovimentacaoDAO";
            Load += frmMovimentacao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private ComboBox cmbTipo;
        private Label label10;
        private ComboBox cmbProdutos;
        private Button btnVerAlertas;
        private Button btnGravar;
        private DataGridView dgvHistorico;
        private TextBox txtQuantidade;
        private Label label4;
        private TextBox txtMotivo;
        private Label label3;
        private Button btnVoltar;
    }
}