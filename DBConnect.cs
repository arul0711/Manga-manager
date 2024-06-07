using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DBconnect
{
    public class DBConnect : IDisposable
    {
        private MySqlConnection connection;
        private readonly string server;
        private readonly string database;
        private readonly string uid;
        private readonly string password;

        // Constructor
        public DBConnect()
        {
            server = "localhost"; // Change to your MySQL server address
            database = "quan_ly_truyen"; // Change to your database name
            uid = "arul"; // Change to your MySQL username
            password = "0946034116"; // Change to your MySQL password
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        // Open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle exception
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        break;
                }
                return false;
            }
        }

        // Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error while closing connection: {ex.Message}");
                return false;
            }
        }

        // Insert statement
        public void InsertRecord(string query, Dictionary<string, object> parameters)
        {
            ExecuteNonQuery(query, parameters);
        }

        // Select statement
        public MySqlDataReader ExecuteSelectQuery(string query, Dictionary<string, object> parameters)
        {
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    CloseConnection();
                    return null;
                }
            }
            return null;
        }

        // Update statement
        public void UpdateRecord(string query, Dictionary<string, object> parameters)
        {
            ExecuteNonQuery(query, parameters);
        }

        // Delete statement
        public void DeleteRecord(string query, Dictionary<string, object> parameters)
        {
            ExecuteNonQuery(query, parameters);
        }

        // Execute Non Query
        private void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        // Implement IDisposable
        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}
