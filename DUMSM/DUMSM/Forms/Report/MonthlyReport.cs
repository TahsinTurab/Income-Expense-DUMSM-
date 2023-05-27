using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms.Report
{
    public partial class MonthlyReport : Form
    {
        private Dictionary<string,string> IncomeDetails { get; set; }
        private Dictionary<string,string> ExpenseDetails { get; set; }
        private string TIncome { get; set; }
        private string TExpense { get; set; }
        private string monthName { get; set; }
        private string title { get; set; }
        private List<string> IncomeFields { get; set; }
        private List<string> ExpenseFields { get; set; }
        public MonthlyReport(Dictionary<string,string> Income,List<string> IncomeField, 
            Dictionary<string,string> Expense, List<string> ExpenseField,
            string TotalIncome, string TotalExpense, string MonthName, string Title)
        {
            InitializeComponent();
            
            IncomeDetails = Income;
            ExpenseDetails = Expense;
            TIncome = TotalIncome;
            TExpense = TotalExpense;
            monthName = MonthName;
            title = Title;
            IncomeFields = IncomeField;
            ExpenseFields = ExpenseField;

            DisplayData();
        }

        public void DisplayData()
        {
            // Assuming you have a reference to your RDLC report viewer control, and the data you want to set
            ReportParameter parameter = new ReportParameter("ReportDate", DateTime.Now.ToString());
            reportViewer1.LocalReport.SetParameters(parameter);

            parameter = new ReportParameter("MonthName",monthName);
            reportViewer1.LocalReport.SetParameters(parameter);

            parameter = new ReportParameter("ReportType", title);
            reportViewer1.LocalReport.SetParameters(parameter);
            int i = 1;
            foreach(var income in IncomeFields)
            {
                parameter = new ReportParameter($"Field{i}Title", income);
                reportViewer1.LocalReport.SetParameters(parameter);
                parameter = new ReportParameter($"Field{i}Value", IncomeDetails[income]);
                reportViewer1.LocalReport.SetParameters(parameter);
                i++;
            }

            i = 1;
            foreach(var expense in ExpenseFields)
            {
                parameter = new ReportParameter($"Expense{i}Title", expense);
                reportViewer1.LocalReport.SetParameters(parameter);
                parameter = new ReportParameter($"Expense{i}Value", ExpenseDetails[expense]);
                reportViewer1.LocalReport.SetParameters(parameter);
                i++;
            }

            parameter = new ReportParameter($"TotalIncomeTitle", "মোট জমা");
            reportViewer1.LocalReport.SetParameters(parameter);
            parameter = new ReportParameter($"TotalIncomeValue", TIncome);
            reportViewer1.LocalReport.SetParameters(parameter);
            parameter = new ReportParameter($"TotalExpenseTitle", "মোট খরচ"); 
            reportViewer1.LocalReport.SetParameters(parameter);
            parameter = new ReportParameter($"TotalExpenseValue", TExpense);
            reportViewer1.LocalReport.SetParameters(parameter);
            reportViewer1.RefreshReport();

        }

        private void MonthlyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new GenerateReport();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
