namespace Oefening2
{
    public partial class IsItBigger : Form
    {
        int getal1 = 12345;
        int getal2 = 54321;
        int getal3 = 22222;
        int getal4 = 33333;
        public IsItBigger()
        {
            InitializeComponent();
            maal1.Text = getal1 + " * " + getal2 + " = " + getal1 * getal2;
            maal2.Text = getal3 + " * " + getal4 + " = " + getal3 * getal4;
            bool uitkomst = false;
            if((getal1 * getal2) > (getal3 * getal4))
            {
                uitkomst = true;
            }
            groterdan.Text = getal1 + " * " + getal2 + " > " + getal3 + " * " + getal4 + " = " + uitkomst;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maal1_Click(object sender, EventArgs e)
        {

        }
    }
}