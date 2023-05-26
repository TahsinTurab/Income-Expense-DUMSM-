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
            if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
            {
                string id = Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                DialogResult result = MessageBox.Show($"বেতনের আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                    "বেতনের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    CRUDOperation.Delete("Salaries", id);

                    CRUDOperation.Delete("GeneralExpense", id);
                    CRUDOperation.Delete("MonthlyInformations", id);
                    MessageBox.Show("বেতনের তথ্য মুছে ফেলা হয়েছে।");
                    //DisplayData();
                }

                else
                {
                    MessageBox.Show("বেতনের তথ্য মুছে ফেলা হয়নি।");

                }

            }

            else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
            {
                MonthlyInformations monthlyInformations = new MonthlyInformations();
                monthlyInformations.Id = Guid.Parse(Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                monthlyInformations.TotalPresent = int.Parse(Donordgv.Rows[e.RowIndex].Cells["TotalPresent"].Value.ToString());
                monthlyInformations.TotalAbsent = int.Parse(Donordgv.Rows[e.RowIndex].Cells["TotalAbsent"].Value.ToString());
                monthlyInformations.TotalLeave = int.Parse(Donordgv.Rows[e.RowIndex].Cells["TotalLeave"].Value.ToString());
                monthlyInformations.Advance = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Advance"].Value.ToString());
                monthlyInformations.Loan = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Loan"].Value.ToString());
                monthlyInformations.Bonous = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Bonous"].Value.ToString());
                monthlyInformations.BaseSalary = int.Parse(Donordgv.Rows[e.RowIndex].Cells["BaseSalary"].Value.ToString());
                monthlyInformations.Due = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Due"].Value.ToString());
                monthlyInformations.TotalAmmount = int.Parse(Donordgv.Rows[e.RowIndex].Cells["TAmmount"].Value.ToString());
                monthlyInformations.ExtraHonorium = int.Parse(Donordgv.Rows[e.RowIndex].Cells["ExtraHonorium"].Value.ToString());
                monthlyInformations.ProvidentFund = int.Parse(Donordgv.Rows[e.RowIndex].Cells["ProvidentFund"].Value.ToString());
                monthlyInformations.NetPayableAmmount = int.Parse(Donordgv.Rows[e.RowIndex].Cells["NetPayableAmmount"].Value.ToString());
                monthlyInformations.EmployeeName = Donordgv.Rows[e.RowIndex].Cells["EmployeeName"].Value.ToString();
                monthlyInformations.MonthName = Donordgv.Rows[e.RowIndex].Cells["MonthName"].Value.ToString();
                monthlyInformations.EmployeeType = Donordgv.Rows[e.RowIndex].Cells["EmployeeType"].Value.ToString();
                monthlyInformations.PaymentDate = Donordgv.Rows[e.RowIndex].Cells["PaymentDate"].Value.ToString();
                monthlyInformations.IsPaid = Donordgv.Rows[e.RowIndex].Cells["IsPaid"].Value.ToString();
                

                UpdateSalaryDetails updateForm = new UpdateSalaryDetails(monthlyInformations);
                updateForm.ShowDialog();


            }
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
                    salary.Date = salaryInformation.PaymentDate;

                    var generalExpense = new GeneralExpense();
                    generalExpense.Id = salaryInformation.Id;
                    generalExpense.Ammount = salaryInformation.NetPayableAmmount;
                    generalExpense.Field = "বেতন";
                    generalExpense.ExpenseDate= salaryInformation.PaymentDate;
                    generalExpense.VoucherNumber = "";

                    CRUDOperation.Insert(generalExpense);
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

        private void DeleteAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি বেতনের সকল তথ্য চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "বেতনের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CRUDOperation.DeleteAllData("Salaries");

                CRUDOperation.DeleteWithCondition("GeneralExpense", "Field = N'বেতন'");
                MessageBox.Show("সকল তথ্য মুছে ফেলা হয়েছে।");
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
        }

        private void Backupbtn_Click(object sender, EventArgs e)
        {
            BackupOperation.Backup2Excel("Salaries");
            MessageBox.Show("সফলভাবে বেতনের তথ্য ব্যাকআপ নেয়া হয়েছে");
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Location = this.Location;
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
