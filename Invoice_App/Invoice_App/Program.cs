using System;
using System.Windows.Forms;

namespace Invoice_App
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegisterForm());
        }
    }
}
