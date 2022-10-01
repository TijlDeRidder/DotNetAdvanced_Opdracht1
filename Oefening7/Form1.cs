namespace Oefening7
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(nummer.Text);
            int resultaat = 0;
            for(int i = 0; i <= getal; i++)
            {
                resultaat += i;
            }
            solution.Text = resultaat.ToString();
        }
    }
}