namespace gestao_stock_03
{
    partial class frmLogin
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
            txtPassword = new TextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bodoni MT Condensed", 12F);
            txtPassword.Location = new Point(236, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 26);
            txtPassword.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bodoni MT Condensed", 12F);
            label7.Location = new Point(178, 105);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 36;
            label7.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Bodoni MT Condensed", 12F);
            txtUsername.Location = new Point(257, 65);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 26);
            txtUsername.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bodoni MT Condensed", 12F);
            label6.Location = new Point(180, 68);
            label6.Name = "label6";
            label6.Size = new Size(43, 19);
            label6.TabIndex = 34;
            label6.Text = "Usuário";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(546, 146);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 38;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 199);
            Controls.Add(btnEntrar);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label7;
        private TextBox txtUsername;
        private Label label6;
        private Button btnEntrar;
    }
}