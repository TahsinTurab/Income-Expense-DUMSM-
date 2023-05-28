using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DUMSM.Forms;
using DUMSM.Forms.Report;
using DUMSM.Forms.Salary;
using DUMSM.Forms.User;

namespace DUMSM.Forms
{
    public partial class SidePanelControl : UserControl
    {
        public SidePanelControl()
        {
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void DonationBtn_Click(object sender, EventArgs e)
        {
            Donation form = new Donation();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {

            Income form = new Income();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void ExpenseBtn_Click(object sender, EventArgs e)
        {
            Expense form = new Expense();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {
            Salaries form = new Salaries();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            Teacher form = new Teacher();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void DonorBtn_Click(object sender, EventArgs e)
        {
            Donor form = new Donor();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            GenerateReport form = new GenerateReport();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ব্যাকআপ নেয়ার জন্য ok তে ক্লিক করুন\nঅনুগ্রহপুর্বক কিছুক্ষন অপেক্ষা করুন।");
            BackupOperation.Backup2Excel("GeneralExpense");
            BackupOperation.Backup2Excel("GorabaExpense");
            BackupOperation.Backup2Excel("GeneralIncome");
            BackupOperation.Backup2Excel("GorabaIncome");
            BackupOperation.Backup2Excel("Salaries");
            BackupOperation.Backup2Excel("MonthlyInformations");
            BackupOperation.Backup2Excel("Donations");
            BackupOperation.Backup2Excel("Donors");
            BackupOperation.Backup2Excel("Teachers");
            BackupOperation.Backup2Excel("Stuffs");
            MessageBox.Show("সফলভাবে ব্যাকআপ নেয়া হয়েছে।"); 
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
