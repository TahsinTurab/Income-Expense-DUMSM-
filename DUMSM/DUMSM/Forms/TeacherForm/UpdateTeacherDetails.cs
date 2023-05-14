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
    public partial class UpdateTeacherDetails : Form
    {
        private Teachers oldTeacher;
        public UpdateTeacherDetails(Teachers teacher)
        {
            InitializeComponent();
            oldTeacher = teacher;

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTeacherDetails_Load(object sender, EventArgs e)
        {
            DonorNametxt.Text = oldTeacher.Name;
            Idtxt.Text = oldTeacher.Id;
            MobileNumbertxt.Text = oldTeacher.MobileNumber;
            Designationtxt.Text = oldTeacher.Designation;
            JoinDatetxt.Text = oldTeacher.JoinDate;
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new Teachers();
                teacher.Name = DonorNametxt.Text.Trim();
                teacher.Id = Idtxt.Text.Trim();
                teacher.MobileNumber = MobileNumbertxt.Text.Trim();
                teacher.Designation = Designationtxt.Text.Trim();
                teacher.JoinDate = JoinDatetxt.Text.Trim();

                //var check = Convert.ToInt32(numberString);

                var willInsert = true;

                string errorMessage = "";


                if (teacher.MobileNumber == "" || Conversion.BnNumber2EnNumber(MobileNumbertxt.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(MobileNumbertxt.Text.Trim()).Length != 11)
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
                    CRUDOperation.Update(teacher);
                    PopUpMessage.SuccessRegistrationMessage("শিক্ষক তথ্য আপডেট");
                    this.Close();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "শিক্ষক তথ্য আপডেট");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("শিক্ষক তথ্য আপডেট");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
