using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace Nutrinometer
{
    internal class CsvExporter
    {
        private MySqlConnection connection;

        public CsvExporter(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public void ExportTableToCsv(string tableName, string fileName)
        {
            try
            {
                // Create SQL command to select all data from the specified table
                string query = $"SELECT * FROM {tableName}";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Create a DataReader to fetch data from the database
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    // Create a StreamWriter to write data to a CSV file
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        // Write column headers to the CSV file
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            writer.Write(reader.GetName(i));
                            if (i < reader.FieldCount - 1)
                                writer.Write(",");
                            else
                                writer.WriteLine();
                        }

                        // Write data rows to the CSV file
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (!reader.IsDBNull(i))
                                {
                                    writer.Write(reader[i].ToString());
                                }
                                if (i < reader.FieldCount - 1)
                                    writer.Write(",");
                                else
                                    writer.WriteLine();
                            }
                        }
                    }
                }

                Console.WriteLine($"Table '{tableName}' exported to '{fileName}' successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting table '{tableName}' to CSV: {ex.Message}");
            }
        }
    }
}