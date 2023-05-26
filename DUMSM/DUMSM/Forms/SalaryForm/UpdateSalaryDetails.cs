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

namespace DUMSM.Forms.Salary
{
   
    public partial class UpdateSalaryDetails : Form
    {
        MonthlyInformations oldMonthlyInfomatoin;
        MonthlyInformations salaryInformation = new MonthlyInformations();
        public UpdateSalaryDetails(MonthlyInformations monthlyInformations)
        {
            InitializeComponent();
            oldMonthlyInfomatoin = monthlyInformations;
        }

        public void LoadTeacher()
        {
            var list = CRUDOperation.GetColumnValues("Teachers", "Name");

            NameList.Items.Clear();
            NameList.Items.AddRange(list.ToArray());
        }

        public void LoadStuff()
        {
            var list = CRUDOperation.GetColumnValues("Stuffs", "Name");

            NameList.Items.Clear();
            NameList.Items.AddRange(list.ToArray());
        }

        private void UpdateSalaryDetails_Load(object sender, EventArgs e)
        {
            //NameList.Text = oldMonthlyInfomatoin.EmployeeName();

            TotalPresenttxt.Text = oldMonthlyInfomatoin.TotalPresent.ToString();
            TotalAbsenttxt.Text = oldMonthlyInfomatoin.TotalAbsent.ToString();
            TotalLeavetxt.Text = oldMonthlyInfomatoin.TotalLeave.ToString();
            Duetxt.Text = oldMonthlyInfomatoin.Due.ToString();
            Bonoustxt.Text = oldMonthlyInfomatoin.Bonous.ToString();
            BaseSalarytxt.Text = oldMonthlyInfomatoin.BaseSalary.ToString();
            ExtraHonoriumtxt.Text = oldMonthlyInfomatoin.ExtraHonorium.ToString();
            ProvidentFundtxt.Text = oldMonthlyInfomatoin.ProvidentFund.ToString();
            Loantxt.Text = oldMonthlyInfomatoin.Loan.ToString();
            Advancetxt.Text = oldMonthlyInfomatoin.Advance.ToString();
            TotalAmmount.Text = oldMonthlyInfomatoin.TotalAmmount.ToString();
            NetPayableAmmounttxt.Text = oldMonthlyInfomatoin.NetPayableAmmount.ToString();
            DateTimetxt.Text = oldMonthlyInfomatoin.PaymentDate.ToString();
            string selectedEmployee = oldMonthlyInfomatoin.EmployeeName;
            if (oldMonthlyInfomatoin.EmployeeType == "শিক্ষক")
            {
                radioButton1.Checked = true;
                LoadTeacher();
                int selectedIndex = NameList.FindString(selectedEmployee);
                NameList.SelectedIndex = selectedIndex;
            }
            else if(oldMonthlyInfomatoin.EmployeeType == "স্টাফ")
            {
                radioButton2.Checked = true;
                LoadStuff();
                int selectedIndex = NameList.FindString(selectedEmployee);
                NameList.SelectedIndex = selectedIndex;
            }

            string selectedMonth = oldMonthlyInfomatoin.MonthName;
            int monthSelectedIndex = MonthList.FindString(selectedMonth);
            MonthList.SelectedIndex = monthSelectedIndex;

            //object selectedEmployee = NameList.SelectedItem;
            ////string type = ((string)selectedItem);
            //NameList.SelectedValue = oldMonthlyInfomatoin.EmployeeName;
            //MonthList.SelectedValue = oldMonthlyInfomatoin.MonthName;
        }

        
        public void hisab()
        {
            try
            {
                var willInsert = true;

                string errorMessage = "";
                //MonthlyInformations salaryInformation = new MonthlyInformations();
                salaryInformation.Id = oldMonthlyInfomatoin.Id;
                object selectedItem = NameList.SelectedItem;
                salaryInformation.EmployeeName = ((string)selectedItem);

                object selectedMonth = MonthList.SelectedItem;
                salaryInformation.MonthName = ((string)selectedMonth);

                var IsPOK = Conversion.BnNumber2EnNumber(TotalPresenttxt.Text.Trim());
                var IsAOK = Conversion.BnNumber2EnNumber(TotalAbsenttxt.Text.Trim());
                var IsSOK = Conversion.BnNumber2EnNumber(BaseSalarytxt.Text.Trim());
                var IsLOK = Conversion.BnNumber2EnNumber(TotalLeavetxt.Text.Trim());
                var IsEHOK = Conversion.BnNumber2EnNumber(ExtraHonoriumtxt.Text.Trim());
                var IsBOK = Conversion.BnNumber2EnNumber(Bonoustxt.Text.Trim());
                var IsLnOK = Conversion.BnNumber2EnNumber(Loantxt.Text.Trim());
                var IsPFOK = Conversion.BnNumber2EnNumber(ProvidentFundtxt.Text.Trim());
                var IsAdOK = Conversion.BnNumber2EnNumber(Advancetxt.Text.Trim());
                var IsDOK = Conversion.BnNumber2EnNumber(Duetxt.Text.Trim());


                if (IsPOK != "false" && IsAOK != "false" && IsLOK != "false" &&
                    IsSOK != "false" && IsEHOK != "false" && IsBOK != "false" &&
                    IsLnOK != "false" && IsPFOK != "false" && IsAdOK != "false" &&
                    IsDOK != "false")
                {
                    salaryInformation.TotalPresent = int.Parse(IsPOK);
                    salaryInformation.TotalAbsent = int.Parse(IsAOK);
                    salaryInformation.BaseSalary = int.Parse(IsSOK);
                    salaryInformation.TotalLeave = int.Parse(IsLOK);
                    salaryInformation.ExtraHonorium = int.Parse(IsEHOK);
                    salaryInformation.Bonous = int.Parse(IsBOK);
                    salaryInformation.Loan = int.Parse(IsLnOK);
                    salaryInformation.ProvidentFund = int.Parse(IsPFOK);
                    salaryInformation.Advance = int.Parse(IsAdOK);
                    salaryInformation.Due = int.Parse(IsDOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " তথ্য";
                    willInsert = false;
                }


                //var check = Convert.ToInt32(numberString);


                if (salaryInformation.EmployeeName == null)
                {
                    errorMessage += " নাম";
                    willInsert = false;
                }

                if (salaryInformation.MonthName == null)
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }

                    errorMessage += " মাসের নাম";
                    willInsert = false;

                }

                if (willInsert)
                {
                    var totalDay = salaryInformation.TotalLeave + salaryInformation.TotalAbsent
                        + salaryInformation.TotalPresent;

                    var totalAmmount = salaryInformation.BaseSalary
                        - (salaryInformation.BaseSalary * salaryInformation.TotalAbsent) / (totalDay);

                    salaryInformation.NetPayableAmmount = totalAmmount
                        + salaryInformation.ExtraHonorium + salaryInformation.Bonous + salaryInformation.Due
                         - salaryInformation.Loan - salaryInformation.Advance - salaryInformation.ProvidentFund;

                    salaryInformation.TotalAmmount = totalAmmount;

                    TotalAmmount.Text = totalAmmount.ToString();
                    NetPayableAmmounttxt.Text = salaryInformation.NetPayableAmmount.ToString();


                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "বেতন তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("বেতন তথ্য নিবন্ধন");
            }
        }
        private void Paybtn_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (salaryInformation.EmployeeName != null && salaryInformation.MonthName != null)
                {
                    salaryInformation.PaymentDate = DateTimetxt.Text;
                    salaryInformation.IsPaid = "হ্যাঁ";
                    var salary = new Classes.Salaries();
                    salary.Id = salaryInformation.Id;
                    salary.Name = salaryInformation.EmployeeName;
                    salary.Ammount = salaryInformation.NetPayableAmmount;
                    salary.MonthName = salaryInformation.MonthName;
                    salary.IsPaid = salaryInformation.IsPaid;
                    salary.Designation = salaryInformation.EmployeeType;
                    salary.Date = salaryInformation.PaymentDate;

                    var generalExpense = new GeneralExpense();
                    generalExpense.Id = salaryInformation.Id;
                    generalExpense.Ammount = salaryInformation.NetPayableAmmount;
                    generalExpense.Field = "বেতন";
                    generalExpense.ExpenseDate = salaryInformation.PaymentDate;
                    generalExpense.VoucherNumber = "";

                    CRUDOperation.Update(generalExpense);
                    CRUDOperation.Update(salary);
                    CRUDOperation.Update(salaryInformation);
                    MessageBox.Show("সফল হয়েছে!");
                    Salaries form = new Salaries();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Show();
                    this.Hide();

                }
            }
            catch
            {
                MessageBox.Show("আপডেট করা যাচ্ছে না!");
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        { 
            hisab();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadStuff();
            salaryInformation.EmployeeType = "স্টাফ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadTeacher();
            salaryInformation.EmployeeType = "শিক্ষক";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Salaries form = new Salaries();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void UpdateSalaryDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
