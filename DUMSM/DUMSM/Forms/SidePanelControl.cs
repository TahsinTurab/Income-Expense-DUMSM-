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

        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Form parentForm = FindForm();
            parentForm.Hide();
        }
    }
}
