namespace login_02
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String password = "123";

            if (txt_Usuario.Text == user & txt_Senha.Text == password)
            {
                MessageBox.Show("Acesso liberado");
                menu formprincipal = new menu();
                formprincipal.Show();
                this.Hide();
            } else {
                MessageBox.Show("Usuario e senha incorretos!");
            }
        }
    }
}
