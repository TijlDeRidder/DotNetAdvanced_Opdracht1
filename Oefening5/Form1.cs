namespace Oefening5
{
    public partial class CelciusToFahrenheit : Form
    {
        public CelciusToFahrenheit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CtoF_Click(object sender, EventArgs e)
        {
            if (Celsius.Text.Length != 0)
            {
                Fahrenheit.Text = (double.Parse(Celsius.Text) * 9 / 5 + 32).ToString();
            }
        }

        private void FtoC_Click(object sender, EventArgs e)
        {
            if (Fahrenheit.Text.Length != 0)
            {
                Celsius.Text = ((double.Parse(Fahrenheit.Text) -32) * 5/9).ToString();
            }
        }
    }
}