using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace loginRegister_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Repositorios\\CSharp\\treinamentos\\login\\loginRegister_01\\obj\\db_login.accdb;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM t_usuarios WHERE username ='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            

            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Autentificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dr.Read() == true)
            {
                new frmMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acesso negado", "Autentificação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

            con.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
