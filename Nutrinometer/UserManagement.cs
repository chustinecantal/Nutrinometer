using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Nutrinometer
{
    internal class UserManagement
    {
        private string connectionString; // Connection string for database access
        private MySqlConnection connection;

        public UserManagement(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool RegisterUser(string firstName, string lastName, string username, double weight, int age, char sex, double height, int activityLevel)
        {
            try
            {
                connection.Open();
                // SQL command to insert user data into the userinfo table
                string query = "INSERT INTO userinfo (username, firstname, lastname, weight, age, sex, height, activity_level) " +
                               "VALUES (@Username, @FirstName, @LastName, @Weight, @Age, @Sex, @Height, @ActivityLevel)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Weight", weight);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@Height", height);
                command.Parameters.AddWithValue("@ActivityLevel", activityLevel);
                command.ExecuteNonQuery();

                // Inform the user about their initial password (userId)
                int userId = (int)command.LastInsertedId; // Get the auto-generated userId
                MessageBox.Show($"User registered successfully. Your userId (initial password) is: {userId}");

                return true; // Registration successful
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!" + ex.Message);
                return false; // Registration failed
            }
        }




    }
}
