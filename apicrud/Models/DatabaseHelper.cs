using MySql.Data.MySqlClient;

namespace apicrud.Models
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=cobadotnet;Uid=root;Pwd= ;";

        public string TestConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return "Database connection successful.";
            }
            catch (Exception ex)
            {
                return $"Error connecting to database: {ex.Message}";
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
