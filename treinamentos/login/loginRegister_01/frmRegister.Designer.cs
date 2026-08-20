namespace loginRegister_01
{
    partial class frmRegister
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
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConfirn = new TextBox();
            label4 = new Label();
            chkShowPass = new CheckBox();
            btnRegister = new Button();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 114);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(41, 134);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(41, 200);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 180);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // txtConfirn
            // 
            txtConfirn.BackColor = Color.FromArgb(230, 231, 233);
            txtConfirn.BorderStyle = BorderStyle.None;
            txtConfirn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirn.Location = new Point(41, 269);
            txtConfirn.Multiline = true;
            txtConfirn.Name = "txtConfirn";
            txtConfirn.Size = new Size(216, 28);
            txtConfirn.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 249);
            label4.Name = "label4";
            label4.Size = new Size(124, 17);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password:";
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.Cursor = Cursors.Hand;
            chkShowPass.FlatStyle = FlatStyle.Flat;
            chkShowPass.Location = new Point(135, 317);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(119, 21);
            chkShowPass.TabIndex = 7;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(116, 86, 176);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(41, 359);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(213, 35);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(116, 86, 176);
            button1.Location = new Point(41, 400);
            button1.Name = "button1";
            button1.Size = new Size(213, 35);
            button1.TabIndex = 9;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 459);
            label5.Name = "label5";
            label5.Size = new Size(163, 17);
            label5.TabIndex = 10;
            label5.Text = "Already have an account.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(116, 86, 176);
            label6.Location = new Point(91, 476);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 11;
            label6.Text = "Back to Login";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(305, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(chkShowPass);
            Controls.Add(txtConfirn);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConfirn;
        private Label label4;
        private CheckBox chkShowPass;
        private Button btnRegister;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}
