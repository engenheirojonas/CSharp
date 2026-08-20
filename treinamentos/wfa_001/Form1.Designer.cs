namespace wfa_001
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
            txtLegend = new TextBox();
            btnApply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "Escreva algo :";
            // 
            // txtLegend
            // 
            txtLegend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLegend.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLegend.Location = new Point(27, 55);
            txtLegend.Name = "txtLegend";
            txtLegend.Size = new Size(463, 43);
            txtLegend.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnApply.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.Location = new Point(27, 173);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(463, 30);
            btnApply.TabIndex = 2;
            btnApply.Text = "Clique aqui!";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(516, 238);
            Controls.Add(btnApply);
            Controls.Add(txtLegend);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WFA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLegend;
        private Button btnApply;
    }
}
