﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI455ProjectActual
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        // Makes homepage Invisible and opens Navigation Page
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if ((Username_TextBox.Text).Equals("John") && (Password_TextBox.Text).Equals("password"))
            {
                homePage homePage = new homePage();
                this.Visible = false;
                homePage.Show();
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
                Username_TextBox.Text = null;
                Password_TextBox.Text = null;
            }
        }

        private void Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
