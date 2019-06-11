using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.CustomerForms
{
    public partial class AddCustomerForm : Form
    {
      
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        public event Action<int,string,int ,int,string,string,string> AddCustomer;
        public event Action<int,int, string, int, int, string, string, string> UpdateCustomer;
        public event Action<int> DeleteCustomer;
        public event Action List;  
        public event Action FormClosed;
        public List< Customer > CustomerDatasource
        {
            set { customerBindingSource1.DataSource = value; }
            get {return (List<Customer>) customerBindingSource1.DataSource; }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCustomer(Convert.ToInt32(customerKodeTextBox.Text), companyTextBox.Text, Convert.ToInt32(telephoneTextBox.Text), Convert.ToInt32(mobileTelephoneTextBox.Text), authorizeNameTextBox.Text, mailTextBox.Text, addressTextBox.Text); 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteCustomer(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateCustomer(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(customerKodeTextBox.Text), companyTextBox.Text, Convert.ToInt32(telephoneTextBox.Text), Convert.ToInt32(mobileTelephoneTextBox.Text), authorizeNameTextBox.Text, mailTextBox.Text, addressTextBox.Text);
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void addCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }

    }
}
