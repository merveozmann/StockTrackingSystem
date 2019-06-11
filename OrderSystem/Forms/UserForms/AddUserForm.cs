using OrderStockSystem.DatabaseTables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        public event Action<string,int,int,string,int> AddUser;
        public event Action List;
        public event Action<int, string, int, int, string, int> UpdateUser;
        public event Action<int> DeleteUser;
        public event Action FormClosed;
        public List<User> UserDatasource
        {
            get { return (List<User>)userBindingSource.DataSource; }
            set { userBindingSource.DataSource = value; }
        }        
        public byte UserState
        {         
            set { activeRadioButton.Checked = true;   }
            get { return  Convert.ToByte( activeRadioButton.Checked); }
        } 
      
        private void addButton_Click(object sender, EventArgs e)
        {
            AddUser(NameTextBox.Text, Convert.ToInt32(passwordTextBox.Text),Convert.ToByte(activeRadioButton.Checked),addressTextBox.Text, Convert.ToInt32(telephoneTextBox.Text));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateUser(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), NameTextBox.Text, Convert.ToInt32(passwordTextBox.Text), Convert.ToByte(activeRadioButton.Checked), addressTextBox.Text, Convert.ToInt32(telephoneTextBox.Text));
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteUser(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
        }

        private void listButton_Click(object sender, EventArgs e)
        {          
            List();
        }

        private void addUserFormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosed();
        }

       
    }
}
