using OrderStockSystem.DatabaseTables;
using System.Linq;

namespace OrderStockSystem.Forms.UserForms
{
    public class UserManager
    {
        #region members
        private AddUserForm userForm;
        private OrderDbContext context;
        #endregion members

        #region constructor
        public UserManager()
        {
            userForm = new AddUserForm();
            context = new OrderDbContext();
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            userForm.Show();
            userEvents();
        }
        private void userEvents()
        {
            userForm.AddUser += addUser;
            userForm.UpdateUser += updateUser;
            userForm.DeleteUser += deleteUser;
            userForm.List += list;
            userForm.FormClosed += formClosed;

        }

        private void addUser(string pName, int pPassword, int pState, string pAddress, int pTelephone)
        {
            User user = new User();
            user.Name_Surname = pName;
            user.Password = pPassword;
            user.Status = userForm.UserState;
            user.Address = pAddress;
            user.Telephone = pTelephone;
            context.User.Add(user);
            context.SaveChanges();
        }

        private void updateUser(int pUserId,string pName, int pPassword, int pState, string pAddress, int pTelephone)
        {
            var update = context.User.Where(m => m.User_Id == pUserId).FirstOrDefault();
            update.Name_Surname = pName;
            update.Password = pPassword;
            update.Status = userForm.UserState;
            update.Address = pAddress;
            update.Telephone = pTelephone;
            context.SaveChanges();
        }

        private void list()
        {
          userForm.UserDatasource=  context.User.ToList();
        }

        private void deleteUser(int pUserId)
        {
            var delete = context.User.Where(m => m.User_Id == pUserId).FirstOrDefault();
            context.User.Remove(delete);
            context.SaveChanges();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        #endregion methods
    }
}
