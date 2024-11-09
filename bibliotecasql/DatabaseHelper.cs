using System;
using System.Data.SqlClient;
using System.Configuration;

namespace bibliotecasql
{
    public class DatabaseHelper
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BibliotecaDB"].ConnectionString;
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            return connection;
        }

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = GetConnection();
            try
            {
                connection.Open();  
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar com o banco de dados: " + ex.Message);
                throw;  
            }
            return connection;  
        }

        public static void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();  
            }
        }
    }
}
