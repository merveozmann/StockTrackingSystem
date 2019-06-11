using System;
using System.Windows.Forms;

namespace OrderStockSystem
{
  
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginManager loginManager = new LoginManager();
            if (loginManager.Show())
            {
                Application.Run(new HomeForm());
            }
           
        }
    }
}
