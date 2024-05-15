using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrinometer
{
    internal class Database
    {
        private string connectionString;
        private MySqlConnection connection;

        public Database(string server, string database, string username, string password)
        {
            // Construct the connection string
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        }

        public void Connect()
        {
            this.connection = new MySqlConnection(this.connectionString);
            try
            {
                this.connection.Open();
                Console.WriteLine("Connection success");
                //Connection to the database successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!" + ex.Message);
                this.connection = null;
            }
           
        }

        public void Disconnect(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connection Disconnected");
               //Database Disconnected
            }
        }

        public void ExecuteNonQuery(MySqlConnection connection, string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Query executed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!" + ex.Message);
            }
        }

        public void CreateTables()
        {
            this.Connect();

            string createUserinfoTableQuery = @"CREATE TABLE IF NOT EXISTS userinfo (
                                                UserId INT AUTO_INCREMENT PRIMARY KEY,
                                                Username VARCHAR(50) NOT NULL,
                                                FirstName VARCHAR(50),
                                                LastName VARCHAR(50),
                                                Weight DOUBLE,
                                                Age INT,
                                                Sex CHAR(1),
                                                Height DOUBLE,
                                                ActivityLevel INT
                                              )";

            string createFoodIntakeTableQuery = @"CREATE TABLE IF NOT EXISTS foodintake (
                                                FoodName VARCHAR(50) PRIMARY KEY,
                                                Category ENUM('Fruits', 'Vegetables', 'Meat', 'Seafood', 'Drinks'),
                                                Calories INT
                                              )";

            string createUserIntakeTableQuery = @"CREATE TABLE IF NOT EXISTS userintake (
                                                UserId INT,
                                                Date DATE,
                                                FoodName VARCHAR(50),
                                                Meal ENUM('Breakfast', 'Lunch', 'Dinner'),
                                                Portion INT,
                                                FOREIGN KEY (UserId) REFERENCES userinfo(UserId),
                                                FOREIGN KEY (FoodName) REFERENCES foodintake(FoodName)
                                              )";

            ExecuteNonQuery(this.connection, createUserinfoTableQuery);
            ExecuteNonQuery(this.connection, createFoodIntakeTableQuery);
            ExecuteNonQuery(this.connection, createUserIntakeTableQuery);    
        }

        public void ExportTablesToCsv()
        {
            CsvExporter exporter = new CsvExporter(this.connection);
            exporter.ExportTableToCsv("userinfo", "userinfo.csv");
            exporter.ExportTableToCsv("foodintake", "foodintake.csv");
            exporter.ExportTableToCsv("userintake", "userintake.csv");
        }

        public static bool AuthenticateUser(MySqlConnection connection, string username, string password)
        {
            bool isAuthenticated = false;
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM userinfo WHERE Username = @Username AND UserId = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int count = (int)command.ExecuteScalar();
                isAuthenticated = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error authenticating user: " + ex.Message);
            }
            return isAuthenticated;
        }

        public static int GetUserId(MySqlConnection connection, string username)
        {
            int userId = -1; // Default value if user is not found
            try
            {
                connection.Open();
                string query = "SELECT UserId FROM userinfo WHERE Username = @Username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving user ID: " + ex.Message);
            }
            return userId;
        }

        public void DisplayUserInfo(MySqlConnection connection, int userId)
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM userinfo WHERE UserId = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"User Information:");
                        Console.WriteLine($"Username: {reader["Username"]}");
                        Console.WriteLine($"First Name: {reader["FirstName"]}");
                        Console.WriteLine($"Last Name: {reader["LastName"]}");
                        Console.WriteLine($"Weight: {reader["Weight"]}");
                        Console.WriteLine($"Age: {reader["Age"]}");
                        Console.WriteLine($"Sex: {reader["Sex"]}");
                        Console.WriteLine($"Height: {reader["Height"]}");
                        Console.WriteLine($"Activity Level: {reader["ActivityLevel"]}");
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error displaying user information: " + ex.Message);
            }
        }


    }
}
