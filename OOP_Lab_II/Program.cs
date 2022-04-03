using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                    Login_Form loginForm = new Login_Form();
                    Application.Run(loginForm);
                    if(loginForm.UserSuccessfullyAuthenticated)
                        Application.Run(new Menu_Form());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            //Application.Run(new Forms.Register_Form());
            //Application.Run(new Forms.Form_Options());

        }
    }
}
