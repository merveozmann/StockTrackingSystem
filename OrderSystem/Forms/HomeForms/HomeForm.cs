using OrderStockSystem.Forms.CustomerForms;
using OrderStockSystem.Forms.EmployeeForms;
using OrderStockSystem.Forms.PaymentForms;
using OrderStockSystem.Forms.ProductForms;
using OrderStockSystem.Forms.ReportForms;
using OrderStockSystem.Forms.SalesForms;
using OrderStockSystem.Forms.StockForms;
using OrderStockSystem.Forms.SuppliersForms;
using OrderStockSystem.Forms.UserForms;
using System;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void stockAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManager stockManager = new StockManager();
            stockManager.Show();
        }
       
        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockManager stockManager = new StockManager();
            stockManager.Showlist();
        }

        private void salesAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesManager salesManager = new SalesManager();
            salesManager.Show();
        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            productManager.AddShow();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            productManager.ListShow();
        }

        private void suppliersAddToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SuppliersManager suppliersManager = new SuppliersManager();
            suppliersManager.AddShow();
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersManager suppliersManager = new SuppliersManager();
            suppliersManager.ListShow();
        }

        private void customerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentManager paymentManager = new PaymentManager();
            paymentManager.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportManager reportManager = new ReportManager();
            reportManager.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            userManager.Show();
        }

    }
}
