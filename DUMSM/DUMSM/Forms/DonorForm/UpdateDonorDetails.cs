using DUMSM.Classes;
using DUMSM.Forms.User;
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
    public partial class UpdateDonorDetails : Form
    {
        private Donors oldDonor;
        public UpdateDonorDetails(Donors donor)
        {
            InitializeComponent();
            oldDonor = donor;
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            DonorTypetxt.Text = oldDonor.DonorType;
            DonorNametxt.Text = oldDonor.DonorName;
            Idtxt.Text = oldDonor.Id;
            Addresstxt.Text = oldDonor.Address;
            MobileNumbertxt.Text = oldDonor.MobileNumber;
            DonationAmmounttxt.Text = oldDonor.DonationAmmount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var donor = new Donors();
                donor.Id = Idtxt.Text.Trim();
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
                    CRUDOperation.Update(donor);
                    PopUpMessage.SuccessRegistrationMessage("দাতার তথ্য আপডেট");
                    DonorList form = new DonorList();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Hide();
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
