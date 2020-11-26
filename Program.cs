using System;
using System.Windows.Forms;

namespace Proiect_PIU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new ProductType());
            //Application.Run(new Customers());
            //Application.Run(new StoreStock());
            //Application.Run(new InvoiceSearch());
            //Application.Run(new DeleteProduct());
            Application.Run(new MainForm());
        }
    }
}
