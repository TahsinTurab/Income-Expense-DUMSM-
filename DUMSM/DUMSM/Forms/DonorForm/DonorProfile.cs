using DUMSM.Classes;
using DUMSM.Forms.DonorForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM
{
    public partial class DonorProfile : Form
    {
        Donors oldDonor;
        public DonorProfile(Donors donor)
        {
            InitializeComponent();
            oldDonor = donor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Location = this.Location;
            donor.ShowDialog();
            this.Close();
        }

        private void DonorProfile_Load(object sender, EventArgs e)
        {
            DonorNameTxt.Text = oldDonor.DonorName;
            DonationAmmounttxt.Text = oldDonor.DonationAmmount.ToString();
            Addresstxt.Text = oldDonor.Address;
            MobileTxt.Text = oldDonor.MobileNumber;
            DonationTypetxt.Text = oldDonor.DonorType;
        }

        

        private void DonationTypetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

            try
            {
                var donor = new Donors();
                donor.Id = oldDonor.Id;
                donor.DonorName = DonorNameTxt.Text.Trim();
                donor.MobileNumber = MobileTxt.Text.Trim();
                donor.Address = Addresstxt.Text.Trim();
                donor.DonorType= DonationTypetxt.Text.Trim();

                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(DonationAmmounttxt.Text.Trim());

                //var check = Convert.ToInt32(numberString);

                var willInsert = true;

                string errorMessage = "";

                if (donor.Id == "")
                {
                    errorMessage += " আইডি নাম্বার";
                    willInsert = false;
                }

                if (donor.DonorName == "")
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }

                    errorMessage += " দাতার নাম";
                    willInsert = false;

                }

                if (donor.MobileNumber == "" || Conversion.BnNumber2EnNumber(MobileTxt.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(MobileTxt.Text.Trim()).Length != 11)
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
                    CRUDOperation.Update(donor);
                    PopUpMessage.SuccessRegistrationMessage("দাতার তথ্য আপডেট");
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "দাতার তথ্য আপডেট");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("দাতার তথ্য আপডেট"); 
            }
        }
    }
}
