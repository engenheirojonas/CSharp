namespace dashboard_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            label3 = new Label();
            textBox1 = new TextBox();
            btnClose = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            label10 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            label14 = new Label();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            label17 = new Label();
            panel8 = new Panel();
            label13 = new Label();
            label16 = new Label();
            label18 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
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
            btnDashboard.Image = Properties.Resources.home;
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
            pictureBox1.Image = Properties.Resources.imagem_logotipo;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(200, 17);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 1;
            label3.Text = "Dashboard";
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(224, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 130);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.prescriptions;
            pictureBox2.Location = new Point(152, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(159, 151, 176);
            label6.Location = new Point(6, 98);
            label6.Name = "label6";
            label6.Size = new Size(140, 17);
            label6.TabIndex = 2;
            label6.Text = "Details of Last 28 Days";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 146, 249);
            label5.Location = new Point(3, 46);
            label5.Name = "label5";
            label5.Size = new Size(99, 32);
            label5.TabIndex = 1;
            label5.Text = "$1234";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 0;
            label4.Text = "Earnings";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(500, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 130);
            panel4.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.prescriptions;
            pictureBox3.Location = new Point(152, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(159, 151, 176);
            label7.Location = new Point(6, 98);
            label7.Name = "label7";
            label7.Size = new Size(140, 17);
            label7.TabIndex = 2;
            label7.Text = "Details of Last 28 Days";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 146, 249);
            label8.Location = new Point(3, 46);
            label8.Name = "label8";
            label8.Size = new Size(76, 32);
            label8.TabIndex = 1;
            label8.Text = "12 K";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 7);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 0;
            label9.Text = "Marketing";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(776, 88);
            panel5.Name = "panel5";
            panel5.Size = new Size(156, 130);
            panel5.TabIndex = 6;
            // 
            // label10
            // 
            label10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(159, 151, 176);
            label10.Location = new Point(22, 47);
            label10.Name = "label10";
            label10.Size = new Size(109, 71);
            label10.TabIndex = 2;
            label10.Text = "Some extra text here to makte the tab more attractive";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 7);
            label12.Name = "label12";
            label12.Size = new Size(67, 25);
            label12.TabIndex = 0;
            label12.Text = "Lucros";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(224, 228);
            panel6.Name = "panel6";
            panel6.Size = new Size(258, 328);
            panel6.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.prescriptions;
            pictureBox5.Location = new Point(12, 42);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(237, 234);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(159, 151, 176);
            label11.Location = new Point(6, 279);
            label11.Name = "label11";
            label11.Size = new Size(224, 37);
            label11.TabIndex = 3;
            label11.Text = "Enter some text related to application or prograss";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 7);
            label14.Name = "label14";
            label14.Size = new Size(137, 25);
            label14.TabIndex = 0;
            label14.Text = "Some Prograss";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(500, 228);
            panel7.Name = "panel7";
            panel7.Size = new Size(432, 240);
            panel7.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.prescriptions;
            pictureBox4.Location = new Point(94, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(325, 221);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 7);
            label17.Name = "label17";
            label17.Size = new Size(72, 25);
            label17.TabIndex = 0;
            label17.Text = "Graphs";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(37, 42, 64);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(label18);
            panel8.Location = new Point(500, 484);
            panel8.Name = "panel8";
            panel8.Size = new Size(432, 72);
            panel8.TabIndex = 7;
            // 
            // label13
            // 
            label13.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(159, 151, 176);
            label13.Location = new Point(6, 27);
            label13.Name = "label13";
            label13.Size = new Size(325, 33);
            label13.TabIndex = 3;
            label13.Text = "Some extra text here to makte the tab more attractive";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(159, 151, 176);
            label16.Location = new Point(6, 98);
            label16.Name = "label16";
            label16.Size = new Size(140, 17);
            label16.TabIndex = 2;
            label16.Text = "Details of Last 28 Days";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(3, 7);
            label18.Name = "label18";
            label18.Size = new Size(106, 25);
            label18.TabIndex = 0;
            label18.Text = "Downloads";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnClose);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private Label label3;
        private TextBox textBox1;
        private Button btnClose;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Label label10;
        private Label label12;
        private Panel panel6;
        private Label label14;
        private Panel panel7;
        private Label label17;
        private Panel panel8;
        private Label label16;
        private Label label18;
        private Label label11;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label13;
    }
}
