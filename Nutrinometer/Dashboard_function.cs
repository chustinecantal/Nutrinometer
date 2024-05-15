using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nutrinometer
{
    internal class Dashboard_function
    {
        private readonly string _connectionString;
        private readonly NutritionCalculation _nutritionCalculator;

        public Dashboard_function(string connectionString)
        {
            _connectionString = connectionString;
            _nutritionCalculator = new NutritionCalculation();
        }

        private T GetUserInformation<T>(int userId, string columnName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    // Construct the SQL query based on the column name and user ID
                    string query = $"SELECT {columnName} FROM userinfo WHERE UserId = {userId}";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Execute the query and retrieve the result
                    object result = command.ExecuteScalar();

                    // Convert the result to the desired data type
                    if (result != null && result != DBNull.Value)
                    {
                        return (T)Convert.ChangeType(result, typeof(T));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving {columnName}: {ex.Message}");
            }

            // Return default value if retrieval fails
            return default(T);
        }

        public void HandleUserInput(int userId, string date, string foodName, string meal, double portion)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    // Insert user intake record into the database
                    string query = @"INSERT INTO userintake (UserId, Date, FoodName, Meal, Portion) 
                            VALUES (@UserId, @Date, @FoodName, @Meal, @Portion)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@FoodName", foodName);
                    command.Parameters.AddWithValue("@Meal", meal);
                    command.Parameters.AddWithValue("@Portion", portion);
                    command.ExecuteNonQuery();
                    Console.WriteLine("User intake recorded successfully.");

                    // After recording the user intake, compute the total calories
                    double totalCalories = ComputeCalorieIntake(userId, date);

                    // Retrieve user information from the database
                    string sex = GetUserInformation<string>(userId, "Sex");
                    double weight = GetUserInformation<double>(userId, "Weight");
                    double height = GetUserInformation<double>(userId, "Height");
                    int age = GetUserInformation<int>(userId, "Age");
                    int activityLevel = GetUserInformation<int>(userId, "ActivityLevel");

                    // Calculate BMR and daily calories
                    double bmr = _nutritionCalculator.CalculateBMR(sex, weight, height, age);
                    double requiredCalories = _nutritionCalculator.CalculateDailyCalories(activityLevel, bmr);

                    // Analyze calorie intake
                    string username = GetUsername(userId); // Retrieve username
                    string status = _nutritionCalculator.AnalyzeCalories(username, totalCalories, requiredCalories);

                    // Display computed information
                    Console.WriteLine($"Total Calories: {totalCalories}");
                    Console.WriteLine($"Required Calories: {requiredCalories}");
                    Console.WriteLine($"Status: {status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error handling user input: " + ex.Message);
            }
        }

        public double ComputeCalorieIntake(int userId, string date)
        {
            double totalCalories = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = $"SELECT SUM(fi.Calories * ui.Portion) AS TotalCalories " +
                                   $"FROM userintake ui " +
                                   $"JOIN foodintake fi ON ui.FoodName = fi.Name " +
                                   $"WHERE ui.UserId = {userId} AND ui.Date = '{date}'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalCalories = Convert.ToDouble(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error computing calorie intake: " + ex.Message);
            }
            return totalCalories;
        }


        private string GetUsername(int userId)
        {
            string username = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = $"SELECT Username FROM userinfo WHERE UserId = {userId}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        username = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving username: " + ex.Message);
            }
            return username;
        }

    }
}
