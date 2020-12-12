﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulsTimber
{
    public partial class frmLogin : Form
    {
        // Initalise form
        public frmLogin()
        {
            InitializeComponent();

            chkShow.Checked = false;

            txtPassword.UseSystemPasswordChar = true;
        }

        // Clear form's contents
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        // Login button to main form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = "testusername", password = "testpassword";

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide User Name and Password");
                return;
            }
            try
            {
                if (txtUserName.Text == userName && txtPassword.Text == password)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    FormInput formInput = new FormInput();
                    formInput.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Show/hides password characters based on whether check box is ticked or not
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        // Exit button to close program
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
