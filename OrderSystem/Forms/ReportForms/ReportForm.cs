using System;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        public event Action<string> Filter;
        public event Action List;
        public event Action FormClosed;
        public Array ReportDatasource
        {
            set { dataGridView1.DataSource = value;
                dataGridView1.Columns[0].HeaderText = "FİRMA_ADI";
                dataGridView1.Columns[1].HeaderText = "ÜRÜN_ADI";
                dataGridView1.Columns[2].HeaderText = "SATIŞ_KODU";
                dataGridView1.Columns[3].HeaderText = "ÖDENEN";
                dataGridView1.Columns[4].HeaderText = "KALAN";
                dataGridView1.Columns[5].HeaderText = "AÇIKLAMA";
                dataGridView1.Columns[6].HeaderText = "ÖDEME_TARİHİ";
                dataGridView1.Columns[7].HeaderText = "NAKLİYE";
            }
            get { return (Array) dataGridView1.DataSource; }
        }
       
        private void selectedCustomerButton_Click(object sender, EventArgs e)
        {
            Filter(companyNameTextBox.Text);
        }

        private void salesListButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void reportForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
