using DUMSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms.DonationForm
{
    public partial class UpdateGorabaDonationDetails : Form
    {
        GorabaDonations oldDonation = new GorabaDonations();
        public UpdateGorabaDonationDetails(GorabaDonations donation)
        {
            InitializeComponent();

            oldDonation = donation;
        }

        private void UpdateGorabaDonationDetails_Load(object sender, EventArgs e)
        {
            SlipNumbertxt.Text = oldDonation.SlipNumber;
            Ammounttxt.Text = oldDonation.DonationAmmount.ToString();
            DonorComboBox.Text = oldDonation.DonorName;
            Fieldtxt.Text = oldDonation.DonationField;
            RegisterDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            var list = CRUDOperation.GetColumnValues("Donors", "DonorName");

            DonorComboBox.Items.AddRange(list.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var generalDonation = new GorabaDonations();
                generalDonation.Id = oldDonation.Id;
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(Ammounttxt.Text.Trim());
                generalDonation.SlipNumber = SlipNumbertxt.Text;
                generalDonation.DonationDate = RegisterDate.Text.ToString();
                generalDonation.DonationType = "গোরাবা অনুদান";

                object selectedItem = Fieldtxt.SelectedItem; 
                string type = ((string)selectedItem);
                generalDonation.DonationField = ((string)selectedItem);

                object selectedDonor = DonorComboBox.SelectedItem;
                //string type = ((string)selectedItem);
                generalDonation.DonorName = ((string)selectedDonor);

                if (IsDonationAmmountOK != "false")
                {
                    generalDonation.DonationAmmount = int.Parse(IsDonationAmmountOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " অনুদানের পরিমান";
                    willInsert = false;
                }

                if (willInsert)
                {
                    var gorabaIncome = new GorabaIncome();
                    gorabaIncome.SlipNumber = generalDonation.SlipNumber;
                    gorabaIncome.Ammount = generalDonation.DonationAmmount;
                    gorabaIncome.RegisterDate = generalDonation.DonationDate;
                    gorabaIncome.IsDonation = true;
                    gorabaIncome.Field = generalDonation.DonationField;
                    gorabaIncome.DonationId = generalDonation.Id.ToString();
                    CRUDOperation.Update(generalDonation);
                    CRUDOperation.UpdateRelation(gorabaIncome, "DonationId", gorabaIncome.DonationId);
                    PopUpMessage.SuccessRegistrationMessage("অনুদানের তথ্য আপডেট ");
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "অনুদানের তথ্য আপডেট");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("অনুদানের তথ্য আপডেট");
            }
        }
    }
}
