using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUMSM.Forms.User
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            
            SidePanelControl sidePanel = new SidePanelControl();

            // Set the properties of the side panel control
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 190;

            // Add the side panel control to the form
            Controls.Add(sidePanel);
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
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
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var UserName = "DUMSM";
            var oldPassword = OldPasswordtxt.Text;
            var newPassword = NewPasswordtxt.Text; 
            //var newName = newNametxt.Text;
            
            var password = CRUDOperation.GetColumnValues("Users", "Password", $"UserName = '{UserName}'");
            if (password[0].ToString() == oldPassword)
            {
                CRUDOperation.Update("Users", $"Password = N'{newPassword}' WHERE UserName = N'{UserName}'");
                MessageBox.Show("সফল হয়েছে");
            }
            else
            {
                MessageBox.Show("পুরাতন পাসওয়ার্ড ভুল হয়েছে।");
            }
        }
    }
}
