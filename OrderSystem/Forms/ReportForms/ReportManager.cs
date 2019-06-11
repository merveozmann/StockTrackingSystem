using OrderStockSystem.DatabaseTables;
using OrderStockSystem.Forms.ReportForms;
using System.Linq;


namespace OrderStockSystem.Forms.ReportForms
{
    public class ReportManager
    {
        #region members
        private ReportForm reportForm;
        private OrderDbContext context;
        #endregion members

        #region constructor
        public ReportManager()
        {
            reportForm = new ReportForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            reportForm.Show();
            paymentEvents();
        }

        private void paymentEvents()
        {
            reportForm.Filter += filter;
            reportForm.List += list;
            reportForm.FormClosed += formClosed;
        }

        private void filter(string pCompanyName)
        {
            var query = from s in context.Sales
                        join m in context.Customer on s.CustomerId equals m.Customer_Id into list1
                        from l1 in list1.DefaultIfEmpty()
                        join u in context.Product on s.ProductId equals u.Product_Id into list2
                        from l2 in list2.DefaultIfEmpty()
                        where l1.Company_Name == pCompanyName
                        select new
                        {
                            pCompanyName = l1.Company_Name,
                            pProductName = l2.Product_Name,
                            pSalesKode = s.OrderKode,
                            pPayment = s.Payment_Amount,
                            pRemain = s.Remain_Amount,
                            pExplation = s.Explation,
                            pCollection = s.Collection_Date,
                            pForwarding = s.Forwarding_Amount,
                        };

            reportForm.ReportDatasource = query.ToArray();
            
        }

        private void list()
        {
            var query = from s in context.Sales
                        join m in context.Customer on s.CustomerId equals m.Customer_Id into list1
                        from l1 in list1.DefaultIfEmpty()
                        join u in context.Product on s.ProductId equals u.Product_Id into list2
                        from l2 in list2.DefaultIfEmpty()
                        select new
                        {
                            pCompanyName = l1.Company_Name,
                            pProductName = l2.Product_Name,
                            pSalesKode = s.OrderKode,
                            pPayment = s.Payment_Amount,
                            pRemain = s.Remain_Amount,
                            pExplation = s.Explation,
                            pCollection = s.Collection_Date,
                            pForwarding = s.Forwarding_Amount,
                        };

            reportForm.ReportDatasource = query.ToArray();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
        #endregion methods
    }
}
