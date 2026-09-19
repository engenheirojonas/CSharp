namespace gestao_stock_03
{
    partial class frmMenuPrincipal
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
            lblTotalProdutos = new Label();
            btnEliminarProdutos = new Button();
            btnConfiguraUtilizadores = new Button();
            lblVolumeStock = new Label();
            lblStockCritico = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnProdutos = new Button();
            SuspendLayout();
            // 
            // lblTotalProdutos
            // 
            lblTotalProdutos.FlatStyle = FlatStyle.Flat;
            lblTotalProdutos.Font = new Font("Bodoni MT Condensed", 48F, FontStyle.Bold);
            lblTotalProdutos.Location = new Point(37, 50);
            lblTotalProdutos.Name = "lblTotalProdutos";
            lblTotalProdutos.Size = new Size(151, 76);
            lblTotalProdutos.TabIndex = 0;
            lblTotalProdutos.Text = ".";
            // 
            // btnEliminarProdutos
            // 
            btnEliminarProdutos.Location = new Point(667, 82);
            btnEliminarProdutos.Name = "btnEliminarProdutos";
            btnEliminarProdutos.Size = new Size(156, 34);
            btnEliminarProdutos.TabIndex = 1;
            btnEliminarProdutos.Text = "Eliminar Produtos";
            btnEliminarProdutos.UseVisualStyleBackColor = true;
            // 
            // btnConfiguraUtilizadores
            // 
            btnConfiguraUtilizadores.Location = new Point(667, 131);
            btnConfiguraUtilizadores.Name = "btnConfiguraUtilizadores";
            btnConfiguraUtilizadores.Size = new Size(156, 34);
            btnConfiguraUtilizadores.TabIndex = 2;
            btnConfiguraUtilizadores.Text = "Configurar Utilizadores";
            btnConfiguraUtilizadores.UseVisualStyleBackColor = true;
            // 
            // lblVolumeStock
            // 
            lblVolumeStock.FlatStyle = FlatStyle.Flat;
            lblVolumeStock.Font = new Font("Bodoni MT Condensed", 48F, FontStyle.Bold);
            lblVolumeStock.Location = new Point(243, 45);
            lblVolumeStock.Name = "lblVolumeStock";
            lblVolumeStock.Size = new Size(151, 76);
            lblVolumeStock.TabIndex = 3;
            lblVolumeStock.Text = ".";
            // 
            // lblStockCritico
            // 
            lblStockCritico.FlatStyle = FlatStyle.Flat;
            lblStockCritico.Font = new Font("Bodoni MT Condensed", 48F, FontStyle.Bold);
            lblStockCritico.Location = new Point(458, 45);
            lblStockCritico.Name = "lblStockCritico";
            lblStockCritico.Size = new Size(151, 76);
            lblStockCritico.TabIndex = 4;
            lblStockCritico.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "VolumeStock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 25);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 6;
            label3.Text = "TotalProdutos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 25);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "StockCritico";
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(667, 263);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(156, 34);
            btnProdutos.TabIndex = 8;
            btnProdutos.Text = "Ir para Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 384);
            Controls.Add(btnProdutos);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblStockCritico);
            Controls.Add(lblVolumeStock);
            Controls.Add(btnConfiguraUtilizadores);
            Controls.Add(btnEliminarProdutos);
            Controls.Add(lblTotalProdutos);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            Load += frmMenuPrincipal_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalProdutos;
        private Button btnEliminarProdutos;
        private Button btnConfiguraUtilizadores;
        private Label lblVolumeStock;
        private Label lblStockCritico;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnProdutos;
    }
}