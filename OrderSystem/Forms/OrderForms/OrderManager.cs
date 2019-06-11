using OrderStockSystem.DatabaseTables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.OrderForms
{
   public class OrderManager
    {
        #region members
        private OrderForm orderForm;
        private OrderDbContext context;
        private int customerId, customerKode, productId, productkode;
        #endregion members

        #region constructor
        public OrderManager()
        {
            orderForm = new OrderForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            orderForm.Show();
            orderEvents();
        }
        private void orderEvents()
        {
            orderForm.DropStock += dropStock;
            orderForm.AddPayment += addPayment;
            orderForm.List += list;
            orderForm.FormClosed += formClosed;
        }

        private void addPayment(int pPaymentKode, int pSalesKode, double pKdvAmount, double pPaymentAmount, double pRemainAmount, DateTime pDate, string pExplation, byte pState, DateTime pColletionDate, double pFowardingAmount)
        {
            #region sqlquery
            var query = context.SalesOrder.Where(m => m.Order_Kode == pSalesKode).FirstOrDefault();
            int pOrderId = query.Order_Id;
            pSalesKode = query.Order_Kode;
            customerId = query.CustomerId;
            customerKode = query.CustomerKode;
            productId = query.ProductId;
            productkode = query.ProductKode;

            Sales sales = new Sales();
            sales.Payment_Kode = pPaymentKode;
            sales.OrderId = pOrderId;
            sales.OrderKode = pSalesKode;
            sales.KDV_Amount = pKdvAmount;
            sales.Payment_Amount = pPaymentAmount;
            sales.Remain_Amount = pRemainAmount;
            sales.Date = pDate;
            sales.Explation = pExplation;
            sales.State = orderForm.StateChecked;
            sales.Collection_Date = pColletionDate;
            sales.Forwarding_Amount = pFowardingAmount;
            sales.CustomerId = customerId;
            sales.CustomerKode = customerKode;
            sales.ProductId = productId;
            sales.ProductKode = productkode;
            context.Sales.Add(sales);
            context.SaveChanges();

            var lower = context.SalesOrder.Where(m => m.Order_Id == pOrderId).FirstOrDefault();
            lower.Control = true;
            context.SaveChanges();
            MessageBox.Show("Ödeme başarı ile oluşturuldu.", "Bilgilendirme Penceresi");
            #endregion sqlquery
        }

        private void dropStock(int pProductKode, int pStockTotal, int pStockDrop)
        {
            int pStockNew = pStockTotal - pStockDrop;
            var stock = context.Stock.Where(m => m.ProductKode == productkode).FirstOrDefault();
            stock.Amount = pStockNew;
            context.SaveChanges();
            MessageBox.Show("Stoktan Düşürüldü");
        }

        private void list()
        {
            orderForm.SalesDatasource = context.Sales.ToList();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
        #endregion methods
    }
}
