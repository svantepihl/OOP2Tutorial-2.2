using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Tutorial_2_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Create binding datasource
        BindingList<Product> data =new BindingList<Product>();
        
        private void ShowData()
        {
            // Add binding datasource to ProductList
            ProductList.DataSource = data;
        }
        
        /// <summary>
        /// Adds new product to ProductList (listbox) based on values in ProductPriceField and ProductNameField.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ProductPriceField.Text, out int i))
            {
                try
                {
                    Product tmp = new Product {Name = ProductNameField.Text, Price = int.Parse(ProductPriceField.Text)};
                    ProductList.Items.Add(tmp);
                    ProductNameField.Text = "";
                    ProductPriceField.Text = "";
                }
                catch (NullValueException error)
                {
                    MessageBox.Show(error.Message);
                }
                catch (ValueOutOfBoundException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Don't forget to add a valid price!");
            }
        }
        /// <summary>
        /// Updates selected object in ProductList (listbox) with new name and/or new price. Remains unchanged if input field is empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            int index = ProductList.SelectedIndex;
            if (index != -1)
            {
                Product tmp = ProductList.SelectedItem as Product;
                if (tmp == null)
                {
                    return;
                }
                ProductList.Items.RemoveAt(index);

                if (int.TryParse(ProductPriceField.Text,out int i))
                {
                    try
                    {
                        tmp.Price = i;
                        ProductNameField.Text = "";
                    }
                    catch (ValueOutOfBoundException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }

                if (!String.IsNullOrEmpty(ProductNameField.Text))
                {
                    try
                    {
                        tmp.Name = ProductNameField.Text;
                        ProductPriceField.Text = "";
                    }
                    catch (NullValueException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                ProductList.Items.Insert(index,tmp);


            }
        }
    }
}