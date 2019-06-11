using OrderStockSystem.DatabaseTables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OrderStockSystem.Forms.EmployeeForms
{
    public class EmployeeManager
    {
        #region members
        private AddEmployeeForm employeeForm;
        private OrderDbContext context;
        private BindingSource bindingSource;
        #endregion members

        #region constructor
        public EmployeeManager()
        {
            employeeForm = new AddEmployeeForm();
            context = new OrderDbContext();
            bindingSource = new BindingSource();
        }
        #endregion constructor

        #region methods
        public void Show()
        {
            employeeForm.Show();
            employeeEvents();
        }

        private void employeeEvents()
        {
            employeeForm.AddEmployee += addEmployee;
            employeeForm.UpdateEmployee += updateEmployee;
            employeeForm.DeleteEmployee += deleteEmployee;
            employeeForm.FormClosed += formClosed;
            employeeForm.List += list;
        }

        private void addEmployee(string pName, string pDegree, string pMail, DateTime pDate)
        {
            Employee employee = new Employee();
            employee.Name_Surname = pName;
            employee.Degree = pDegree;
            employee.Mail = pMail;
            employee.Star_Date = pDate;
            context.Employee.Add(employee);
            context.SaveChanges();
            MessageBox.Show("Personel Kayıdı Oluşturuldu");
        }

        private void updateEmployee(int pEmployeeId, string pName, string pDegree, string pMail, DateTime pDate)
        {
            var update = context.Employee.Where(m => m.Employee_Id == pEmployeeId).FirstOrDefault();
            update.Name_Surname = pName;
            update.Degree = pDegree;
            update.Mail = pMail;
            update.Star_Date = pDate;
            context.SaveChanges();
            MessageBox.Show("Kayıt güncellendi");
        }

        private void deleteEmployee(int pEmployeeId)
        {
            var delete = context.Employee.Where(m => m.Employee_Id == pEmployeeId).FirstOrDefault();
            context.Employee.Remove(delete);
            context.SaveChanges();
            MessageBox.Show("Kayıt silindi");
        }

        private void list()
        {
            employeeForm.EmployeeDatasource = context.Employee.ToList();
        }

        private void formClosed()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        #endregion methods

    }
}
