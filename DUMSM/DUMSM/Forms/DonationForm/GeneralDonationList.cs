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

namespace DUMSM.Forms.DonationForm
{
    public partial class GeneralDonationList : Form
    {
        public GeneralDonationList()
        {
            InitializeComponent();
        }

        public void DisplayData()
        {
            //this.donorsTableAdapter.Fill(this.dUMSMDataBaseDataSet.Donors);
            //DataGridViewOperation.DisplayData(Donordgv, typeof(Donors).Name.ToString());
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(Donations).Name.ToString());
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString() != "")
            {


                if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
                {
                    string id = Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    DialogResult result = MessageBox.Show($"দানের আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                        "অনুদানের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        CRUDOperation.Delete("Donations", id);
                        CRUDOperation.Delete("GeneralIncome", id);
                        MessageBox.Show("অনুদানের তথ্য মুছে ফেলা হয়েছে।");
                        //DisplayData();


                    }

                    else
                    {
                        MessageBox.Show("অনুদানের তথ্য মুছে ফেলা হয়নি।");

                    }

                }

                else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
                {
                    Donations donation = new Donations();
                    donation.Id = Guid.Parse(Donordgv.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    donation.DonorName = Donordgv.Rows[e.RowIndex].Cells["DonorName"].Value.ToString();
                    donation.DonationField = Donordgv.Rows[e.RowIndex].Cells["DonationField"].Value.ToString();
                    donation.SlipNumber = Donordgv.Rows[e.RowIndex].Cells["SlipNumber"].Value.ToString();
                    donation.DonationDate = Donordgv.Rows[e.RowIndex].Cells["DonationDate"].Value.ToString();

                    donation.DonationType = Donordgv.Rows[e.RowIndex].Cells["DonationType"].Value.ToString();
                    //int ammount = (int) Donordgv.Rows[e.RowIndex].Cells["donationAmmount"].Value;

                    donation.DonationAmmount = (int)Donordgv.Rows[e.RowIndex].Cells["donationAmmount"].Value;

                    UpdateDonationDetails updateForm = new UpdateDonationDetails(donation);
                    updateForm.StartPosition = FormStartPosition.CenterScreen;
                    updateForm.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void GeneralDonationList_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Donation form = new Donation();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void DeleteAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি অনুদানের সকল তথ্য চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "অনুদানের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CRUDOperation.DeleteWithCondition("GeneralIncome", "IsDonation=N'হ্যাঁ'");
                CRUDOperation.DeleteAllData("Donations");
                MessageBox.Show("সকল তথ্য মুছে ফেলা হয়েছে।");
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
        }

        private void Backupbtn_Click(object sender, EventArgs e)
        {
            BackupOperation.Backup2Excel("Donations");
            MessageBox.Show("সফলভাবে অনুদানের তথ্য ব্যাকআপ নেয়া হয়েছে");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            (Donordgv.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("DonorName like '%" + searchNametxt.Text + "%'");
        }

        private void GeneralDonationList_Activated(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void GeneralDonationList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
