using gestao_stock_03.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gestao_stock_03
{
    public partial class frmLogin : Form
    {
        private ConexaoBD bd = new ConexaoBD();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = bd.ObterConexao())
            {
                string sql = "SELECT perfil FROM Utilizadores WHERE username=@user AND password_hash=@pass";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                try
                {
                    conn.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string perfil = resultado.ToString();
                        MessageBox.Show($"Bem-vindo! Perfil: {perfil}", "Acesso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir o Painel Principal passando o nível de acesso
                        frmMenuPrincipal menu = new frmMenuPrincipal(perfil);
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Utilizador ou palavra-passe incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
            }
        }
    }
}
