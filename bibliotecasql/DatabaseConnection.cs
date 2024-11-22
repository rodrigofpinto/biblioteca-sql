using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace biblioteca_sql
{
    public class DatabaseConnection
    {
        private static SqlConnection con;
        private static string conString = "Data Source=LAPTOP-M12AA0DA; Initial Catalog=biblioteca; Integrated Security=True; Encrypt=False; TrustServerCertificate=True";

        // Abre a conexão com o banco de dados
        public static void OpenConnection()
        {
            if (con == null)
                con = new SqlConnection(conString);

            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        // Fecha a conexão com o banco de dados
        public static void CloseConnection()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        // Executa comandos SQL que não retornam dados (como INSERT, UPDATE, DELETE)
        public static bool ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando: " + ex.Message);
                return false;
            }
        }

        // Executa comandos SQL que retornam dados (como SELECT)
        public static SqlDataReader ExecuteQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, con);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteReader();
        }
    }
}