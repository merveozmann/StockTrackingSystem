using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class ListProductForm : Form
    {
        public ListProductForm()
        {
            InitializeComponent();
        }
        
        public event Action<string> Filter;
        public event Action List;
        public event Action FormClosed;

        public List<Product> ProductDatasource
        {
            set { productBindingSource.DataSource = value; }
            get { return (List<Product>)productBindingSource.DataSource; }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {           
            Filter(filterTextBox.Text);                      
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void listProductFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
