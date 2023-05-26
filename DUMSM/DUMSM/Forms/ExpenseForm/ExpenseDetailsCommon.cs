using DUMSM.Classes;
using DUMSM.Forms.IncomeForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms.ExpenseForm
{
    public partial class ExpenseDetailsCommon : Form
    {
        public ExpenseDetailsCommon()
        {
            InitializeComponent();
        }

        private void ExpenseDetailsCommon_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DisplayData()
        {
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(GeneralExpense).Name.ToString());

        }

        private void button35_Click(object sender, EventArgs e)
        {
            Expense form = new Expense();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void DeleteAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি সাধারণ খরচের সকল তথ্য চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "সাধারণ খরচের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CRUDOperation.DeleteAllData("GeneralExpense");
                MessageBox.Show("সকল তথ্য মুছে ফেলা হয়েছে।");
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackupOperation.Backup2Excel("GeneralExpense");
            MessageBox.Show("সফলভাবে সাধারণ খরচের তথ্য ব্যাকআপ নেয়া হয়েছে");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            (Donordgv.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("VoucherNumber like '%" + searchNametxt.Text + "%'");
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString() != "")
            {
                if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
                {
                    string id = Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString();

                    DialogResult result = MessageBox.Show($"খরচের আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                        "সাধারণ খরচের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        CRUDOperation.Delete("GeneralExpense", id);
                        MessageBox.Show("জমারখরচের তথ্য মুছে ফেলা হয়েছে।");
                    }

                    else
                    {
                        MessageBox.Show("খরচের তথ্য মুছে ফেলা হয়নি।");

                    }

                }

                else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
                {
                    if (Donordgv.Rows[e.RowIndex].Cells["Field"].Value.ToString() == "বেতন")
                    {
                        MessageBox.Show("বেতনের তথ্য আপডেট করতে বেতন নিবন্ধন এর তালিকাতে যান");
                    }
                    else
                    {
                        GeneralExpense generalExpense = new GeneralExpense();
                        generalExpense.Id = Guid.Parse(Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString());
                        generalExpense.VoucherNumber = Donordgv.Rows[e.RowIndex].Cells["VoucherNumber"].Value.ToString();
                        generalExpense.ExpenseDate = Donordgv.Rows[e.RowIndex].Cells["ExpenseDate"].Value.ToString();
                        generalExpense.Ammount = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Ammount"].Value.ToString());
                        generalExpense.Field = Donordgv.Rows[e.RowIndex].Cells["Field"].Value.ToString();


                        UpdateCommonExpenseDetails updateForm = new UpdateCommonExpenseDetails(generalExpense);
                        updateForm.StartPosition = FormStartPosition.CenterScreen;
                        updateForm.ShowDialog();
                        this.Hide();
                    }
                }
            }
        }

        private void ExpenseDetailsCommon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
