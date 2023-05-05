using DUMSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM
{
    public partial class Donor : Form
    {
        
        public Donor()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            var donor = new DonerClass();
            donor.DonorName = DonorNametxt.Text;
            donor.MobileNumber = MobileNumbertxt.Text;
            donor.Address = Addresstxt.Text;
            object selectedItem = DonorTypetxt.SelectedValue;
            donor.DonorType = ((string)selectedItem);

            int result;
            var IsDonationAmmountOK = int.TryParse(DonationAmmounttxt.Text, out result);

            var willInsert = true;

            if (IsDonationAmmountOK)
            {
                donor.DonationAmmount = Convert.ToInt32(DonationAmmounttxt.Text);
            }
            else
            {
                PopUpMessage.DataMissingMessage("ধার্যকৃত অনুদান", "দাতার তথ্য নিবন্ধন");
                willInsert = false;
            }
            
            if(donor.DonorName == "")
            {
                PopUpMessage.DataMissingMessage("দাতার নাম", "দাতার তথ্য নিবন্ধন");
                willInsert = false;
                
            }

            if (donor.MobileNumber == "")
            {
                PopUpMessage.DataMissingMessage("মোবাইল নাম্বার", "দাতার তথ্য নিবন্ধন");
                willInsert = false;

            }

            if (willInsert)
            {
                CRUDOperation.Insert(donor);
            }



        }

        private void DonorTypetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
