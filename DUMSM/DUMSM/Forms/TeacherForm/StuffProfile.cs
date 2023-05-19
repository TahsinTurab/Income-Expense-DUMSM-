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
            this.Hide();
            var teacher = new Teacher();
            teacher.ShowDialog();

        }
    }
}
