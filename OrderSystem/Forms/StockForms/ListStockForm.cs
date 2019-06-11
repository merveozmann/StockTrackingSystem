using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class ListStockForm : Form
    {
        public ListStockForm()
        {
            InitializeComponent();
        }

        public event Action<string, DateTime> Filter;
        public event Action List;
        public event Action FormClosed;

        public List<Stock> StockDatasource
        {
            set { stockBindingSource.DataSource = value; }
            get { return (List<Stock>)stockBindingSource.DataSource; }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Filter(supplierTextBox.Text, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void listStockFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

       
    }
}
