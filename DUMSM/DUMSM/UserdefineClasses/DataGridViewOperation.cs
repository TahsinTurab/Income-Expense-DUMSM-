using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DUMSM
{
    internal static class DataGridViewOperation
    {
        private static string connectionString = SQLConnection.conReturn();
        public static void DisplayData(DataGridView dataGrid, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = $"select * from {tableName}";
                //SqlCommand command = new SqlCommand(CommandText, connection);
                connection.Open();
                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);

                
                dataGrid.DataSource = dt;
                connection.Close();
            }
        }
        
        public static void GetDataFromDataBase(DataGridView dataGrid, string tableName)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                string query = $"SELECT * FROM {tableName}";
                SqlCommand sqlCommand = new SqlCommand(query,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"দুঃখিত! {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
