namespace login_01
{
    public partial class autentificar : Form
    {
        public autentificar()
        {
            InitializeComponent();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try {
                if (txt_Usuario.Text.Equals("admin") && txt_Senha.Text.Equals("123"))
                {
                    //ir pra a area restrita
                    var menu = new Menu_restricto();
                    menu.Show();

                    this.Visible=false;
                } else {
                    MessageBox.Show("Usuário ou Senha incorretos",
                                    "Desculpe",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    txt_Usuario.Focus();
                    txt_Usuario.Text = "";
                    txt_Senha.Text = "";
                }

            } catch(Exception ex) {
                MessageBox.Show("Desculpe",
                                    ex.Message,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

            }
        }
    }
}
