namespace login_02
{
    partial class login
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_Usuario = new TextBox();
            txt_Senha = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(138, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(48, 42);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(259, 23);
            txt_Usuario.TabIndex = 3;
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(48, 113);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(259, 23);
            txt_Senha.TabIndex = 4;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 229);
            Controls.Add(txt_Senha);
            Controls.Add(txt_Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txt_Usuario;
        private TextBox txt_Senha;
    }
}
