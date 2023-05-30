using DUMSM.Forms.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms
{
    public partial class backup : Form
    {
        public backup()
        {
            InitializeComponent();
            //panel1.Visible = false;
            //panel2.Visible = false;
            textBox3.Visible = false;
            textBox2.Visible = false;
        }

        private List<string> tableName = new List<string> { "GeneralExpense", "GorabaExpense",
        "GeneralIncome","GorabaIncome", "Salaries", "MonthlyInformations","Donations",
        "Donors","Teachers", "Stuffs"};
        private int i = 1;
        private int percentage = 10;

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteBtn.Visible = false;
            //panel1.Visible = true;
            //panel2.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "ব্যাকআপ নেয়া হচ্ছে...";
            textBox3.Text = $"0%";
            foreach (var table in tableName)
            {
                BackupOperation.Backup2Excel(table);
                panel2.Width += 60;
                string p = percentage.ToString();
                textBox3.Text = $"{p}%";
                
                percentage += 10;
                i++;
            }
            textBox2.Text = $"সফল হয়েছে!";

            MessageBox.Show("সফলভাবে ব্যাকআপ নেয়া হয়েছে!");
            Dashboard form = new Dashboard();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
