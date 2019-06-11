using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class AddStockForm : Form
    {
        public AddStockForm()
        {
            InitializeComponent();
        }

        public event Action<string, string, int,  int, double, double, DateTime> AddStock;
        public event Action FormClosed;

        public List<Stock> StockDatasource
        {
            set { stockBindingSource.DataSource = value; }
            get { return (List< Stock>) stockBindingSource.DataSource; }
        }

        private void addStockButton_Click(object sender, EventArgs e)
        {
            AddStock(suppliersTextBox.Text, productNameTextBox.Text, Convert.ToInt32(stockKodeTextBox.Text), Convert.ToInt32(amountTextBox.Text), Convert.ToDouble(priceTextBox.Text), Convert.ToDouble(kdvRateTextBox.Text), Convert.ToDateTime(dateTimePicker1.Text)); 
        }
             
        private void addStockFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
