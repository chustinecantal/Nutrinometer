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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Validate form inputs
            if (ValidateInputs())
            {
                // Insert data into the database
                if (InsertUserData())
                {
                    // Inform user about successful registration
                    MessageBox.Show("Registration successful. Your user ID is: " + GenerateUserID());

                    // Close the registration form (assuming this is the registration form)
                    this.Close();

                    // Open the login form
                    Login loginForm = new Login();
                    loginForm.Show();
                }
                else
                {
                    // Inform user about registration failure
                    MessageBox.Show("Registration failed. Please try again later.");
                }
            }
            else
            {
                // Inform user about invalid inputs
                MessageBox.Show("Please fill in all required fields with valid data.");
            }
        }
        private bool ValidateInputs()
        {
            // Implement validation logic here
            // Check if all required fields are filled and data is in correct format
            // You can use if conditions to check each field individually
            if (string.IsNullOrWhiteSpace(txtbox_fname.Text) || string.IsNullOrWhiteSpace(txtbox_Lname.Text))
            {
                return false;
            }
            // Add more validation logic for other fields as needed...

            return true; // Return true if validation succeeds, false otherwise
        }

        private bool InsertUserData()
        {
            string connectionString = ;
            try
            {
                // Create UserManagement instance
                UserManagement userManager = new UserManagement(connectionString);

                // Extract data from form fields
                string firstName = txtbox_fname.Text;
                string lastName = txtbox_Lname.Text;
                string username = txtbox_username.Text;
                double weight = Convert.ToDouble(txtbox_weight.Text);
                int age = Convert.ToInt32(txtbox_age.Text);
                char sex = cmbox_sex.SelectedItem.ToString()[0]; // Assuming combo box items are single characters
                double height = Convert.ToDouble(txtbox_height.Text);
                int activityLevel = cmbox_actlevel.SelectedIndex; // Assuming combo box items are indexed starting from 0

                // Attempt user registration
                return userManager.RegisterUser(firstName, lastName, username, weight, age, sex, height, activityLevel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


        private string GenerateUserID()
        {
            // Generate a unique user ID using GUID
            return Guid.NewGuid().ToString();
        }

        private void txtbox_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbox_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_height_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbox_actlevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
