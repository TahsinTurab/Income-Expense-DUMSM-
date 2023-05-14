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
    public partial class TeacherList : Form
    {
        public TeacherList()
        {
            InitializeComponent();
        }

        private void Donordgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Donordgv.Columns[e.ColumnIndex].HeaderText == "ডিলিট")
            {
                string id = Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString();

                DialogResult result = MessageBox.Show($"শিক্ষকের আইডিঃ {id}\n\nআপনি এই তথ্যটি ডিলিট করতে ইচ্ছুক? ",
                    "শিক্ষকের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    CRUDOperation.Delete("Donors", id);
                    MessageBox.Show("শিক্ষকের তথ্য মুছে ফেলা হয়েছে।");
                    //DisplayData();


                }

                else
                {
                    MessageBox.Show("শিক্ষকের তথ্য মুছে ফেলা হয়নি।");

                }

            }

            else if (Donordgv.Columns[e.ColumnIndex].HeaderText.Trim() == "আপডেট")
            {
                var teacher = new Teachers();
                teacher.Id = Donordgv.Rows[e.RowIndex].Cells["id"].Value.ToString();
                teacher.Name = Donordgv.Rows[e.RowIndex].Cells["TeacherName"].Value.ToString();
                teacher.Designation = Donordgv.Rows[e.RowIndex].Cells["Designation"].Value.ToString();
                teacher.MobileNumber = Donordgv.Rows[e.RowIndex].Cells["Mobile"].Value.ToString();

                teacher.JoinDate = Donordgv.Rows[e.RowIndex].Cells["JoinDate"].Value.ToString();

                UpdateTeacherDetails updateForm = new UpdateTeacherDetails(teacher);
                updateForm.ShowDialog();


            }
        }

        public void DisplayData()
        {
            //this.donorsTableAdapter.Fill(this.dUMSMDataBaseDataSet.Donors);
            //DataGridViewOperation.DisplayData(Donordgv, typeof(Donors).Name.ToString());
            DataGridViewOperation.GetDataFromDataBase(Donordgv, typeof(Teachers).Name.ToString());
        }

        private void TeacherList_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Teacher teacherForm = new Teacher();
            teacherForm.Location = this.Location;
            teacherForm.ShowDialog();
            //Application.Run(donorForm);
            this.Hide();
        }

        private void TeacherList_Activated(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DeleteAllbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("আপনি শিক্ষকবৃন্দের সকল তথ্য চিরতরে মুছে ফেলতে চাচ্ছেন?",
                "শিক্ষকবৃন্দের তালিকা", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                CRUDOperation.DeleteAllData("Teachers");
                MessageBox.Show("সকল তথ্য মুছে ফেলা হয়েছে।");
            }
            else
            {
                MessageBox.Show("কোনো তথ্য মুছে ফেলা হয়নি।");
            }
        }

        private Bitmap bitmap;
        private void Printbtn_Click(object sender, EventArgs e)
        {
            int height = Donordgv.Height;
            Donordgv.Height = Donordgv.RowCount * Donordgv.RowTemplate.Height * 2;
            bitmap = new Bitmap(Donordgv.Width, Donordgv.Height);
            Donordgv.DrawToBitmap(bitmap, new Rectangle(0, 0, Donordgv.Width, Donordgv.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            Donordgv.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Backupbtn_Click(object sender, EventArgs e)
        {
            BackupOperation.Backup2Excel("Teachers");
            MessageBox.Show("সফলভাবে শিক্ষকবৃন্দের তথ্য ব্যাকআপ নেয়া হয়েছে");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            (Donordgv.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Name like '%" + searchNametxt.Text + "%'");
        }

        private void TeacherList_Load_1(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
