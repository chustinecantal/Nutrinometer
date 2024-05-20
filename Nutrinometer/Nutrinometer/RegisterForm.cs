using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Nutrinometer
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@" Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stephanie perez\OneDrive\Documents\clientUser.mdf;Integrated Security = True; Connect Timeout = 30");

        public RegisterForm()
        {
            InitializeComponent();
            signup_password.PasswordChar = '*';
            signup_confirmPassword.PasswordChar = '*';
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
            signup_confirmPassword.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "" || signup_confirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!PasswordMeetsRequirements(signup_password.Text))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and one number", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_password.Text != signup_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string hashedPassword = HashPassword(signup_password.Text.Trim());

                        string insertData = "INSERT INTO client (username, password, date_register) VALUES (@username, @password, @dateReg)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", hashedPassword);
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

        private bool PasswordMeetsRequirements(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {
        }

        private void signup_confirmPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConfirmPass_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

