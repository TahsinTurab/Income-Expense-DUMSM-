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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new Teachers();
                teacher.Id = Idtxt.Text;
                teacher.Name = Nametxt.Text;
                teacher.Designation = Designationtxt.Text;
                teacher.JoinDate = RegisterDatetxt.Value.ToString("dd/MM/yyyy");
                teacher.MobileNumber = Mobiletxt.Text;

                var willInsert = true;

                string errorMessage = "";

                if (teacher.Id == "")
                {
                    errorMessage += " আইডি নাম্বার";
                    willInsert = false;
                }

                if (teacher.Name == "")
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }

                    errorMessage += " নাম";
                    willInsert = false;

                }

                if (teacher.MobileNumber == "" || Conversion.BnNumber2EnNumber(Mobiletxt.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(Mobiletxt.Text.Trim()).Length != 11)
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
                    CRUDOperation.Insert(teacher);
                    PopUpMessage.SuccessRegistrationMessage("শিক্ষকের তথ্য নিবন্ধন");
                    ResetForm();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "শিক্ষকের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("শিক্ষকের তথ্য নিবন্ধন");
            }
        }

        public void ResetForm()
        {
            Idtxt.Text = "";
            Nametxt.Text = "";
            Mobiletxt.Text = "";
            Designationtxt.Text = "";
            RegisterDatetxt.Value = DateTime.Now;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherList teacherList = new TeacherList();
            teacherList.Location = this.Location;
            teacherList.Show();
            this.Close();
        }
    }
}
