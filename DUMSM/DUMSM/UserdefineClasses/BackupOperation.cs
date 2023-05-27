using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace DUMSM
{
    internal static class BackupOperation
    {
        public static void Backup2Excel(string tableName)
        {
            

            string currentdatetime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            string LogFolder = @"C:\DUMSM\Logs";
            string connectionString = SQLConnection.conReturn();
            string queryString = $"select * from {tableName}";
            string filePath = @"C:\DUMSM\Backup\"+tableName+" ("+currentdatetime+").XLSX";
            string backupFolderPath = @"C:\DUMSM\Backup";
            try
            {
                if (!Directory.Exists(backupFolderPath))
                {
                    Directory.CreateDirectory(backupFolderPath);
                }

                if (File.Exists(filePath))
                    File.Delete(filePath);

                // Connect to the SQL Server database and retrieve the data you want to export
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a new Excel application and workbook
                            Application excelApp = new Application();
                            Workbook excelWorkbook = excelApp.Workbooks.Add();
                            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                            // Add the headers to the first row
                            int col = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
                                col++;
                            }

                            // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                            int row = 2;
                            while (reader.Read())
                            {
                                col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    if (reader.GetName(i) == "Id")
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[i].ToString();
                                    }
                                    else
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[i];
                                    }
                                    col++;
                                }
                                row++;
                            }

                            // Save the workbook and close the Excel application
                            excelWorkbook.SaveAs(filePath);
                            excelWorkbook.Close();
                            excelApp.Quit();
                        }
                    }
                }

            }

            catch (Exception exception)
            {
                if (!Directory.Exists(LogFolder))
                {
                    Directory.CreateDirectory(LogFolder);
                }

                using (StreamWriter sw = File.CreateText(LogFolder + "\\" + "ErrorLog_" + currentdatetime + ".log"))
                {
                    sw.WriteLine(exception.ToString());
                }

            }
        }
    }
}
