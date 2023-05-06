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

namespace DUMSM
{
    public partial class DonorList : Form
    {
        public DonorList()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
            {
                string id = Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString();

                DialogResult result = MessageBox.Show($"দাতার আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                    "স্থায়ী দাতাদের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    CRUDOperation.Delete("Donors", id);
                    MessageBox.Show("দাতার তথ্য মুছে ফেলা হয়েছে।");
                    //DisplayData();
                    

                }

                else
                {
                    MessageBox.Show("দাতার তথ্য মুছে ফেলা হয়নি।");

                }

            }

            else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
            {
                Donors donor = new Donors();
                donor.Id = Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
                donor.DonorName = Donordgv.Rows[e.RowIndex].Cells["donorName"].Value.ToString();
                donor.DonorType = Donordgv.Rows[e.RowIndex].Cells["donorType"].Value.ToString();
                donor.MobileNumber = Donordgv.Rows[e.RowIndex].Cells["Mobile"].Value.ToString();
                donor.Address = Donordgv.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                //int ammount = (int) Donordgv.Rows[e.RowIndex].Cells["donationAmmount"].Value;

                donor.DonationAmmount = (int) Donordgv.Rows[e.RowIndex].Cells["donationAmmount"].Value;

                UpdateDonorDetails updateForm = new UpdateDonorDetails(donor);
                updateForm.ShowDialog();

               
            }

        }

        private void DonorList_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        public void DisplayData()
        {
            //this.donorsTableAdapter.Fill(this.dUMSMDataBaseDataSet.Donors);
            //DataGridViewOperation.DisplayData(Donordgv, typeof(Donors).Name.ToString());
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(Donors).Name.ToString());
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Donor donorForm = new Donor();
            donorForm.Location = this.Location;
            donorForm.ShowDialog();
            //Application.Run(donorForm);
            this.Hide();
        }

        private void Idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var donor = new Donors();
                donor.Id = Idtxt.Text.Trim();
                donor.DonorName = DonorNametxt.Text.Trim();
                donor.MobileNumber = MobileNumbertxt.Text.Trim();
                donor.Address = Addresstxt.Text.Trim();
                object selectedItem = DonorTypetxt.SelectedItem;
                string type = ((string)selectedItem);
                donor.DonorType = ((string)selectedItem);

                var IsDonationAmmountOK = Conversion.BnNumber2EnNumber(DonationAmmounttxt.Text.Trim());

                //var check = Convert.ToInt32(numberString);

                var willInsert = true;

                string errorMessage = "";

                if (donor.Id == "")
                {
                    errorMessage += " আইডি নাম্বার";
                    willInsert = false;
                }

                if (donor.DonorName == "")
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }

                    errorMessage += " দাতার নাম";
                    willInsert = false;

                }

                if (donor.MobileNumber == "" || Conversion.BnNumber2EnNumber(MobileNumbertxt.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(MobileNumbertxt.Text.Trim()).Length != 11)
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " মোবাইল নাম্বার";

                    willInsert = false;

                }

                if (donor.DonorType == null)
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " দাতার ধরণ";

                    willInsert = false;
                }

                if (IsDonationAmmountOK != "false")
                {
                    donor.DonationAmmount = int.Parse(IsDonationAmmountOK);
                }
                else
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " ধার্যকৃত অনুদান";
                    willInsert = false;
                }

                if (willInsert)
                {
                    CRUDOperation.Insert(donor);
                    PopUpMessage.SuccessRegistrationMessage("দাতার তথ্য নিবন্ধন");
                    ResetForm();
                    DisplayData();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "দাতার তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("দাতার তথ্য নিবন্ধন");
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            Idtxt.Text = "";
            DonorNametxt.Text = "";
            DonorTypetxt.Text = "";
            DonationAmmounttxt.Text = "";
            MobileNumbertxt.Text = "";
            Addresstxt.Text = "";
        }

        private void DonorList_Activated(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
