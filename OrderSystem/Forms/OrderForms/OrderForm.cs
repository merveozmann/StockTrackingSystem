using OrderStockSystem.DatabaseTables;
using OrderStockSystem.Forms.SalesForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public event Action<int, int, double, double, double, DateTime, string, byte,DateTime, double> AddPayment;
        public event Action<int,int,int> DropStock;
        public event Action List;
        public event Action FormClosed;
        public List<Sales> SalesDatasource
        {
            set { salesBindingSource.DataSource = value; }
            get {return (List<Sales>)salesBindingSource.DataSource; }
        }   
        public byte StateChecked
        {
            set { paymenRadiobutton.Checked = true; }
            get { return Convert.ToByte(paymenRadiobutton.Checked); }
        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            AddPayment(Convert.ToInt32(paymentKodeTextBox.Text), Convert.ToInt32(salesKodeTextBox.Text), Convert.ToDouble(kdvTotalAmountTextBox.Text),
            Convert.ToDouble(paymentTextBox.Text), Convert.ToDouble(remainTextBox.Text), dateTimePicker1.Value, explationTextBox.Text,
            Convert.ToByte( paymenRadiobutton.Checked),dateTimePicker2.Value, Convert.ToDouble(fowardingTotalTextBox.Text));    
        }

        private void dropStockButton_Click(object sender, EventArgs e)
        {
            DropStock(Convert.ToInt32(productNameTextBox.Text), Convert.ToInt32(amountProductTextBox.Text), Convert.ToInt32(dropAmountTextBox.Text));
        }
    
        private void orderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            salesKodeTextBox.Text = SalesManager.SalesNo;
            kdvRateTextBox.Text = SalesManager.KdvRatee;
            totalTextBox.Text = SalesManager.Total;
            kdvTotalAmountTextBox.Text = SalesManager.KdvTotal;
            productNameTextBox.Text = SalesManager.ProductKode.ToString();
            amountProductTextBox.Text = SalesManager.Amount.ToString();
            debtTextBox.Text = SalesManager.KdvTotal;
            dropAmountTextBox.Text = SalesManager.StockAmount;
        }
    }
}
