using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozaicaApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                using (LoginForm loginForm = new LoginForm())
                {
                    loginForm.ShowDialog();
                    if (loginForm.DialogResult == DialogResult.OK && loginForm.role == "administrator")
                    {
                        Application.Run(new AdminForm());
                    }
                    else if (loginForm.DialogResult == DialogResult.OK && loginForm.role == "manager")
                    {
                        Application.Run(new ManagerForm());
                    }
                    else
                    {
                        Main();
                    }
                }
            }
        }
    }
}
