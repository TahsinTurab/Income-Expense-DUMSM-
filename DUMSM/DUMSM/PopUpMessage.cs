using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM
{
    public static class PopUpMessage
    {
        public static void DataMissingMessage(string DataFieldName, string InformationFormName)
        {
            MessageBox.Show($"দয়া করে {DataFieldName} সঠিক তথ্য দিয়ে পূরণ করুন!", 
                InformationFormName, (MessageBoxButtons)MessageBoxIcon.Error);
        }
    }
}
