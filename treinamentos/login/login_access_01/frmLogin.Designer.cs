namespace loginRegister_01
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
            lbl_create = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnRegister = new Button();
            chkShowPass = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_create
            // 
            lbl_create.AutoSize = true;
            lbl_create.ForeColor = Color.FromArgb(116, 86, 176);
            lbl_create.Location = new Point(87, 392);
            lbl_create.Name = "lbl_create";
            lbl_create.Size = new Size(101, 17);
            lbl_create.TabIndex = 23;
            lbl_create.Text = "Create Account";
            lbl_create.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 375);
            label5.Name = "label5";
            label5.Size = new Size(150, 17);
            label5.TabIndex = 22;
            label5.Text = "Don't have an account.";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(116, 86, 176);
            btnClear.Location = new Point(46, 316);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(213, 35);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(116, 86, 176);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(46, 275);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(213, 35);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "LOGIN";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Cursor = Cursors.Hand;
            chkShowPass.FlatStyle = FlatStyle.Flat;
            chkShowPass.Location = new Point(140, 233);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(119, 21);
            chkShowPass.TabIndex = 19;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(46, 199);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 179);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 15;
            label3.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(46, 133);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 113);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 13;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 505);
            Controls.Add(lbl_create);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(chkShowPass);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_create;
        private Label label5;
        private Button btnClear;
        private Button btnRegister;
        private CheckBox chkShowPass;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}