using OrderStockSystem.DatabaseTables;
using System.Linq;

namespace OrderStockSystem.Forms.PaymentForms
{
   public class PaymentManager
    {
        #region members
        private PaymentForm paymentForm;
        private OrderDbContext context;
        #endregion members

        #region constructor
        public PaymentManager()
        {
            paymentForm = new PaymentForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            paymentForm.Show();
            paymentEvents();
        }

        private void paymentEvents()
        {
            paymentForm.List += list;
            paymentForm.PrepaymentList += prepaymentlist;
            paymentForm.CreditList += creditlist;
            paymentForm.FormClosed += formClosed;
        }

        private void creditlist()
        {
             var query = from sd in context.Sales
                         join m in context.Customer on sd.CustomerId equals m.Customer_Id into list1
                         from l1 in list1.DefaultIfEmpty()
                         where sd.State == 0
                         select new
                         {
                             pCompanyName = l1.Company_Name,
                             pOrderCode = sd.OrderKode,
                             pPaymentCode = sd.Payment_Kode,
                             pKdvAmount = sd.KDV_Amount,
                             pPaymentAmount = sd.Payment_Amount,
                             pRemainAmount = sd.Remain_Amount,
                             pExplation = sd.Explation,
                             pFowardingAmount = sd.Forwarding_Amount,
                             pCollectionDate = sd.Collection_Date,
                         };

             paymentForm.SalesDatasource = query.ToArray();
            
        }

        private void prepaymentlist()
        {
             var query = from sd in context.Sales
                       join m in context.Customer on sd.CustomerId equals m.Customer_Id into list1
                       from l1 in list1.DefaultIfEmpty()
                       where sd.State == 1
                       select new
                       {
                           pCompanyName = l1.Company_Name,
                           pOrderCode = sd.OrderKode,
                           pPaymentCode = sd.Payment_Kode,
                           pKdvAmount = sd.KDV_Amount,
                           pPaymentAmount = sd.Payment_Amount,
                           pRemainAmount = sd.Remain_Amount,
                           pExplation = sd.Explation,
                           pFowardingAmount = sd.Forwarding_Amount,
                           pCollectionDate = sd.Collection_Date,
                       };

           paymentForm.SalesDatasource = query.ToArray();
        }

        private void list()
        {
            var query = from sd in context.Sales
                        join m in context.Customer on sd.CustomerId equals m.Customer_Id into list1
                        from l1 in list1.DefaultIfEmpty()

                        select new
                        {
                            pCompanyName = l1.Company_Name,
                            pOrderCode = sd.OrderKode,
                            pPaymentCode = sd.Payment_Kode,
                            pKdvAmount = sd.KDV_Amount,
                            pPaymentAmount = sd.Payment_Amount,
                            pRemainAmount = sd.Remain_Amount,
                            pExplation = sd.Explation,
                            pFowardingAmount = sd.Forwarding_Amount,
                            pCollectionDate = sd.Collection_Date,
                        };

            paymentForm.SalesDatasource = query.ToArray();

        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
        #endregion methods
    }
}
