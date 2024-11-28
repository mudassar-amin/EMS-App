using System;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Directory
{
    internal class Functions
    {
        private readonly SqlConnection Con;
        private SqlCommand Cmd;
        private readonly string ConStr;

        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sunrise\OneDrive\Documents\EmDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
        }

        public DataTable GetData(string Query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand Cmd = new SqlCommand(Query, Con))
                {
                    if (parameters != null)
                    {
                        Cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter sda = new SqlDataAdapter(Cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or show a friendly error message
                Console.WriteLine($"Error retrieving data: {ex.Message}");
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }

            return dt;
        }

        public int SetData(string Query, SqlParameter[] parameters = null)
        {
            int affectedRows = 0;

            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (SqlCommand Cmd = new SqlCommand(Query, Con))
                {
                    if (parameters != null)
                    {
                        Cmd.Parameters.AddRange(parameters);
                    }

                    affectedRows = Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log the exception or show a friendly error message
                Console.WriteLine($"Error executing command: {ex.Message}");
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }

            return affectedRows;
        }
    }
}
