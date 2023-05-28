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

namespace DUMSM.Forms.ExpenseForm
{
    public partial class ExpenseDetailsGoraba : Form
    {
        public ExpenseDetailsGoraba()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(GorabaExpense).Name.ToString());

        }

        private void ExpenseDetailsGoraba_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DeleteAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি গোরবা খরচের সকল তথ্য চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "গোরবা খরচের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes)
            {
                CRUDOperation.DeleteAllData("GorabaExpense");
                MessageBox.Show("সকল তথ্য মুছে ফেলা হয়েছে।");
                DisplayData();
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackupOperation.Backup2Excel("GorabaExpense");
            MessageBox.Show("সফলভাবে গোরাবা খরচের তথ্য ব্যাকআপ নেয়া হয়েছে");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            (Donordgv.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("VoucherNumber like '%" + searchNametxt.Text + "%'");
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString() != "")
            {
                if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
                {
                    string id = Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    DialogResult result = MessageBox.Show($"খরচের আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                        "গোরাবা খরচের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        CRUDOperation.Delete("GorabaExpense", id);
                        MessageBox.Show("খরচের তথ্য মুছে ফেলা হয়েছে।");
                        DisplayData();
                    }

                    else
                    {
                        MessageBox.Show("খরচের তথ্য মুছে ফেলা হয়নি।");

                    }

                }

                else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
                {
                    GorabaExpense gorabaExpense = new GorabaExpense();
                    gorabaExpense.Id = Guid.Parse(Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    gorabaExpense.VoucherNumber = Donordgv.Rows[e.RowIndex].Cells["VoucherNumber"].Value.ToString();
                    gorabaExpense.ExpenseDate = Donordgv.Rows[e.RowIndex].Cells["ExpenseDate"].Value.ToString();
                    gorabaExpense.Ammount = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Ammount"].Value.ToString());
                    gorabaExpense.Field = Donordgv.Rows[e.RowIndex].Cells["Field"].Value.ToString();


                    UpdateGorabaExpenseDetails updateForm = new UpdateGorabaExpenseDetails(gorabaExpense);
                    updateForm.StartPosition = FormStartPosition.CenterScreen;
                    updateForm.ShowDialog();
                    this.Hide();


                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Expense form = new Expense();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void ExpenseDetailsGoraba_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
