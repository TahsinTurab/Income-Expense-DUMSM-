using DUMSM.Classes;
using DUMSM.Forms;
using DUMSM.Forms.DonorForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM
{
    public partial class Donor : Form
    {
        
        public Donor()
        {
            InitializeComponent();

            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
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

                if(donor.Id == "")
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

        private void DonorTypetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxData(DonorTypetxt);
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

        private void DonorListbtn_Click(object sender, EventArgs e)
        {
            DonorList donorList = new DonorList();
            donorList.Location = this.Location;
            donorList.Show();
            this.Close();
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            LoadDonorList();
        }

        public void LoadDonorList()
        {
            var list = CRUDOperation.GetColumnValues("Donors", "DonorName");

            DonorComboBox.Items.AddRange(list.ToArray());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedDonor = DonorComboBox.SelectedItem;
                string DonorName = ((string)selectedDonor);

                string Condition = $"DonorName = N'{DonorName}'";

                var value = CRUDOperation.RetrieveRecord("Donors", Condition);
                var donor = new Donors();
                donor.Id = (string)value["Id"];
                donor.DonorName = (string)value["DonorName"];
                donor.Address = (string)value["Address"];
                donor.DonationAmmount = (int)value["DonationAmmount"];
                donor.DonorType = (string)value["DonorType"];
                donor.MobileNumber = (string)value["MobileNumber"];


                DonorProfile donorProfile = new DonorProfile(donor);
                donorProfile.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("দাতার নাম সিলেক্ট করুন"); 
            }
        }
    }
}
