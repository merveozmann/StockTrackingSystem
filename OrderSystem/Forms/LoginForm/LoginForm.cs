using System;
using System.Windows.Forms;

namespace OrderStockSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public event Action<string,int> Login;

        private void loginButton_Click(object sender, EventArgs e)
        {

            Login(userNameTextBox.Text, Convert.ToInt32(passwordTextBox.Text));
                      
        }
      
    }
}
