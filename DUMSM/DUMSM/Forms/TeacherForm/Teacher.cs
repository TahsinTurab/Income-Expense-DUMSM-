using DUMSM.Classes;
using DUMSM.Forms;
using DUMSM.Forms.TeacherForm;
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
            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);

            LoadPersonList();
        }

        public void LoadPersonList()
        {
            var teachers = CRUDOperation.GetColumnValues("Teachers", "Name");
            teacherList.Items.Clear();

            teacherList.Items.AddRange(teachers.ToArray());

            var stuffs = CRUDOperation.GetColumnValues("Stuffs", "Name");
            stuffList.Items.Clear();
            stuffList.Items.AddRange(stuffs.ToArray());
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
                    LoadPersonList();
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

        public void StuffResetForm()
        {
            StuffIdtxt.Text = "";
            StuffNametxt.Text = "";
            StuffMobiletxt.Text = "";
            StuffDesignationtxt.Text = "";
            StuffJoinDate.Value = DateTime.Now;
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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedPerson = teacherList.SelectedItem;
                string Name = ((string)selectedPerson);

                if (Name == null)
                {
                    MessageBox.Show("শিক্ষকের নাম সিলেক্ট করুন");
                }
                else
                {
                    string Condition = $"Name = N'{Name}'";

                    var value = CRUDOperation.RetrieveRecord("Teachers", Condition);
                    var Person = new Teachers();
                    Person.Id = (string)value["Id"];
                    Person.Name = (string)value["Name"];
                    Person.JoinDate = (string)value["JoinDate"];
                    Person.Designation = (string)value["Designation"];
                    Person.MobileNumber = (string)value["MobileNumber"];

                    this.Hide();
                    TeacherProfile Profile = new TeacherProfile(Person);
                    Profile.ShowDialog();
                    
                }
            }
            catch
            {
                MessageBox.Show("শিক্ষকের নাম সিলেক্ট করুন");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StuffResetForm();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var stuff = new Stuffs();
                stuff.Id = StuffIdtxt.Text;
                stuff.Name = StuffNametxt.Text;
                stuff.Designation = StuffDesignationtxt.Text;
                stuff.JoinDate = StuffJoinDate.Value.ToString("dd/MM/yyyy");
                stuff.MobileNumber = StuffMobiletxt.Text;

                var willInsert = true;

                string errorMessage = "";

                if (stuff.Id == "")
                {
                    errorMessage += " আইডি নাম্বার";
                    willInsert = false;
                }

                if (stuff.Name == "")
                {
                    if (errorMessage.Length > 0)
                    {
                        errorMessage += ',';
                    }

                    errorMessage += " নাম";
                    willInsert = false;

                }

                if (stuff.MobileNumber == "" || Conversion.BnNumber2EnNumber(StuffMobiletxt.Text.Trim()) == "false"
                    || Conversion.BnNumber2EnNumber(StuffMobiletxt.Text.Trim()).Length != 11)
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
                    CRUDOperation.Insert(stuff);
                    PopUpMessage.SuccessRegistrationMessage("স্টাফের তথ্য নিবন্ধন");
                    StuffResetForm();
                    LoadPersonList();
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

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedPerson = stuffList.SelectedItem;
                string Name = ((string)selectedPerson);
                if (Name == null)
                {
                    MessageBox.Show("স্টাফের নাম সিলেক্ট করুন");
                }

                else
                {
                    string Condition = $"Name = N'{Name}'";

                    var value = CRUDOperation.RetrieveRecord("Stuffs", Condition);
                    var Person = new Stuffs();
                    Person.Id = (string)value["Id"];
                    Person.Name = (string)value["Name"];
                    Person.JoinDate = (string)value["JoinDate"];
                    Person.Designation = (string)value["Designation"];
                    Person.MobileNumber = (string)value["MobileNumber"];

                    this.Hide();
                    StuffProfile Profile = new StuffProfile(Person);
                    Profile.ShowDialog();
                    
                }
            }
            catch
            {
                MessageBox.Show("স্টাফের নাম সিলেক্ট করুন");
            }
        }

        private void Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
