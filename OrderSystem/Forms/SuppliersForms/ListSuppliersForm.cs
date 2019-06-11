using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class ListSuppliersForm : Form
    {
        public ListSuppliersForm()
        {
            InitializeComponent();
        }

        public event Action<string> Filter;
        public event Action FormClosed;
        public event Action List;
       
        public List<Suppliers> SupplierDatasource
        {
            set { suppliersBindingSource.DataSource = value; }
            get { return (List<Suppliers>)suppliersBindingSource.DataSource; }
        }
        
        private void filterButton_Click(object sender, EventArgs e)
        {
            Filter(supplierTextBox.Text);         
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();   
        }

        private void listSuppliersFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
