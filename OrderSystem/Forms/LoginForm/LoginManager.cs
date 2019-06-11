using OrderStockSystem.DatabaseTables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public class LoginManager
    {
        
        #region members
        private LoginForm loginForm;
        private OrderDbContext db;
        #endregion members

        #region constructor
        public LoginManager()
        {
            loginForm = new LoginForm();
            db = new OrderDbContext();
        }
        #endregion

        #region methods

        public Boolean Show()
        {
            loginEvents();
            return loginForm.ShowDialog() == DialogResult.OK;
        }  
        
        private void loginEvents()
        {         
            loginForm.Login += userLogin;                               
        }

        private void userLogin(string pUsername, int pPassword)
        {                            
            Manager manager = db.Manager.Where(m => m.User_Adi == pUsername && m.Password == pPassword).SingleOrDefault();

            if (manager == null)
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            else
            {
                loginForm.DialogResult = DialogResult.OK;
            }
        }
        #endregion methods

    }
}
