using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
     
        public event Action<int,string,int,string,string,string,string,int,string> AddProduct;
        public event Action<int,int, string, int, string, string, string, string, int, string> UpdateProduct;
        public event Action<int> DeleteProduct;
        public event Action FormClosed;
        public event Action List;

        public List<Product> ProductDatasource
        {
            set { productBindingSource.DataSource = value; }
            get { return (List<Product>)productBindingSource.DataSource; }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddProduct(Convert.ToInt32(productKodeTextBox.Text), productNameTextBox.Text, Convert.ToInt32(AmountTextBox.Text), MemoryTextBox.Text, areaUseTextBox.Text, diskTextBox.Text, rotationSpeedTextBox.Text,Convert.ToInt32( warrantyTextBox.Text), sizeTextBox.Text);
        }
        
        private void updateButton_Click(object sender, EventArgs e)
        {           
            UpdateProduct(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),Convert.ToInt32(productKodeTextBox.Text), productNameTextBox.Text, Convert.ToInt32(AmountTextBox.Text), MemoryTextBox.Text, areaUseTextBox.Text, diskTextBox.Text, rotationSpeedTextBox.Text, Convert.ToInt32(warrantyTextBox.Text), sizeTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteProduct(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
        }

        private void addProductFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }
    }
}
