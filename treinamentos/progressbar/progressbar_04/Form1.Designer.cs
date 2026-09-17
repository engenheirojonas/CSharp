namespace progressbar_04
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
            components = new System.ComponentModel.Container();
            cpgb = new Krypton.Toolkit.Suite.Extended.Circular.ProgressBar.CircularProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // cpgb
            // 
            cpgb.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            cpgb.AnimationSpeed = 500;
            cpgb.BackColor = Color.Transparent;
            cpgb.FirstValueColor = Color.Red;
            cpgb.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpgb.ForeColor = Color.FromArgb(36, 36, 36);
            cpgb.InnerColor = Color.FromArgb(209, 209, 209);
            cpgb.InnerMargin = 2;
            cpgb.InnerWidth = -1;
            cpgb.Location = new Point(144, 54);
            cpgb.MarqueeAnimationSpeed = 2000;
            cpgb.Name = "cpgb";
            cpgb.OuterColor = Color.White;
            cpgb.OuterMargin = -25;
            cpgb.OuterWidth = 26;
            cpgb.ProgressColor = Color.FromArgb(255, 216, 107);
            cpgb.ProgressWidth = 25;
            cpgb.SecondaryFont = new Font("Segoe UI", 36F);
            cpgb.SecondValueColor = Color.OliveDrab;
            cpgb.Size = new Size(217, 198);
            cpgb.StartAngle = 270;
            cpgb.SubscriptColor = Color.FromArgb(97, 97, 97);
            cpgb.SubscriptMargin = new Padding(10, -35, 0, 0);
            cpgb.SubscriptText = "";
            cpgb.SuperscriptColor = Color.FromArgb(97, 97, 97);
            cpgb.SuperscriptMargin = new Padding(10, 35, 0, 0);
            cpgb.SuperscriptText = "";
            cpgb.TabIndex = 0;
            cpgb.Text = "0";
            cpgb.TextMargin = new Padding(8, 8, 0, 0);
            cpgb.ThirdValueColor = Color.Green;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Circular Progressbar";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 300);
            Controls.Add(label1);
            Controls.Add(cpgb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.Suite.Extended.Circular.ProgressBar.CircularProgressBar cpgb;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
