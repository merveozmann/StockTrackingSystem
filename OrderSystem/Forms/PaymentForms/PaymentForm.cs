using System;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        public event Action List;
        public event Action PrepaymentList;
        public event Action CreditList;
        public event Action FormClosed;
        public Array  SalesDatasource
        {
            set { dataGridView1.DataSource = value;
                dataGridView1.Columns[0].HeaderText = "FİRMA_ADI";
                dataGridView1.Columns[1].HeaderText = "ÖDEME_NO";
                dataGridView1.Columns[2].HeaderText = "ÜRÜN_NO";
                dataGridView1.Columns[3].HeaderText = "KDVLİ_TUTAR";
                dataGridView1.Columns[4].HeaderText = "ÖDENEN";
                dataGridView1.Columns[5].HeaderText = "KALAN";
                dataGridView1.Columns[6].HeaderText = "AÇIKLAMA";
                dataGridView1.Columns[7].HeaderText = "NAKLİYE_TUTAR";
                dataGridView1.Columns[8].HeaderText = "ÖDEME_TARİHİ";
            }
            get { return(Array) dataGridView1.DataSource; }
        }

        
        private void prepaymentButton_Click(object sender, EventArgs e)
        {
            PrepaymentList();
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            CreditList();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void paymentFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
