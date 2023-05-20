using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Lesson__Multi_Forms_
{
    public partial class FormProduct : Form
    {
        public Product Product { get; set; }
        public FormProduct()
        {
            InitializeComponent();
            this.Text = "New product";
            buttonOK.Enabled = false;
        }

        public FormProduct(Product newProd, bool readOnly = false)
        {
            InitializeComponent();
            Product = newProd;
            textBoxName.Text = newProd.Name;
            comboBoxCountry.Text = newProd.Country;
            numericPrice.Value = newProd.Price;
            numericDiscount.Value = newProd.DiscountPercent;
            numericQuantity.Value = newProd.Quantity;
            buttonOK.Enabled = false;
            if (readOnly)
            {
                textBoxName.Enabled = false;
                comboBoxCountry.Enabled = false;
                numericDiscount.Enabled = false;
                numericPrice.Enabled = false;
                numericQuantity.Enabled = false;
                buttonOK.Enabled = true;
            }
            this.Text = "Product " + Product.Name;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Product == null)
                Product = new Product();
            Product.Name = textBoxName.Text;
            Product.Price = numericPrice.Value;
            Product.Quantity = (int)numericQuantity.Value;
            Product.Country = comboBoxCountry.Text;
            Product.DiscountPercent = (int)numericDiscount.Value;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckedButtonOK(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || comboBoxCountry.SelectedItem == null)
                buttonOK.Enabled = false;
            else
                buttonOK.Enabled = true;
        }
    }
}
