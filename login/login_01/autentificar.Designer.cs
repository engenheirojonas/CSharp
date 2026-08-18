namespace login_01
{
    partial class autentificar
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
            groupBox1 = new GroupBox();
            txt_Senha = new TextBox();
            btnCancela = new Button();
            btnEntrar = new Button();
            txt_Usuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Senha);
            groupBox1.Controls.Add(btnCancela);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(txt_Usuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulário de LOGIN";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(26, 115);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(319, 23);
            txt_Senha.TabIndex = 6;
            txt_Senha.UseSystemPasswordChar = true;
            // 
            // btnCancela
            // 
            btnCancela.Location = new Point(270, 172);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(75, 23);
            btnCancela.TabIndex = 5;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = true;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(189, 172);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(26, 55);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(319, 23);
            txt_Usuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 231);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestão";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Usuario;
        private Label label2;
        private Label label1;
        private Button btnCancela;
        private Button btnEntrar;
        private TextBox txt_Senha;
    }
}
