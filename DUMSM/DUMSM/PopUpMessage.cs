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
                InformationFormName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SuccessRegistrationMessage(string InformationFormName)
        {
            MessageBox.Show($"সফল ভাবে নিবন্ধিত হয়েছে!",
                InformationFormName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorMessage(string InformationFormName)
        {
            MessageBox.Show($"দুঃখিত! দয়া করে আবার চেষ্টা করুন।",
                InformationFormName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
