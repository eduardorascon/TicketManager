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

    public class UserLogin
    {
        public DataTable login(string username, string password)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from users where username = @username and password = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

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

        public object getAllUsernames()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from users";

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
                    cmd.CommandText = @"select * from workers order by Id";

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

        public static int searchByName(string workerName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select Id from workers where workerName = @workerName";
                    cmd.Parameters.AddWithValue("@workerName", workerName);

                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable getAllEnabledWorkers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from workers where workerIsEnabled = 1 order by workerName";

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

        public bool updateWorker(int workerToUpate, bool status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"update workers set workerIsEnabled = @status where Id = @workerId";
                    cmd.Parameters.AddWithValue("@workerId", workerToUpate);
                    cmd.Parameters.AddWithValue("@status", !status);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class Task
    {
        public bool saveTask(string taskName, string taskDescription, DateTime taskStartDate, DateTime taskEndDate, int workerId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"insert into tasks(taskName, taskDescription, taskStartDate, taskEndDate, workerId) 
                                        values(@taskName, @taskDescription, @taskStartDate, @taskEndDate, @workerId)";
                    cmd.Parameters.AddWithValue("@taskName", taskName);
                    cmd.Parameters.AddWithValue("@taskDescription", taskDescription);
                    cmd.Parameters.AddWithValue("@taskStartDate", taskStartDate);
                    cmd.Parameters.AddWithValue("@taskEndDate", taskEndDate);
                    cmd.Parameters.AddWithValue("@workerId", workerId);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteTask(int taskToDelete)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"update tasks set taskIsDeleted = 1 where Id = @taskId";
                    cmd.Parameters.AddWithValue("@taskId", taskToDelete);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public object getAllActiveTasks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from active_tasks_view order by taskName";

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

        public DataTable getAllClosedTasks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from closed_tasks_view order by taskName";

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

        public bool closeTask(int taskToClose)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"update tasks set taskIsActive = 0, taskRealEndDate = GETDATE() where Id = @taskId";
                    cmd.Parameters.AddWithValue("@taskId", taskToClose);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}