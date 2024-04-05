namespace Catering_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double originalCost = 0;
            String plater = "";
            String pay = "";
            if (GormCheese.Checked)
            {
                plater = "Gormet Cheese";
                originalCost = 49.99;
            } else if (sausCheese.Checked)
            {
                plater = "Sausage And Cheese";
                originalCost = 49.99;
            } else if (veggie.Checked) {
                plater = "Veggie";
                originalCost = 29.99;
            }else if (fruit.Checked) {
                plater = "Fruit";
                originalCost = 29.99;
            }else if(pinwheel.Checked)
            {
                plater = "Pinwheel Wraps";
                originalCost = 59.99;
            }
            else
            {
                MessageBox.Show("No plater was selected");
            }
            if(!int.TryParse(loyaltyPoints.Text, out int points))
            {
                MessageBox.Show("Invalid input for loyalaty points");
            }
            double discount = ((points / 10) * 5 / originalCost) * originalCost;
            double cost = originalCost - discount;
            if(cost < 0)
            {
                cost = 0;
            }
            if(prePay.Checked)
            {
                pay = "Pre-Pay";
            }
            else {
                pay = "Pay on Pickup";
            }
            label3.Visible = true;
            label3.Text = "You ordered " + plater + " Platter costs $" + cost + " using " + pay + " after a discount of " + points + " loayalty points";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            loyaltyPoints.Clear();
            loyaltyPoints.Focus();
            label3.Visible = false;
        }
    }
}
