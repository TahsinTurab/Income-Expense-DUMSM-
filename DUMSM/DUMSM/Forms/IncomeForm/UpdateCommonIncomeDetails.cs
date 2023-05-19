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

namespace DUMSM.Forms.IncomeForm
{
    public partial class UpdateCommonIncomeDetails : Form
    {
        GeneralIncome oldIncome;
        public UpdateCommonIncomeDetails(GeneralIncome Income)
        {
            InitializeComponent();
            oldIncome = Income;
        }

        private void UpdateCommonIncomeDetails_Load(object sender, EventArgs e)
        {
            SlipNumbertxt.Text = oldIncome.SlipNumber;
            Fieldtxt.Text = oldIncome.Field;
            Ammounttxt.Text = oldIncome.Ammount.ToString();
            RegisterDatetxt.Text = oldIncome.RegisterDate.ToString();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneralRegisterbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var generalIncome = new GeneralIncome();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(Ammounttxt.Text.Trim());
                generalIncome.SlipNumber = SlipNumbertxt.Text;
                generalIncome.IsDonation = oldIncome.IsDonation;
                generalIncome.DonationId = oldIncome?.DonationId;
                generalIncome.RegisterDate = RegisterDatetxt.Text;
                generalIncome.Id = oldIncome.Id;

                

                if (IsDonationAmmountOK != "false")
                {
                    generalIncome.Ammount = int.Parse(IsDonationAmmountOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " জমার পরিমান";
                    willInsert = false;
                }
                //donation.DonationAmmount = Ammounttxt.Text;

                object selectedItem = Fieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                generalIncome.Field = ((string)selectedItem);



                if (willInsert)
                {
                    CRUDOperation.Update(generalIncome);
                    if (generalIncome.IsDonation == "হ্যাঁ")
                    {
                        var donation = new Donations();
                        donation.Id = Guid.Parse(generalIncome.DonationId);
                        donation.DonationAmmount = generalIncome.Ammount;
                        donation.DonationField = generalIncome.Field;
                        donation.DonationDate = generalIncome.RegisterDate;
                        CRUDOperation.Update(donation);
                    }
                    PopUpMessage.SuccessRegistrationMessage("আয়ের তথ্য আপডেট ");
                    this.Close();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "আয়ের তথ্য আপডেট"); 
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("আয়ের তথ্য আপডেট");
            }
        }
    }
}
