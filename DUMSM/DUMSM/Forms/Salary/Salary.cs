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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            salaryForm();
            DisplayData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        MonthlyInformations salaryInformation = new MonthlyInformations();
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var willInsert = true;

                string errorMessage = "";

                salaryInformation.Id = Guid.NewGuid();
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


                if (IsPOK != "false" && IsAOK != "false" &&  IsLOK != "false" &&
                    IsSOK != "false" && IsEHOK != "false"&& IsBOK != "false" &&
                    IsLnOK != "false" && IsPFOK != "false" && IsAdOK != "false"&& 
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
                    errorMessage += " ধার্যকৃত অনুদান";
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
                        +salaryInformation.ExtraHonorium + salaryInformation.Bonous + salaryInformation.Due
                         -salaryInformation.Loan - salaryInformation.Advance - salaryInformation.ProvidentFund;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadTeacher();
            salaryInformation.EmployeeType = "শিক্ষক";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadStuff();
            salaryInformation.EmployeeType = "স্টাফ";
        }

        public void salaryForm()
        {
            NameList.Items.Clear();
            TotalAbsenttxt.Text = "0";
            TotalPresenttxt.Text = "0";
            TotalLeavetxt.Text = "0";
            BaseSalarytxt.Text = "0";
            ExtraHonoriumtxt.Text = "0";
            Bonoustxt.Text = "0";
            Duetxt.Text = "0";
            Advancetxt.Text = "0";
            Loantxt.Text = "0";
            ProvidentFundtxt.Text = "0";
        }
        private void Paybtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(salaryInformation.EmployeeName != null && salaryInformation.MonthName != null)
                {
                    salaryInformation.PaymentDate = DateTimetxt.Value.ToString("dd/MM/yyyy");
                    salaryInformation.IsPaid = "হ্যাঁ";
                    var salary = new Salaries();
                    salary.Id = salaryInformation.Id;
                    salary.Name = salaryInformation.EmployeeName;
                    salary.Ammount = salaryInformation.NetPayableAmmount;
                    salary.MonthName = salaryInformation.MonthName;
                    salary.IsPaid = salaryInformation.IsPaid;
                    salary.Designation = salaryInformation.EmployeeType;

                    CRUDOperation.Insert(salary);
                    CRUDOperation.Insert(salaryInformation);
                    MessageBox.Show("সফল হয়েছে!");
                    DisplayData();
                    salaryForm();
                }
            }
            catch
            {
                MessageBox.Show("নিবন্ধন করা যাচ্ছে না!");
            }
        }

        public void DisplayData()
        {
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(MonthlyInformations).Name.ToString());
        }

    }
}
