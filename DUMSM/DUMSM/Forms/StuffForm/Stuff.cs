using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DUMSM.Classes;

namespace DUMSM
{
    public partial class Stuff : Form
    {
        public Stuff()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = new Stuffs();
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
                    PopUpMessage.SuccessRegistrationMessage("স্টাফের তথ্য নিবন্ধন");
                    ResetForm();
                }
                else
                {
                    PopUpMessage.DataMissingMessage(errorMessage, "স্টাফের তথ্য নিবন্ধন");
                }
            }
            catch
            {
                PopUpMessage.ErrorMessage("স্টাফের তথ্য নিবন্ধন");
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
    }
}
