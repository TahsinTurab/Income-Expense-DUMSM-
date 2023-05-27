using DUMSM.Forms.DonationForm;
using DUMSM.Forms.Salary;
using DUMSM.Forms.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm startForm = new StartForm();
            startForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(startForm);
        }
    }
}
