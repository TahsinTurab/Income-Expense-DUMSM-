using DUMSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM
{
    public partial class Donor : Form
    {
        
        public Donor()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                var donor = new Donors();
                donor.DonorName = DonorNametxt.Text.Trim();
                donor.MobileNumber = MobileNumbertxt.Text.Trim();
                donor.Address = Addresstxt.Text.Trim();
                object selectedItem = DonorTypetxt.SelectedItem;
                string type = ((string)selectedItem);
                donor.DonorType = ((string)selectedItem);

                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(DonationAmmounttxt.Text.Trim());

                //var check = Convert.ToInt32(numberString);

                var willInsert = true;

                string errorMessage = "";

                if (donor.DonorName == "")
                {
                    errorMessage += " দাতার নাম";
                    willInsert = false;

                }

                if (donor.MobileNumber == "" || Conversion.BnNumber2EnNumber(MobileNumbertxt.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(MobileNumbertxt.Text.Trim()).Length != 11)
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " মোবাইল নাম্বার";

                    willInsert = false;

                }

                if (donor.DonorType == null)
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " দাতার ধরণ";

                    willInsert = false;
                }

                if (IsDonationAmmountOK != "false")
                {
                    donor.DonationAmmount = int.Parse(IsDonationAmmountOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " ধার্যকৃত অনুদান";
                    willInsert = false;
                }

                if (willInsert)
                {
                    CRUDOperation.Insert(donor);
                    PopUpMessage.SuccessRegistrationMessage("দাতার তথ্য নিবন্ধন");
                    ResetForm();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "দাতার তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("দাতার তথ্য নিবন্ধন");
            }
        }

        private void DonorTypetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxData(DonorTypetxt);
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            DonorNametxt.Text = "";
            DonorTypetxt.Text = "";
            DonationAmmounttxt.Text = "";
            MobileNumbertxt.Text = "";
            Addresstxt.Text = "";
        }
    }
}
