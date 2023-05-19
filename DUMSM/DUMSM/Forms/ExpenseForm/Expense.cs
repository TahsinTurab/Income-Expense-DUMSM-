using DUMSM.Classes;
using DUMSM.Forms.ExpenseForm;
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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
            display();
        }

        private void RegisterDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var generalExpense = new GeneralExpense();
                generalExpense.Id = Guid.NewGuid();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(Ammounttxt.Text.Trim());
                generalExpense.VoucherNumber = Vouchertxt.Text;
                generalExpense.ExpenseDate = RegisterDatetxt.Value.ToString("dd/MM/yyyy");

                if (IsDonationAmmountOK != "false")
                {
                    generalExpense.Ammount = int.Parse(IsDonationAmmountOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " খরচের পরিমান";
                    willInsert = false;
                }
                //donation.DonationAmmount = Ammounttxt.Text;

                object selectedItem = Fieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                generalExpense.Field = ((string)selectedItem);



                if (willInsert)
                {
                    CRUDOperation.Insert(generalExpense);
                    PopUpMessage.SuccessRegistrationMessage("খরচের তথ্য নিবন্ধন ");
                    ResetForm();
                    display();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "খরচের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("খরচের তথ্য নিবন্ধন");
            }
        }

        public void ResetForm()
        {
            Vouchertxt.Text = "";
            GorabaVouchertxt.Text = "";
            Fieldtxt.Text = "";
            GorabaFieldtxt.Text = "";
            RegisterDatetxt.Value = DateTime.Now;
            GorabaRegisterDatetxt.Value = DateTime.Now;
            Ammounttxt.Text = "";
            GorabaAmmounttxt.Text = "";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GorabaResetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void GorabaRegisterDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";
                var willInsert = true;

                var gorabaExpense = new GorabaExpense();
                gorabaExpense.Id = Guid.NewGuid();
                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(GorabaAmmounttxt.Text.Trim());
                gorabaExpense.VoucherNumber = GorabaVouchertxt.Text;
                gorabaExpense.ExpenseDate = GorabaRegisterDatetxt.Value.ToString("dd/MM/yyyy");

                if (IsDonationAmmountOK != "false")
                {
                    gorabaExpense.Ammount = int.Parse(IsDonationAmmountOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " খরচের পরিমান";
                    willInsert = false;
                }
                //donation.DonationAmmount = Ammounttxt.Text;

                object selectedItem = GorabaFieldtxt.SelectedItem;
                string type = ((string)selectedItem);
                gorabaExpense.Field = ((string)selectedItem);



                if (willInsert)
                {
                    CRUDOperation.Insert(gorabaExpense);
                    PopUpMessage.SuccessRegistrationMessage("খরচের তথ্য নিবন্ধন ");
                    ResetForm();
                    display();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "খরচের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("খরচের তথ্য নিবন্ধন");
            }
        }

        public void display()
        {
            string presentDay = DateTime.Now.ToString("dd/MM/yyyy");
            string Condition1 = $"ExpenseDate = '{presentDay}'";
            DailyTotalGeneraltxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralExpense", "Ammount", Condition1).ToString());


            DailyTotalGorabatxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaExpense", "Ammount", Condition1).ToString());

            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            string formattedDate = firstDayOfMonth.ToString("dd/MM/yyyy");

            

            string Condition = $"ExpenseDate >= '{formattedDate}' and ExpenseDate <= '{presentDay}'";

            MonthlyTotalGeneraltxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralExpense", "Ammount", Condition).ToString());

            MonthlyTotalGorabatxt.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaExpense", "Ammount", Condition).ToString());


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            ExpenseDetailsCommon expenseDetailsCommon = new ExpenseDetailsCommon();
            
            expenseDetailsCommon.Show();
            this.Hide();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            ExpenseDetailsGoraba expenseDetailsGoraba = new ExpenseDetailsGoraba();

            expenseDetailsGoraba.Show();
            this.Hide();
        }
    }
}
