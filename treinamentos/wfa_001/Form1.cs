namespace wfa_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string texto = txtLegend.Text;
            
            if (txtLegend.Text == string.Empty)
            {
                MessageBox.Show("Porfavor, digite uma palavra");
            }
            else
            {
                MessageBox.Show("Voce digitaste : \" " + texto + " \" ");
            }
        } 
    }
}
