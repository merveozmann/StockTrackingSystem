using OrderStockSystem.DatabaseTables;
using OrderStockSystem.Forms.OrderForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.SalesForms
{
   public class SalesManager
    {
       
        #region members
        private AddSalesForm salesForm;
        private OrderDbContext context;
        public static int ProductKode,Amount,No;
        public static string SalesNo, KdvRatee, KdvTotal, Total, StockAmount, Id;
        #endregion members

        #region constructor
        public SalesManager()
        {
            salesForm = new AddSalesForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            salesForm.Show();
            salesEvents();
        }

        private void salesEvents()
        {
            salesForm.AddSales += addSales;
            salesForm.List += list;
            salesForm.Value += value;
            salesForm.FormClosed += formClosed;
        }

        private void addSales(string pCustomer, string pProduct, int pKode, int pPiece, double pAmount, double pKdvtotal, double pKdvrate, double pUnitprice, DateTime pDate)
        {
            #region sqlquery
            SalesOrder sales = new SalesOrder();

            var query = from c in context.Customer
                        where c.Company_Name == pCustomer
                        select c;
            var customerquery = query.FirstOrDefault<Customer>();


            var query2 = from c in context.Product
                         where c.Product_Name == pProduct
                         select c;
            var productquery = query2.FirstOrDefault<Product>();

            sales.Order_Kode = pKode;
            sales.CustomerId = customerquery.Customer_Id;
            sales.CustomerKode = customerquery.Customer_Kode;
            sales.ProductKode = productquery.Product_Kode;
            sales.ProductId = productquery.Product_Id;
            sales.Sales_Piece = pPiece;
            sales.Sales_Total = pAmount;
            sales.Sales_KDV_Total = pKdvtotal;
            sales.KDV_Rate = pKdvrate;
            sales.Unit_Price = pUnitprice;
            sales.Sales_Date = pDate;
            sales.Control = false;
            context.SalesOrder.Add(sales);
            context.SaveChanges();
            MessageBox.Show("Satış başarı ile oluşturuldu.", "Bilgilendirme Penceresi");
            #endregion sqlquery
        }

        private void value(int pNo, string pSalesNo, string pKdevRate, string pKdvTotal, string pTotal, string pProductkode, string pStockAmount)
        {
            SalesNo = (No + 1).ToString();
            SalesNo = pSalesNo;
            KdvRatee = pKdevRate;
            Total = pKdvTotal;
            KdvTotal = pTotal;
            ProductKode =Convert.ToInt32( pProductkode);
            StockAmount = pStockAmount;

            Stock stock = new Stock();
            var query = context.Stock.Where(m => m.ProductKode == ProductKode).FirstOrDefault();
            Amount = query.Amount;
            OrderManager orderManager = new OrderManager();
            orderManager.Show();
            salesForm.Hide();
        }

        private void list()
        {
           var query = from c in context.SalesOrder
                    where c.Control == false
                    select c;
            salesForm.OrderDatasoruce = query.ToList();           
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

       
        #endregion merhods
    }
}
