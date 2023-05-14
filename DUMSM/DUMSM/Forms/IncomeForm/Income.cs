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

namespace DUMSM
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            display();

        }

        public void display()
        {
            //TotalClass.TotalOfColumnWithoutCondition("GeneralIncome", "Ammount");
            TotalGeneraltxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithoutCondition("GeneralIncome", "Ammount").ToString());

            
            TotalGorabatxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithoutCondition("GorabaIncome", "Ammount").ToString());

            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string formattedDate = firstDayOfMonth.ToString("dd/MM/yyyy");

            string presentDay = DateTime.Now.ToString("dd/MM/yyyy");

            string Condition = $"RegisterDate >= '{formattedDate}' and RegisterDate <= '{presentDay}'";

            MonthlyTotalGeneraltxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralIncome", "Ammount", Condition).ToString() );

            MonthlyTotalGorabatxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaIncome", "Ammount", Condition).ToString());


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var generalIncome = new GeneralIncome();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(Ammounttxt.Text.Trim());
                generalIncome.SlipNumber = SlipNumbertxt.Text;
                generalIncome.RegisterDate = DateTimetxt.Value.ToString("dd/MM/yyyy");

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
                    CRUDOperation.Insert(generalIncome);
                    PopUpMessage.SuccessRegistrationMessage("আয়ের তথ্য নিবন্ধন ");
                    ResetForm();
                    display();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "আয়ের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("আয়ের তথ্য নিবন্ধন");
            }
        }

        public void ResetForm()
        {
            Ammounttxt.Text = "";
            Fieldtxt.Text = "";
            SlipNumbertxt.Text = "";
            GorabaAmmounttxt.Text = "";
            GorabaFieldtxt.Text = "";
            GorabaSlipNumbertxt.Text = "";


        }

        private void button30_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void GeneralResetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GorabaRegisterbtn_Click(object sender, EventArgs e)
        {

            try
            {
                string errorMessage = "";
                var willInsert = true;

                var gorabaIncome = new GorabaIncome();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(GorabaAmmounttxt.Text.Trim());
                gorabaIncome.SlipNumber = GorabaSlipNumbertxt.Text;
                gorabaIncome.RegisterDate = GorabaDateTimetxt.Value.ToString("dd/MM/yyyy");

                if (IsDonationAmmountOK != "false")
                {
                    gorabaIncome.Ammount = int.Parse(IsDonationAmmountOK);
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
                gorabaIncome.Field = ((string)selectedItem);



                if (willInsert)
                {
                    CRUDOperation.Insert(gorabaIncome);
                    PopUpMessage.SuccessRegistrationMessage("আয়ের তথ্য নিবন্ধন ");
                    ResetForm();
                    display();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "আয়ের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("আয়ের তথ্য নিবন্ধন");
            }

        }

        private void GorabaResetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
