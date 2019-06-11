using OrderStockSystem.DatabaseTables;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.SuppliersForms
{
    public class SuppliersManager
    {
        #region members
        private AddSuppliersForm addSuppliersForm;
        private ListSuppliersForm listSuppliersForm;
        private OrderDbContext context;
        #endregion members

        #region constructor
        public  SuppliersManager()
        {
            addSuppliersForm = new AddSuppliersForm();
            listSuppliersForm = new ListSuppliersForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods

        #region addsupplierform

        public void AddShow()
        {
            addSuppliersForm.Show();
            addSupplierEvents();
        }
        private void addSupplierEvents()
        {
            addSuppliersForm.AddSuplier += addSupplier;
            addSuppliersForm.UpdateSuplier += updateSupplier;
            addSuppliersForm.DeleteSupplier += deleteSupplier;
            addSuppliersForm.FormClosed += formClosed;
            addSuppliersForm.List += list;
        }

        private void addSupplier(int pKode, string pCompanyName, int pTelephone, string pAuthorizedName, int pAuthorizedTelephon, string pMail, string pAddress)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Suppliers_kode = pKode;
            suppliers.Company_Name = pCompanyName;
            suppliers.Telephone = pTelephone;
            suppliers.Authorized_Name = pAuthorizedName;
            suppliers.Authorized_Telephone = pAuthorizedTelephon;
            suppliers.Mail = pMail;
            suppliers.Address = pAddress;
            context.Suppliers.Add(suppliers);
            context.SaveChanges();
            MessageBox.Show("Tedarikçi Kayıdı oluşturuldu.");
        }

        private void updateSupplier(int pSupplierId, int pKode, string pCompanyName, int pTelephone, string pAuthorizedName, int pAuthorizedTelephon, string pMail, string pAddress)
        {
            var update = context.Suppliers.Where(m => m.Suppliers_Id == pSupplierId).FirstOrDefault();
            update.Suppliers_kode = pKode;
            update.Company_Name = pCompanyName;
            update.Telephone = pTelephone;
            update.Authorized_Name = pAuthorizedName;
            update.Authorized_Telephone = pAuthorizedTelephon;
            update.Mail = pMail;
            update.Address = pAddress;
            context.SaveChanges();
            MessageBox.Show("Tedarikçi Kayıdı güncellendi.");
        }

        private void deleteSupplier(int pSupplierId)
        {
            var delete = context.Suppliers.Where(m => m.Suppliers_Id == pSupplierId).FirstOrDefault();
            context.Suppliers.Remove(delete);
            context.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir.");
        }

        private void list()
        {
            addSuppliersForm.SupplierDatasource = context.Suppliers.ToList();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        #endregion addsupplierform

        #region listsupplierform

        public void ListShow()
        {
            listSuppliersForm.Show();
            listSupplierEvents();
        }

        private void listSupplierEvents()
        {
            listSuppliersForm.Filter += filter;
            listSuppliersForm.FormClosed += listSuppliersForm_formClosed; ;
            listSuppliersForm.List += listSuppliersForm_list;
        }

        private void listSuppliersForm_list()
        {
            listSuppliersForm.SupplierDatasource = context.Suppliers.ToList();
        }

        private void filter(string pSupplierName)
        {
            var query = from c in context.Suppliers
                        where c.Company_Name == pSupplierName
                        select c;
            listSuppliersForm.SupplierDatasource = query.ToList();
        }

        private void listSuppliersForm_formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        #endregion listsupplierform

        #endregion methods

    }
}
