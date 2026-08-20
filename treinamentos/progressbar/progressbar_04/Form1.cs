namespace progressbar_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cpgb.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpgb.Value++;
            cpgb.Text = cpgb.Value.ToString() + "%";
            if (cpgb.Value == 100 ) {
                timer1.Enabled = false;
            }
        }
    }
}
