using OrderStockSystem.DatabaseTables;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.CustomerForms
{
   public class CustomerManager
    {
        #region members

        private AddCustomerForm customerForm;
        private OrderDbContext db;
        private BindingSource bindingSource;

        #endregion members

        #region constructor
        public CustomerManager()
        {
            customerForm = new AddCustomerForm();
            db = new OrderDbContext();
            bindingSource = new BindingSource();          
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            customerForm.Show();
            customerEvents();

        }

        private void customerEvents()
        {
            customerForm.AddCustomer += addCustomer;
            customerForm.DeleteCustomer += deleteCustomer;
            customerForm.UpdateCustomer += updateCustomer;
            customerForm.List += list;
            customerForm.FormClosed += formClosed;  
        }

        private void addCustomer(int pCustomerKode, string pCompanyName, int pTelephone, int pMobilePhone, string pAuthorizedName, string pMail, string pAddress)
        {
            Customer customer = new Customer();
            customer.Customer_Kode = pCustomerKode;
            customer.Company_Name = pCompanyName;
            customer.Telephone = pTelephone;
            customer.Mobile_Phone = pMobilePhone;
            customer.Authorized_Name = pAuthorizedName;
            customer.Mail = pMail;
            customer.Address = pAddress;
            db.Customer.Add(customer);
            db.SaveChanges();
            MessageBox.Show("Müşteri Kayıdı Oluşturuldu.");
        }

        private void updateCustomer(int pCustomerId,int pCustomerKode, string pCompanyName, int pTelephone, int pMobilePhone, string pAuthorizedName, string pMail, string pAddress)
        {
            var update = db.Customer.Where(m => m.Customer_Id == pCustomerId).FirstOrDefault();
            update.Customer_Kode = pCustomerKode;
            update.Company_Name = pCompanyName;
            update.Telephone = pTelephone;
            update.Mobile_Phone = pMobilePhone;
            update.Authorized_Name = pAuthorizedName;
            update.Mail = pMail;
            update.Address = pAddress;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapılmıştır.");                       
        }

        private void deleteCustomer(int pCustomerId)
        {      
            var delete = db.Customer.Where(m => m.Customer_Id == pCustomerId).FirstOrDefault();
            db.Customer.Remove(delete);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir.");
        }
       
        private void list()
        {
           customerForm.CustomerDatasource= db.Customer.ToList();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
        #endregion methods
    }
}

