using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Nutrinometer
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stephanie perez\OneDrive\Documents\clientUser.mdf;Integrated Security = True; Connect Timeout = 30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!PasswordMeetsRequirements(signup_password.Text))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and one number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IsPureLetterPassword(signup_password.Text))
            {
                MessageBox.Show("Password must contain at least one number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(Person_No) FROM client WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        DateTime today = DateTime.Today;

                        string insertData = "INSERT INTO client (username, password, date_register) VALUES (@username, @password, @dateReg)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateReg", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private bool IsPureLetterPassword(string password)
        {
            // Check if password consists only of letters
            return password.All(char.IsLetter);
        }


        private bool PasswordMeetsRequirements(string password)
        {
            // Password must contain at least one uppercase letter, one lowercase letter, and one number
            return password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }


    }
}
