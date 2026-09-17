using dashboard_02;
using System.Runtime.InteropServices;


namespace dashboard_01
{
    public partial class mainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn(

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        public mainForm()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);


            /*
                     //main form dependencia; locgo ao inicializar a pagina principal
                lbl_Title.Text = "Dashboard";
                this.pnl_FormLoader.Controls.Clear();
                frmDashboard frmDashboard_vrb = new frmDashboard()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
                this.pnl_FormLoader.Controls.Add(frmDashboard_vrb);
                frmDashboard_vrb.Show();

            */
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

                    //main form dependencia
            lbl_Title.Text = "Dashboard";
            this.pnl_FormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

                    //main form dependencia
            lbl_Title.Text = "Analytics";
            this.pnl_FormLoader.Controls.Clear();
            frmAnalytics frmDashboard_vrb = new frmAnalytics()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalendar.Height;
            pnlNav.Top = btnCalendar.Top;
            btnCalendar.BackColor = Color.FromArgb(46, 51, 73);

            //main form dependencia
            lbl_Title.Text = "Calendar";
            this.pnl_FormLoader.Controls.Clear();
            frmCalendar frmDashboard_vrb = new frmCalendar()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContact.Height;
            pnlNav.Top = btnContact.Top;
            btnContact.BackColor = Color.FromArgb(46, 51, 73);

            //main form dependencia
            lbl_Title.Text = "Contact";
            this.pnl_FormLoader.Controls.Clear();
            frmContact frmDashboard_vrb = new frmContact()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConfig.Height;
            pnlNav.Top = btnConfig.Top;
            btnConfig.BackColor = Color.FromArgb(46, 51, 73);

            //main form dependencia
            lbl_Title.Text = "Configurações";
            this.pnl_FormLoader.Controls.Clear();
            frmConfig frmDashboard_vrb = new frmConfig()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalendar_Leave(object sender, EventArgs e)
        {
            btnCalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContact_Leave(object sender, EventArgs e)
        {
            btnContact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnConfig_Leave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
