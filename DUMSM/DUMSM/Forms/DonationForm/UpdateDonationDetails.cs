using DUMSM.Classes;
using DUMSM.Forms.DonationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms.DonorForm
{
    public partial class UpdateDonationDetails : Form
    {
        Donations oldDonation;
        public UpdateDonationDetails(Donations donation)
        {
            InitializeComponent();
            oldDonation = donation;
        }

        private void UpdateDonationDetails_Load(object sender, EventArgs e)
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

                var generalDonation = new Donations();
                generalDonation.Id = oldDonation.Id;
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(Ammounttxt.Text.Trim());
                generalDonation.SlipNumber = SlipNumbertxt.Text;
                generalDonation.DonationDate = RegisterDate.Text.ToString();
                generalDonation.DonationType = "সাধারণ অনুদান";

                object selectedItem = Fieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                generalDonation.DonationField = ((string)selectedItem);

                object selectedDonor = DonorComboBox.SelectedItem;
                //string type = ((string)selectedItem);
                if (selectedDonor != null)
                {
                    generalDonation.DonorName = ((string)selectedDonor);
                }
                else
                {
                    generalDonation.DonorName = oldDonation.DonorName;
                }

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
                    var generalIncome = new GeneralIncome();
                    generalIncome.SlipNumber = generalDonation.SlipNumber;
                    generalIncome.Ammount = generalDonation.DonationAmmount;
                    generalIncome.RegisterDate = generalDonation.DonationDate;
                    DateTime date;
                    if (DateTime.TryParseExact(generalIncome.RegisterDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        int monthNumber = date.Month; // Get the month number
                        int year = date.Year; // Get the year

                        generalIncome.MonthName = monthNumber;
                        generalIncome.Year = year;
                    }
                    generalIncome.IsDonation = "হ্যাঁ";
                    generalIncome.Field = generalDonation.DonationField;
                    generalIncome.DonationId = generalDonation.Id.ToString();
                    CRUDOperation.Update(generalDonation);
                    CRUDOperation.UpdateRelation(generalIncome, "DonationId", generalIncome.DonationId);
                    PopUpMessage.SuccessRegistrationMessage("অনুদানের তথ্য আপডেট ");
                    GeneralDonationList form = new GeneralDonationList();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Hide();
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
