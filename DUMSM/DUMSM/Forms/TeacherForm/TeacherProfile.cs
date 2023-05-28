using DUMSM.Classes;
using DUMSM.Forms;
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
    public partial class TeacherProfile : Form
    {
        Teachers oldTeacher;
        public TeacherProfile(Teachers teacher)
        {
            InitializeComponent();

            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);

            oldTeacher = teacher;
        }

        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            startPage();
        }

        public void startPage()
        {
            teacherId.Text = oldTeacher.Id;
            teacherName.Text = oldTeacher.Name;
            teacherDesignation.Text = oldTeacher.Designation;
            teacherJoinDate.Text = oldTeacher.JoinDate;
            teacherMobile.Text = oldTeacher.MobileNumber;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var Person = new Teachers();
                Person.Id = oldTeacher.Id;
                Person.Name = teacherName.Text;
                Person.Designation = teacherDesignation.Text;
                Person.JoinDate = teacherJoinDate.Text;
                Person.MobileNumber = teacherMobile.Text; 

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

                if (Person.MobileNumber == "" || Conversion.BnNumber2EnNumber(teacherMobile.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(teacherMobile.Text.Trim()).Length != 11)
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

        private void TeacherProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason != CloseReason.ApplicationExitCall)
            //{
            //    e.Cancel = true; // Cancel the close operation
            //    this.Hide(); // Hide the form instead of closing it
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }

        private void ProfileDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি এই প্রোফাইল চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "শিক্ষকবৃন্দের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                
                CRUDOperation.Delete("Teachers", oldTeacher.Id);

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
