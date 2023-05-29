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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DUMSM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            InitializeUserControl();
            
        }

        private void InitializeUserControl()
        {
            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);

            ExitControl myUserControl = new ExitControl();
            myUserControl.Dock = DockStyle.None;
            myUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            myUserControl.Location = new System.Drawing.Point(
                ClientSize.Width - myUserControl.Width,
                0
            );
            Controls.Add(myUserControl);
            myUserControl.BringToFront();

        }

        public void Display()
        {
            //TotalClass.TotalOfColumnWithoutCondition("GeneralIncome", "Ammount");
            TotalGeneral.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithoutCondition("GeneralIncome", "Ammount").ToString());

            TotalExpenseGeneral.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithoutCondition("GeneralExpense", "Ammount").ToString());

            

            TotalGoraba.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithoutCondition("GorabaIncome", "Ammount").ToString());

            TotalExpenseGoraba.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithoutCondition("GorabaExpense", "Ammount").ToString());

            //DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //string formattedDate = firstDayOfMonth.ToString("dd/MM/yyyy");

            //string presentDay = DateTime.Now.ToString("dd/MM/yyyy");

            //string Condition = $"RegisterDate >= '{formattedDate}' and RegisterDate <= '{presentDay}'";

            int monthNumber = DateTime.Now.Month;
            string Condition = $"MonthName = {monthNumber}";

            MonthlyTotalGeneral.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralIncome", "Ammount", Condition).ToString());

            MonthlyIncomeGoraba.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaIncome", "Ammount", Condition).ToString());

            Condition = $"MonthName = {monthNumber}";

            MonthlyExpenseGoraba.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaExpense", "Ammount", Condition).ToString());

            MonthlyExpenseGeneral.Text = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralExpense", "Ammount", Condition).ToString());

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //var teachers = CRUDOperation.GetColumnValues("Teachers", "Id");
            //string teacherNumber = Conversion.EnNumber2BnNumber(teachers.Count.ToString());

            //TotalTeacher.Text = teacherNumber + " জন";
             
            //var donors = CRUDOperation.GetColumnValues("Donors", "Id");
            //var donerNumber = Conversion.EnNumber2BnNumber(donors.Count.ToString());
            //TotalDonar.Text = donerNumber + " জন";

            Display();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
        }

        private void DonationBtn_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExpenseBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {

        }

        private void DonorBtn_Click(object sender, EventArgs e)
        {

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

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Fieldtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = Fieldtxt.SelectedItem;
            string type = ((string)selectedItem);
            var condition = $"Field = N'{type}'";
            var Total = TotalClass.TotalOfColumnWithCondition("GeneralIncome", "Ammount", condition);
            showGeneraltotal.Text = "৳ " +Conversion.EnNumber2BnNumber(Total.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = comboBox1.SelectedItem;
            string type = ((string)selectedItem);
            var condition = $"Field = N'{type}'";
            var Total = TotalClass.TotalOfColumnWithCondition("GeneralExpense", "Ammount", condition);
            showExpenseGeneraltotal.Text = "৳ " + Conversion.EnNumber2BnNumber(Total.ToString());
        }

        private void GorabaFieldtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = GorabaFieldtxt.SelectedItem;
            string type = ((string)selectedItem);
            var condition = $"Field = N'{type}'";
            var Total = TotalClass.TotalOfColumnWithCondition("GorabaIncome", "Ammount", condition);
            textBox2.Text = "৳ " + Conversion.EnNumber2BnNumber(Total.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = comboBox2.SelectedItem;
            string type = ((string)selectedItem);
            var condition = $"Field = N'{type}'";
            var Total = TotalClass.TotalOfColumnWithCondition("GorabaExpense", "Ammount", condition);
            textBox3.Text = "৳ " + Conversion.EnNumber2BnNumber(Total.ToString());
        }
    }
}
