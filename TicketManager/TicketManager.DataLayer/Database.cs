using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TicketManager.DataLayer
{
    internal class Database
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["TicketManager.Properties.Settings.TicketManagerConnectionString"].ConnectionString;
    }

    public class Worker
    {
        public bool saveWorker(string workerName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"insert into workers(workerName) Values(@workerName)";
                    cmd.Parameters.AddWithValue("@workerName", workerName);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable getAllWorkers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from workers";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    public class Task
    {
        public bool saveTask(string taskDescription)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"insert into tasks(taskDescription) Values(@workerName)";
                    cmd.Parameters.AddWithValue("@taskDescription", taskDescription);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable getAllTasks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from tasks";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}