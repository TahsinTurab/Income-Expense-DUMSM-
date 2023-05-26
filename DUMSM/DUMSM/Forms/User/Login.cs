﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Passwordtxt.UseSystemPasswordChar = true;
        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string UserName = UserNametxt.Text;
            string Password = Passwordtxt.Text;

            var userPassword = CRUDOperation.GetColumnValues("Users", "Password", $"UserName = '{UserName}'");

            if (userPassword.Count > 0)
            {
                bool findUser = false;
                foreach (var password in userPassword)
                {
                    if (password == Password)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.StartPosition = FormStartPosition.CenterScreen;
                        dashboard.Show();
                        this.Hide();
                        findUser = true;
                        break;
                    }

                }
                if (!findUser)
                {
                    MessageBox.Show("লগ ইন তথ্য ভুল হয়েছে!");
                }
            }

            else
            {
                MessageBox.Show("লগ ইন তথ্য ভুল হয়েছে!");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}