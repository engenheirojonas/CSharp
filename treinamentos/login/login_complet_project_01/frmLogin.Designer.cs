namespace login_complet_project
{
    partial class frmLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPW = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            linkPass = new LinkLabel();
            btnClose = new PictureBox();
            btnMin = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(51, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.DimGray;
            txtUser.Location = new Point(317, 90);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(387, 20);
            txtUser.TabIndex = 1;
            txtUser.Text = "Usuário";
            txtUser.Leave += txtUser_Leave;
            txtUser.MouseDoubleClick += txtUser_MouseDoubleClick;
            // 
            // txtPW
            // 
            txtPW.BackColor = Color.FromArgb(15, 15, 15);
            txtPW.BorderStyle = BorderStyle.None;
            txtPW.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPW.ForeColor = Color.DimGray;
            txtPW.Location = new Point(317, 159);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(387, 20);
            txtPW.TabIndex = 2;
            txtPW.Text = "Senha";
            txtPW.Leave += txtPW_Leave;
            txtPW.MouseDoubleClick += txtPW_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(443, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 40);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.LightGray;
            btnLogin.Location = new Point(317, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ACESSAR";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkPass
            // 
            linkPass.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkPass.AutoSize = true;
            linkPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkPass.LinkColor = Color.DimGray;
            linkPass.Location = new Point(417, 277);
            linkPass.Name = "linkPass";
            linkPass.Size = new Size(195, 17);
            linkPass.TabIndex = 0;
            linkPass.TabStop = true;
            linkPass.Text = "Esqueceste a palavra passe?";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(753, 11);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(15, 15);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 6;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(732, 11);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(15, 15);
            btnMin.SizeMode = PictureBoxSizeMode.Zoom;
            btnMin.TabIndex = 7;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(linkPass);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPW);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += frmLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        protected internal TextBox txtUser;
        protected internal TextBox txtPW;
        private Label label1;
        private Button btnLogin;
        private LinkLabel linkPass;
        private PictureBox btnClose;
        private PictureBox btnMin;
        private PictureBox pictureBox1;
    }
}
