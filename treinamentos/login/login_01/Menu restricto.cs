using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login_01
{
    public partial class Menu_restricto : Form
    {
        public Menu_restricto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var autentifica = new autentificar();
            autentifica.Show();

            this.Hide();
        }
    }
}
