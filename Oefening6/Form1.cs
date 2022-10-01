namespace Oefening6
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void price1_TextChanged(object sender, EventArgs e)
        {
            if (quant1.Value != 0 && price1.Text.Length > 0)
            {
                totalPrice1.Text = (double.Parse(quant1.Value.ToString()) * double.Parse(price1.Text)).ToString();
            }
            else
            {
                totalPrice1.Text = "0";
            }
        }

        private void quant1_ValueChanged(object sender, EventArgs e)
        {
            if (quant1.Value != 0 && price1.Text.Length > 0)
            {
                totalPrice1.Text = (double.Parse(quant1.Value.ToString()) * double.Parse(price1.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice1.Text = temp.ToString();
            }
        }

        private void quant2_ValueChanged(object sender, EventArgs e)
        {
            if (quant2.Value != 0 && price2.Text.Length > 0)
            {
                totalPrice2.Text = (double.Parse(quant2.Value.ToString()) * double.Parse(price2.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice2.Text = temp.ToString();
            }
        }

        private void price2_TextChanged(object sender, EventArgs e)
        {
            if (quant2.Value != 0 && price2.Text.Length > 0)
            {
                totalPrice2.Text = (double.Parse(quant2.Value.ToString()) * double.Parse(price2.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice2.Text = temp.ToString();
            }
        }

        private void price3_TextChanged(object sender, EventArgs e)
        {
            if (quant3.Value != 0 && price3.Text.Length > 0)
            {
                totalPrice3.Text = (double.Parse(quant3.Value.ToString()) * double.Parse(price3.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice3.Text = temp.ToString();
            }
        }

        private void quant3_ValueChanged(object sender, EventArgs e)
        {
            if (quant3.Value != 0 && price3.Text.Length > 0)
            {
                totalPrice3.Text = (double.Parse(quant3.Value.ToString()) * double.Parse(price3.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice3.Text = temp.ToString();
            }
        }

        private void price4_TextChanged(object sender, EventArgs e)
        {
            if (quant4.Value != 0 && price4.Text.Length > 0)
            {
                totalPrice4.Text = (double.Parse(quant4.Value.ToString()) * double.Parse(price4.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice4.Text = temp.ToString();
            }
        }

        private void quant4_ValueChanged(object sender, EventArgs e)
        {
            if (quant4.Value != 0 && price4.Text.Length > 0)
            {
                totalPrice4.Text = (double.Parse(quant4.Value.ToString()) * double.Parse(price4.Text)).ToString();
            }
            else
            {
                int temp = 0;
                totalPrice4.Text = temp.ToString();
            }
        }

        private void calc1_Click(object sender, EventArgs e)
        {
            if (totalPrice1.Text.Length == 0)
            {
                totalPrice1.Text = "0";
            }
            if (totalPrice2.Text.Length == 0)
            {
                totalPrice2.Text = "0";
            }
            if (totalPrice3.Text.Length == 0)
            {
                totalPrice3.Text = "0";
            }
            if (totalPrice4.Text.Length == 0)
            {
                totalPrice4.Text = "0";
            }
            subtotal.Text = (double.Parse(totalPrice1.Text) + double.Parse(totalPrice2.Text) + double.Parse(totalPrice3.Text) + double.Parse(totalPrice4.Text)).ToString();
            double taxrate = 0.07;
            salesTax.Text = (double.Parse(subtotal.Text) * taxrate).ToString();
            if (int.Parse(subtotal.Text) >= 75)
            {
                shipping.Text = "0";
            }
            if (int.Parse(subtotal.Text) < 75 && int.Parse(subtotal.Text) > 50)
            {
                shipping.Text = "10";
            }
            if (int.Parse(subtotal.Text) < 50 && int.Parse(subtotal.Text) > 20)
            {
                shipping.Text = "7.5";
            }
            if (int.Parse(subtotal.Text) < 20)
            {
                shipping.Text = "5";
            }
            grandTotal.Text = (double.Parse(subtotal.Text) + double.Parse(salesTax.Text) + double.Parse(shipping.Text)).ToString();
        }

        private void salesTax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}