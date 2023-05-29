using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.UserdefineClasses
{
    public static class CloseForm
    {
        public static void CloseAllForms()
        {
            try
            {
                List<Form> formsToClose = new List<Form>();

                foreach (Form form in Application.OpenForms)
                {
                    if (form != null && !form.IsDisposed)
                    {
                        formsToClose.Add(form);
                    }
                }

                foreach (Form form in formsToClose)
                {
                    form.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
