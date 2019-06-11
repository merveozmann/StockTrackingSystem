using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.StockForms
{
    public class StockManager
    {
        #region members
        private AddStockForm addstockForm;
        private ListStockForm liststockForm;
        private OrderDbContext context;
        #endregion members

        #region constructor
        public StockManager()
        {
            addstockForm = new AddStockForm();
            liststockForm = new ListStockForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods

        #region addstockform

        public void Show()
        {
            addstockForm.Show();
            addStockEvents();
        }

        private void addStockEvents()
        {
            addstockForm.AddStock += addStock;
            addstockForm.FormClosed += formClosed;
        }

        private void addStock(string pSupplierText, string pProductText, int pStockkode, int pAmount, double pPrice, double pKdvRate, DateTime pDate)
        {
            #region sqlquery
            Stock stock = new Stock();

            var query = from c in context.Suppliers
                        where c.Company_Name == pSupplierText
                        select c;

            var kode = query.FirstOrDefault<Suppliers>();

            var query2 = from c in context.Product
                         where c.Product_Name == pProductText
                         select c;

            var kode2 = query2.FirstOrDefault<Product>();
            stock.Stock_Kode = pStockkode;
            stock.SuppliersKode = kode.Suppliers_kode;
            stock.SuppliersId = kode.Suppliers_Id;
            stock.ProductKode = kode2.Product_Kode;
            stock.ProductId = kode2.Product_Id;
            stock.Amount = pAmount;
            stock.Price = pPrice;
            stock.KDV_Rate = pKdvRate;
            stock.Stock_Date = pDate;
            context.Stock.Add(stock);
            context.SaveChanges();
            MessageBox.Show("Stok girişi yapıldı.");
            #endregion sqlquery
            liststockForm.StockDatasource = context.Stock.ToList();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        #endregion addstockform

        #region liststockform

        public void Showlist()
        {
            liststockForm.Show();
            listEvents();
        }

        private void listEvents()
        {
            liststockForm.Filter += filter;
            liststockForm.List += stockList;
            liststockForm.FormClosed += liststockForm_formClosed;
        }
    
        private void stockList()
        {
            liststockForm.StockDatasource = context.Stock.ToList();
        }

        private void filter(string pStockName, DateTime pDate)
        {
            var query = from c in context.Suppliers
                        where c.Company_Name == pStockName
                        select c;

            var kod = query.FirstOrDefault<Suppliers>();
            var query2 = from i in context.Stock
                         where i.Stock_Date == pDate
                         select i;
            var kod2 = query2.FirstOrDefault<Stock>();

            if (kod.Company_Name ==pStockName || kod2.Stock_Date == pDate)
            {
                liststockForm.StockDatasource = context.Stock.ToList();

            }
        }

        private void liststockForm_formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
        #endregion liststockform


        #endregion methods
    }
}
