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
                updateForm.ShowDialog();


            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Location = this.Location;
            this.Close();
            income.ShowDialog();
        }
    }
}
