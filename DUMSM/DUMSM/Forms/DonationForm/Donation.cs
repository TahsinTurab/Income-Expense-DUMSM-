using DUMSM.Classes;
using DUMSM.Forms;
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
    public partial class Donation : Form
    {
        public Donation()
        {
            InitializeComponent();
            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);
            LoadDonerList();
        }

        public void LoadDonerList()
        {
            var list = CRUDOperation.GetColumnValues("Donors", "DonorName");
            
            DonorComboBox.Items.AddRange(list.ToArray());
            GorabaDonorComboBox.Items.AddRange(list.ToArray());

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var generalDonation = new Donations();
                generalDonation.Id = Guid.NewGuid();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(Ammounttxt.Text.Trim());
                generalDonation.SlipNumber = SlipNumbertxt.Text;
                generalDonation.DonationDate = RegisterDate.Value.ToString("dd/MM/yyyy");
                generalDonation.DonationType = "সাধারণ অনুদান";

                object selectedItem = Fieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                generalDonation.DonationField = ((string)selectedItem);

                object selectedDonor= DonorComboBox.SelectedItem;
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
                    var generalIncome = new GeneralIncome();
                    generalIncome.Id = Guid.NewGuid();
                    generalIncome.SlipNumber = generalDonation.SlipNumber;
                    generalIncome.Ammount = generalDonation.DonationAmmount;
                    generalIncome.RegisterDate = generalDonation.DonationDate;
                    generalIncome.IsDonation = "হ্যাঁ";
                    generalIncome.Field = generalDonation.DonationField;
                    generalIncome.DonationId = generalDonation.Id.ToString();
                    CRUDOperation.Insert(generalDonation);
                    CRUDOperation.Insert(generalIncome);
                    PopUpMessage.SuccessRegistrationMessage("অনুদানের তথ্য নিবন্ধন ");
                    ResetForm();
                    LoadDonerList();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "অনুদানের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("অনুদানের তথ্য নিবন্ধন");
            }


        }

        public void ResetForm()
        {
            SlipNumbertxt.Text = "";
            GorabaSlipNumbertxt.Text = "";
            DonorComboBox.Text = "";
            GorabaDonorComboBox.Text = "";
            RegisterDate.Value = DateTime.Now;
            GorabaRegisterDate.Value = DateTime.Now;
            Fieldtxt.Text = "";
            GorabaFieldtxt.Text = "";
            Ammounttxt.Text = "";
            GorabaAmmount.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDonerList();
        }

        private void GorabaResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadDonerList();
        }

        private void GorabaRegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var gorabaDonation = new GorabaDonations();
                gorabaDonation.Id = Guid.NewGuid();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(GorabaAmmount.Text.Trim());
                gorabaDonation.SlipNumber = GorabaSlipNumbertxt.Text;
                gorabaDonation.DonationDate = GorabaRegisterDate.Value.ToString("dd/MM/yyyy");
                gorabaDonation.DonationType = "গোরাবা অনুদান";

                object selectedItem = GorabaFieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                gorabaDonation.DonationField = ((string)selectedItem);

                object selectedDonor = GorabaDonorComboBox.SelectedItem;
                //string type = ((string)selectedItem);
                gorabaDonation.DonorName = ((string)selectedDonor);

                if (IsDonationAmmountOK != "false")
                {
                    gorabaDonation.DonationAmmount = int.Parse(IsDonationAmmountOK);
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
                    gorabaIncome.Id = Guid.NewGuid();
                    gorabaIncome.SlipNumber = gorabaDonation.SlipNumber;
                    gorabaIncome.Ammount = gorabaDonation.DonationAmmount;
                    gorabaIncome.RegisterDate = gorabaDonation.DonationDate;
                    gorabaIncome.IsDonation = "হ্যাঁ";
                    gorabaIncome.Field = gorabaDonation.DonationField;
                    gorabaIncome.DonationId = gorabaDonation.Id.ToString();
                    CRUDOperation.Insert(gorabaDonation);
                    CRUDOperation.Insert(gorabaIncome);
                    PopUpMessage.SuccessRegistrationMessage("অনুদানের তথ্য নিবন্ধন ");
                    ResetForm();
                    LoadDonerList();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "অনুদানের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("অনুদানের তথ্য নিবন্ধন");
            }
        }
    }
}
