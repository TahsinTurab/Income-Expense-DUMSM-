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

namespace DUMSM.Forms.TeacherForm
{
    public partial class StuffProfile : Form
    {
        Stuffs oldStuff;
        public StuffProfile(Stuffs stuff)
        {
            InitializeComponent();


            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);
            oldStuff = stuff;
        }

        public void startPage()
        {
            stuffId.Text = oldStuff.Id;
            stuffName.Text = oldStuff.Name;
            stuffDesignation.Text = oldStuff.Designation;
            stuffJoinDate.Text = oldStuff.JoinDate;
            stuffMobile.Text = oldStuff.MobileNumber;
        }

        private void StuffProfile_Load(object sender, EventArgs e)
        {
            startPage();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var Person = new Teachers();
                Person.Id = oldStuff.Id;
                Person.Name = stuffName.Text;
                Person.Designation = stuffDesignation.Text;
                Person.JoinDate = stuffJoinDate.Text;
                Person.MobileNumber = stuffMobile.Text;

                var willInsert = true;

                string errorMessage = "";

                if (Person.Id == "")
                {
                    errorMessage += " আইডি নাম্বার";
                    willInsert = false;
                }

                if (Person.Name == "")
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }

                    errorMessage += " নাম";
                    willInsert = false;

                }

                if (Person.MobileNumber == "" || Conversion.BnNumber2EnNumber(stuffMobile.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(stuffMobile.Text.Trim()).Length != 11)
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }
                    errorMessage += " মোবাইল নাম্বার";

                    willInsert = false;

                }


                if (willInsert)
                {
                    CRUDOperation.Update(Person);
                    PopUpMessage.SuccessRegistrationMessage("শিক্ষকের তথ্য আপডেট");
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "শিক্ষকের তথ্য আপডেট");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("শিক্ষকের তথ্য আপডেট");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher form = new Teacher();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StuffProfile_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ProfileDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি এই প্রোফাইল চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "স্টাফদের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CRUDOperation.Delete("Stuffs", oldStuff.Id);
                

                Teacher form = new Teacher();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
            
        }
    }
}
