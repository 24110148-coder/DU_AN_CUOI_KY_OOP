using System.Data;
using System.Data.SqlClient;

namespace DU_AN_CUOI_KI_OOP.Data
{
    public class DatabaseConnection
    {
        private static string connectionString = "Data Source=YourServer;Initial Catalog=AppointmentDB;Integrated Security=True";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}