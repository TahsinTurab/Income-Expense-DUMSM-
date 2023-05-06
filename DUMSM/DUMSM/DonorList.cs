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
    public partial class DonorList : Form
    {
        public DonorList()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DonorList_Load(object sender, EventArgs e)
        {
            this.donorsTableAdapter.Fill(this.dUMSMDataBaseDataSet.Donors);
            DataGridViewOperation.DisplayData(Donordgv, typeof(Donors).Name.ToString());
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Donor donorForm = new Donor();
            donorForm.Location = this.Location;
            donorForm.ShowDialog();
            //Application.Run(donorForm);
            this.Hide();
        }
    }
}
