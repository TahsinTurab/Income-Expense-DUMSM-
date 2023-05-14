using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM
{
    public static class CRUDOperation
    {
        private static string connectionString = SQLConnection.conReturn();

        public static void Insert(object obj)
        {
            // Get the type of the object
            Type objType = obj.GetType();

            // Get the name of the table to insert data into
            string tableName = objType.Name;

            // Get the properties of the object
            PropertyInfo[] properties = objType.GetProperties();

            // Build the SQL query
            string query = $"INSERT INTO {tableName} (";
            for (int i = 0; i < properties.Length; i++)
            {
                query += $"{properties[i].Name}";
                if (i != properties.Length - 1)
                {
                    query += ",";
                }
            }
            query += ") VALUES (";
            for (int i = 0; i < properties.Length; i++)
            {
                var value = properties[i].GetValue(obj);
                if (value != null)
                {
                    if (properties[i].PropertyType == typeof(string))
                    {
                        query += 'N';
                    }
                    query += $"'{value.ToString()}'";
                }
                else
                {
                    query += "NULL";
                }
                if (i != properties.Length - 1)
                {
                    query += ",";
                }
            }
            query += ")";

            // Execute the SQL query using a connection and a command object
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void Delete(string tableName, string Id)
        {
            
            string query = $"DELETE FROM {tableName} WHERE  Id = '{Id}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }


    public static List<string> GetColumnValues(string tableName, string columnName)
        {
            List<string> values = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT {columnName} FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    values.Add(reader[columnName].ToString());
                }

                reader.Close();
            }

            return values;
        }

    public static List<string> GetColumnValues(string tableName, string columnName, string Condition)
    {
        List<string> values = new List<string>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = $"SELECT {columnName} FROM {tableName} Where {Condition}";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                values.Add(reader[columnName].ToString());
            }

            reader.Close();
        }

        return values;
    }


        public static void Update(Object obj)
        {

            // Get the type of the object
            Type objType = obj.GetType();

            // Get the name of the table to insert data into
            string tableName = objType.Name;

            // Get the properties of the object
            PropertyInfo[] properties = objType.GetProperties();

            // Build the SQL query
            string query = $"UPDATE {tableName} SET ";
            for (int i = 1; i < properties.Length; i++)
            {
                query += $"{properties[i].Name}=";
                var value = properties[i].GetValue(obj);
                if (value != null)
                {
                    if (properties[i].PropertyType == typeof(string))
                    {
                        query += 'N';
                    }
                    query += $"'{value.ToString()}'";
                }
                else
                {
                    query += "NULL";
                }
                if (i != properties.Length - 1)
                {
                    query += ",";
                }
            }

            query += $" WHERE Id={properties[0].GetValue(obj).ToString()}";
            
            

            // Execute the SQL query using a connection and a command object

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public static void DeleteAllData(string tableName)
        {
            string query = $"DELETE FROM {tableName}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

    }
}
