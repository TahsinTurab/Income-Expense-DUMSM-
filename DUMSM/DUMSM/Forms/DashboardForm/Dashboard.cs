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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DUMSM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;

            //Topbar topbar = new Topbar();
            //topbar.Dock = DockStyle.Top;
            //topbar.Anchor = AnchorStyles.Right;
            
           // topbar.Height = 50;
            //topbar.Width = 150;

            // Add the user panel control to the form
            //Controls.Add(topbar);
            //topbar.BringToFront();


            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
        }

        private void DonationBtn_Click(object sender, EventArgs e)
        {
            Donation donation = new Donation();
        }

        private void IncomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExpenseBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalaryBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {

        }

        private void DonorBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
