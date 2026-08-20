namespace login_03
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUse = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUse
            // 
            this.txtUse.Location = new System.Drawing.Point(62, 55);
            this.txtUse.Name = "txtUse";
            this.txtUse.Size = new System.Drawing.Size(290, 20);
            this.txtUse.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(62, 92);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnAcesso
            // 
            this.btnAcesso.Location = new System.Drawing.Point(248, 90);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(104, 23);
            this.btnAcesso.TabIndex = 2;
            this.btnAcesso.Text = "Acessar";
            this.btnAcesso.UseVisualStyleBackColor = true;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(407, 152);
            this.Controls.Add(this.btnAcesso);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUse);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAcesso;
    }
}

