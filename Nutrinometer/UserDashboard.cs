﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutrinometer
{
    public partial class UserDashboard : Form
    {
        private int userId;
        public UserDashboard()
        {
            InitializeComponent();
            this.userId = userId;
        }
        public void AuthenticateAndShow(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection();

            // Authenticate the user
            bool isAuthenticated = Database.AuthenticateUser(connection, username, password);

            if (isAuthenticated)
            {
                // Open the user dashboard
                this.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void lbl_showuserinfo_Click(object sender, EventArgs e)
        {

        }

        private void btn_addintake_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteintake_Click(object sender, EventArgs e)
        {

        }

        private void btn_showstatus_Click(object sender, EventArgs e)
        {

        }

        private void btn_signout_Click(object sender, EventArgs e)
        {

        }
    }
}
