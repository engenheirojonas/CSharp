namespace progressbar_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           progressBar1.Value = progressBar1.Value + 5;
        }
    }
}
