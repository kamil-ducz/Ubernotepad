﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ubernotepad
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "user" && passwordTextBox.Text == "user")
            {
                MessageBox.Show("Welcome!");
                MainForm showMainForm = new MainForm();
                showMainForm.Show();
                this.Visible = false;
            }                
            else MessageBox.Show("Incorrect login or password. Try again.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
