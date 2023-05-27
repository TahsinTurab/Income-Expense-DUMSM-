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

namespace DUMSM.Forms.Report
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();

            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);
        }

        private void GenerateReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public Dictionary<string, int> MonthList()
        {
            var monthList = new Dictionary<string, int>();
            int i = 1;
            foreach (var item in MonthListGeneral.Items)
            {
                monthList.Add(item.ToString(), i);
                i++;
            }

            return monthList;
        }

        public List<string> GeneralIncomeFields()
        {
            List<string> fields = new List<string>();
            string[] list = {"অনুদান","ফরম / ভর্তি ফি", "শিক্ষার্থীর বেতন", "বোডিং/খানার চার্জ",
                    "নির্মাণ ও মেরামত","লাইব্রেরী","অনুষ্ঠান / ইফতার","বিবিধ" };

            fields.AddRange(list);
            return fields;
        }

        public List<string> GeneralExpenseFields()
        {
            List<string> fields = new List<string>();
            string[] list = {"বেতন","ঋণ পরিশোধ", "যাতায়াত", "ছাপা ও স্টেশনারী",
                    "পানি, বিদ্যুৎ ও গ্যাস", "ফোন","বোর্ডিং", "নির্মাণ ও মেরামত", "লাইব্রেরী",
                    "আসবাব পত্র","অনুষ্ঠান / ইফতার","সম্মানী / অডিট / বোর্ড ফি","বিবিধ"};

            fields.AddRange(list);
            return fields;
        }

        public List<string> GorabaIncomeFields()
        {
            List<string> fields = new List<string>();
            string[] list = {"অনুদান","যাকাত", "ফিতরা", "মান্নত",
                    "কাফফারা","কোরবানীর চামড়া","ব্যংক ঋণ","কর্য গ্রহন","বিবিধ" };
            fields.AddRange(list);
            return fields;
        }

        public List<string> GorabaExpenseFields()
        {
            List<string> fields = new List<string>();
            string[] list = {"খোরাকী","ঋণ পরিশোধ", "যাতায়াত", "ছাপা ও স্টেশনারী",
                    "নগদ প্রদান", "পোষাক","বোর্ডিং", "নির্মাণ ও মেরামত", "কিতাব ক্রয়",
                    "আসবাব পত্র","চিকিৎসা","ব্যাংক ঋণ পরিশোধ","বিবিধ"};

            fields.AddRange(list);
            return fields;
        }

        public Dictionary<string,string> AllIncomeFieldTotal(string monthName)
        {
            Dictionary<string,string> fieldsTotal = new Dictionary<string,string>();
            var monthList = MonthList();

            int monthNumber = monthList[monthName];
            int year = int.Parse(Conversion.BnNumber2EnNumber(YearGeneral.Text));

            var fields = GeneralIncomeFields();
            string Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";

            foreach (var field in fields)
            {
                var ExtraCondition = $" Field = N'{field}' and " + Condition;
                var fieldValue = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralIncome", "Ammount", ExtraCondition).ToString());

                fieldsTotal.Add(field, fieldValue);
            }
                
            
            return fieldsTotal;

        }

        public Dictionary<string, string> AllExpenseFieldTotal(string monthName)
        {
            Dictionary<string, string> fieldsTotal = new Dictionary<string, string>();
            var monthList = MonthList();

            var fields = GeneralExpenseFields();

            int monthNumber = monthList[monthName];
            int year = int.Parse(Conversion.BnNumber2EnNumber(YearGeneral.Text));

            string Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";

            foreach (var field in fields)
            {
                var ExtraCondition = $" Field = N'{field}' and " + Condition;
                var fieldValue = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralExpense", "Ammount", ExtraCondition).ToString());

                fieldsTotal.Add(field, fieldValue);
            }
            return fieldsTotal;
        }

        public Dictionary<string, string> GorabaIncomeFieldTotal(string monthName)
        {
            Dictionary<string, string> fieldsTotal = new Dictionary<string, string>();
            var monthList = MonthList();

            int monthNumber = monthList[monthName];
            int year = int.Parse(Conversion.BnNumber2EnNumber(YearGoraba.Text));

            string Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";

            var fields = GorabaIncomeFields();

            foreach (var field in fields)
            {
                var ExtraCondition = $" Field = N'{field}' and " + Condition;
                var fieldValue = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaIncome", "Ammount", ExtraCondition).ToString());

                fieldsTotal.Add(field, fieldValue);
            }


            return fieldsTotal;

        }

        public Dictionary<string, string> GorabaExpenseFieldTotal(string monthName)
        {
            Dictionary<string, string> fieldsTotal = new Dictionary<string, string>();
            var monthList = MonthList();

            var fields = GorabaExpenseFields();

            int monthNumber = monthList[monthName];
            int year = int.Parse(Conversion.BnNumber2EnNumber(YearGoraba.Text));

            string Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";

            foreach (var field in fields)
            {
                var ExtraCondition = $" Field = N'{field}' and " + Condition;
                var fieldValue = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaExpense", "Ammount", ExtraCondition).ToString());

                fieldsTotal.Add(field, fieldValue);
            }
            return fieldsTotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object selectedItem = MonthListGeneral.SelectedItem;
            string MonthName = ((string)selectedItem);
            
            
            if(MonthName == null || YearGeneral.Text == "")
            {
                PopUpMessage.ErrorMessage("সাধারণ রিপোর্ট"); 
            }
            else
            {
                var FieldDataIncome = AllIncomeFieldTotal(MonthName);
                var FieldDataExpense = AllExpenseFieldTotal(MonthName); 
                var monthList = MonthList();
                var fields = GeneralIncomeFields();

                int monthNumber = monthList[MonthName];
                string year = Conversion.BnNumber2EnNumber(YearGeneral.Text);
                string Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";
                //string Condition = $"RegisterDate >= '01/0{monthNumber}/{year}' and RegisterDate <= '31/0{monthNumber}/{year}'";


                var TotalIncome = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralIncome", "Ammount", Condition).ToString());
                Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";
                var TotalExpense = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GeneralExpense", "Ammount", Condition).ToString());

                var IncomeField = GeneralIncomeFields();
                var ExpenseField = GeneralExpenseFields();

                year = Conversion.EnNumber2BnNumber(YearGeneral.Text);
                var form = new MonthlyReport(FieldDataIncome, IncomeField, FieldDataExpense, ExpenseField, 
                    TotalIncome, TotalExpense, $"{MonthName}, {year}", "সাধারণ  মাসিক  রিপোর্ট");
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();

            }
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            object selectedItem = MonthListGoraba.SelectedItem;
            string MonthName = ((string)selectedItem);


            if (MonthName == null || YearGoraba.Text == "")
            {
                PopUpMessage.ErrorMessage("গোরাবা রিপোর্ট");
            }
            else
            {
                var FieldDataIncome = GorabaIncomeFieldTotal(MonthName);
                var FieldDataExpense = GorabaExpenseFieldTotal(MonthName);
                var monthList = MonthList();
                var fields = GeneralIncomeFields();
                int monthNumber = monthList[MonthName];
                string year = Conversion.BnNumber2EnNumber(YearGoraba.Text);
                string Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";
                var TotalIncome = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaIncome", "Ammount", Condition).ToString());
                Condition = $"MonthName = '{monthNumber}' and Year = '{year}'";
                var TotalExpense = "৳ " + Conversion.EnNumber2BnNumber(
                TotalClass.TotalOfColumnWithCondition("GorabaExpense", "Ammount", Condition).ToString());

                var IncomeField = GorabaIncomeFields();
                var ExpenseField = GorabaExpenseFields();

                year = Conversion.EnNumber2BnNumber(YearGoraba.Text);
                var form = new MonthlyReport(FieldDataIncome, IncomeField, FieldDataExpense, ExpenseField, TotalIncome, TotalExpense, $"{MonthName}, {year}", "গোরাবা  মাসিক  রিপোর্ট");
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
        }
    }
}
