using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            if (txtUse.Text == "admin" && txtPass.Text == "123") {
                MessageBox.Show("Acesso permitido");
                Form2 f2 = new Form2();
                f2.Show();
         
            } 
            else
            {
                MessageBox.Show("Acesso negado");
                this.Close();
            }
        }
    }
}
