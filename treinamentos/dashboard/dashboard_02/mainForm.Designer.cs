namespace dashboard_01
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            panel1 = new Panel();
            pnlNav = new Panel();
            btnConfig = new Button();
            btnContact = new Button();
            btnCalendar = new Button();
            btnAnalytics = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbl_Title = new Label();
            textBox1 = new TextBox();
            btnClose = new Button();
            pnl_FormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(btnContact);
            panel1.Controls.Add(btnCalendar);
            panel1.Controls.Add(btnAnalytics);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 193);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 1;
            // 
            // btnConfig
            // 
            btnConfig.Dock = DockStyle.Bottom;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.ForeColor = Color.FromArgb(0, 126, 249);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.Location = new Point(0, 535);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(186, 42);
            btnConfig.TabIndex = 6;
            btnConfig.Text = "Settings";
            btnConfig.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            btnConfig.Leave += btnConfig_Leave;
            // 
            // btnContact
            // 
            btnContact.Dock = DockStyle.Top;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContact.ForeColor = Color.FromArgb(0, 126, 249);
            btnContact.Image = (Image)resources.GetObject("btnContact.Image");
            btnContact.Location = new Point(0, 270);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(186, 42);
            btnContact.TabIndex = 4;
            btnContact.Text = "Contact Us";
            btnContact.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += btnContact_Click;
            btnContact.Leave += btnContact_Leave;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalendar.ForeColor = Color.FromArgb(0, 126, 249);
            btnCalendar.Image = (Image)resources.GetObject("btnCalendar.Image");
            btnCalendar.Location = new Point(0, 228);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(186, 42);
            btnCalendar.TabIndex = 3;
            btnCalendar.Text = "Calendar";
            btnCalendar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            btnCalendar.Leave += btnCalendar_Leave;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalytics.ForeColor = Color.FromArgb(0, 126, 249);
            btnAnalytics.Image = (Image)resources.GetObject("btnAnalytics.Image");
            btnAnalytics.Location = new Point(0, 186);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(186, 42);
            btnAnalytics.TabIndex = 2;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            btnAnalytics.Leave += btnAnalytics_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(0, 144);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(156, 16);
            label2.TabIndex = 3;
            label2.Text = "Some User Text Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(51, 88);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(158, 161, 176);
            lbl_Title.Location = new Point(200, 17);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(139, 32);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "Welcome";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(640, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 32);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search for something";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.Window;
            btnClose.Location = new Point(928, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 25);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnl_FormLoader
            // 
            pnl_FormLoader.Dock = DockStyle.Bottom;
            pnl_FormLoader.Location = new Point(186, 81);
            pnl_FormLoader.Name = "pnl_FormLoader";
            pnl_FormLoader.Size = new Size(765, 496);
            pnl_FormLoader.TabIndex = 4;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(pnl_FormLoader);
            Controls.Add(btnClose);
            Controls.Add(textBox1);
            Controls.Add(lbl_Title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnDashboard;
        private Button btnConfig;
        private Button btnContact;
        private Button btnCalendar;
        private Button btnAnalytics;
        private Panel pnlNav;
        private Label lbl_Title;
        private TextBox textBox1;
        private Button btnClose;
        private Panel pnl_FormLoader;
    }
}
