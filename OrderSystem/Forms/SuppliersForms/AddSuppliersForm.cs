using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class AddSuppliersForm : Form
    {
        public AddSuppliersForm()
        {
            InitializeComponent();
        }
        public event Action<int,string,int,string,int,string,string> AddSuplier;
        public event Action<int,int,string, int, string, int, string, string> UpdateSuplier;
        public event Action<int> DeleteSupplier;
        public event Action FormClosed;
        public event Action List;

        public List<Suppliers> SupplierDatasource
        {
            set { suppliersBindingSource.DataSource = value; }
            get { return (List<Suppliers>)suppliersBindingSource.DataSource; }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateSuplier(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(suppliersTextBox.Text), companyTextBox.Text, Convert.ToInt32(telephoneTextBox.Text), authorizedTextBox.Text, Convert.ToInt32(authorizedTelephoneTextBox.Text), mailTextBox.Text, addressTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSupplier(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddSuplier(Convert.ToInt32(suppliersTextBox.Text), companyTextBox.Text, Convert.ToInt32(telephoneTextBox.Text), authorizedTextBox.Text, Convert.ToInt32(authorizedTelephoneTextBox.Text), mailTextBox.Text, addressTextBox.Text);
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void addSuppliersFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
