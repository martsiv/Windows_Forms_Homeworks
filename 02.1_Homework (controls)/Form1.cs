using Microsoft.VisualBasic.ApplicationServices;
using System.Security;

namespace _02._1_Homework__controls_
{
    public partial class Form1 : Form
    {
        public int numberOfOrder { get; private set; }
        public double Price { get; private set; }
        private List<string> orders = new List<string>();

        public Form1()
        {
            InitializeComponent();
            numberOfOrder = 1;
            listBoxOrders.DataSource = orders;
        }
        private void radioButtonCheckedChanged(object sender, EventArgs e)
        {
            var checkedDrink = groupBoxDrinks.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var checkedFood = groupBoxFood.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var checkedDessert = groupBoxDessert.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            double price = 0;
            price += checkedDrink == null ? 0 : int.Parse(checkedDrink.Tag.ToString());
            price += checkedFood == null ? 0 : int.Parse(checkedFood?.Tag.ToString());
            price += checkedDessert == null ? 0 : int.Parse(checkedDessert.Tag.ToString());
            textBoxTotalPrice.Text = price + "$";
            Price = price;
            ChechIsButtonOrderActice();
        }
        private void MadeUncheckedAllRB()
        {
            groupBoxDrinks.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
            groupBoxFood.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
            groupBoxDessert.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);
        }
        private void UpdateOrdersList()
        {
            listBoxOrders.DataSource = null;
            listBoxOrders.DataSource = orders;
        }
        private void ChechIsButtonOrderActice()
        {
            if (groupBoxDrinks.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked) != null &&
                groupBoxFood.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked) != null &&
                groupBoxDessert.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked) != null)
                buttonOrder.Enabled = true;
            else
            { buttonOrder.Enabled = false; }
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string order = $"Number of order: {numberOfOrder}. Price: {Price}$. Date: {DateTime.Now.ToShortDateString()}";
            MessageBox.Show($"Price: {Price}$", $"Order number: {numberOfOrder}. Date: {DateTime.Now.ToShortDateString()}");
            orders.Add(order);
            UpdateOrdersList();
            MadeUncheckedAllRB();
            ++numberOfOrder;
        }
    }
}