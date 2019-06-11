using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class AddSalesForm : Form
    {
        public AddSalesForm()
        {
            InitializeComponent();
        }

        public event Action<string,string,int,int,double,double,double,double,DateTime> AddSales;
        public event Action List;
        public event Action<int, string, string, string, string, string, string> Value;
        public event Action FormClosed;
        public List<SalesOrder> OrderDatasoruce
        {
            set { salesOrderBindingSource.DataSource = value; }
            get { return (List<SalesOrder>) salesOrderBindingSource.DataSource; }
        }


        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddSales(customerTextBox.Text, productTextBox.Text, Convert.ToInt32(salesKodeTextBox.Text), Convert.ToInt32(pieceTextBox.Text), Convert.ToDouble(AmountTextBox.Text), Convert.ToDouble(kdvliTotalTextBox.Text), Convert.ToDouble(kdvRateTextBox.Text), Convert.ToDouble(unitPriceTextBox.Text), Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            Value(dataGridView1.SelectedCells[0].RowIndex,dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString(), dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[6].Value.ToString(), dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString(), dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[11].Value.ToString(), dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString());
        }

        private void listOrderButton_Click(object sender, EventArgs e)
        {
            List();
        }       

        private void addSalesFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }

    }
}

