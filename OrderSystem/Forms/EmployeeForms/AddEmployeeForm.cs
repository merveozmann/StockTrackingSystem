using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        public event Action<string ,string,string,DateTime> AddEmployee;
        public event Action<int,string, string, string, DateTime> UpdateEmployee;
        public event Action<int> DeleteEmployee;
        public event Action FormClosed;
        public event Action List;
        public List<Employee> EmployeeDatasource
        {
            set { employeeBindingSource.DataSource = value; }
            get { return (List<Employee>)employeeBindingSource.DataSource; }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployee(nameTextBox.Text, degreeTextBox.Text, mailTextBox.Text, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateEmployee(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), nameTextBox.Text, degreeTextBox.Text, mailTextBox.Text, Convert.ToDateTime(dateTimePicker1.Text));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteEmployee(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            List();
        }

        private void addEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }
    }
}
