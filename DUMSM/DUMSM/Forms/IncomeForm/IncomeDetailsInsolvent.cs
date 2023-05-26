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

namespace DUMSM
{
    public partial class IncomeDetailsInsolvent : Form
    {
        public IncomeDetailsInsolvent()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(GorabaIncome).Name.ToString());

        }
        private void IncomeDetailsInsolvent_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString() != "")
            {
                if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
                {
                    string id = Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    string donationId = Donordgv.Rows[e.RowIndex].Cells["DonationId"].Value.ToString();

                    DialogResult result = MessageBox.Show($"জমার আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                        "জমার তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        CRUDOperation.Delete("GorabaIncome", id);
                        CRUDOperation.Delete("GorabaDonations", donationId);
                        MessageBox.Show("জমার তথ্য মুছে ফেলা হয়েছে।");
                    }

                    else
                    {
                        MessageBox.Show("জমার তথ্য মুছে ফেলা হয়নি।");

                    }

                }

                else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
                {
                    GorabaIncome generalIncome = new GorabaIncome();
                    generalIncome.Id = Guid.Parse(Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    generalIncome.SlipNumber = Donordgv.Rows[e.RowIndex].Cells["SlipNumber"].Value.ToString();
                    generalIncome.RegisterDate = Donordgv.Rows[e.RowIndex].Cells["RegisterDate"].Value.ToString();
                    generalIncome.IsDonation = Donordgv.Rows[e.RowIndex].Cells["IsDonation"].Value.ToString();
                    generalIncome.DonationId = Donordgv.Rows[e.RowIndex].Cells["DonationId"].Value.ToString();
                    generalIncome.Ammount = int.Parse(Donordgv.Rows[e.RowIndex].Cells["Ammount"].Value.ToString());
                    generalIncome.Field = Donordgv.Rows[e.RowIndex].Cells["Field"].Value.ToString();


                    UpdateGorabaIncomeDetails updateForm = new UpdateGorabaIncomeDetails(generalIncome);
                    updateForm.StartPosition = FormStartPosition.CenterScreen;
                    updateForm.ShowDialog();
                    this.Hide();


                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Income form = new Income();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void DeleteAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি গোরাবা জমার সকল তথ্য চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "গোরাবা জমার সদস্যের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CRUDOperation.DeleteAllData("GorabaIncome");
                MessageBox.Show("সকল তথ্য মুছে ফেলা হয়েছে।");
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BackupOperation.Backup2Excel("GorabaIncome");
            MessageBox.Show("সফলভাবে গোরাবা জমার তথ্য ব্যাকআপ নেয়া হয়েছে");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            (Donordgv.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("SlipNumber like '%" + searchNametxt.Text + "%'");
        }

        private void IncomeDetailsInsolvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true; // Cancel the close operation
                this.Hide(); // Hide the form instead of closing it
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
