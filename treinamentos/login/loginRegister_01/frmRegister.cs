
using System.Data.OleDb;

namespace loginRegister_01
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Repositorios\\CSharp\\treinamentos\\login\\loginRegister_01\\obj\\db_login.accdb;");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirm.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos", "Campos de Registos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirm.Text)
            {
                con.Open();
                string register = "INSERT INTO t_usuarios VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirm.Text = "";

                MessageBox.Show("Conta criada com sucesso", "Cadastramento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Impossivel de cadastrar", "Cadastramento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirm.Text = "";
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirm.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtUsername.Focus();
        }

        private void lbl_Back_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
