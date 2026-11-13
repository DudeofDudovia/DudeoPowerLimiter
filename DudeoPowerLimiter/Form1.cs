namespace DudeoPowerLimiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(99);
        }

        private void ApplyPowerLimit_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveLimit_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(100);
        }
    }
}
