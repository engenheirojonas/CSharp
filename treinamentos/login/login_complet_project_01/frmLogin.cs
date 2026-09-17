using System.Runtime.InteropServices;

namespace login_complet_project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(
            System.IntPtr hund, int wmsg, int wparam, int lparam
        );


        private void txtUser_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Usuário")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuário";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPW_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtPW.Text == "Senha")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.LightGray;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (txtPW.Text == "")
            {
                txtPW.Text = "Senha";
                txtPW.ForeColor = Color.DimGray;
                txtPW.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
