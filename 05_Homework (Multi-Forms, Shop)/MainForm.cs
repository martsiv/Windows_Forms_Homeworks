using System;
using System.Text.Json;

namespace _05_Lesson__Multi_Forms_
{
    public partial class MainForm : Form
    {
        List<Product> products = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            string jsonResult = File.ReadAllText("data.json");
            var peopleResult = JsonSerializer.Deserialize<List<Product>>(jsonResult);
            products = peopleResult?.ToList() ?? new List<Product>();
            //products.Add(new Product("Apple", 25, 5, "Ukraine", 5));
            listBoxProducts.DataSource = products;
        }
        private void UpdateProductList()
        {
            listBoxProducts.DataSource = null;
            listBoxProducts.DataSource = products;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            products.Remove(listBoxProducts.SelectedItem as Product);
            UpdateProductList();
        }
        private void Serialize()
        {
            string json = JsonSerializer.Serialize(products);
            File.WriteAllText("data.json", json);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                var product = form.Product;
                products.Add(product);
                UpdateProductList();
            }
            Serialize();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct(listBoxProducts.SelectedItem as Product);
            form.ShowDialog();
            UpdateProductList();
            Serialize();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FormProduct form = new FormProduct(listBoxProducts.SelectedItem as Product, true);
            form.Show();
        }
    }
}