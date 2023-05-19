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
    public partial class TeacherProfile : Form
    {
        Teachers oldTeacher;
        public TeacherProfile(Teachers teacher)
        {
            InitializeComponent();
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
            this.Hide();
            Teacher teacher = new Teacher();
            teacher.ShowDialog();
        }
    }
}
