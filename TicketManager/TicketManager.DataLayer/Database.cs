﻿using System;
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

        public object getAllActiveTasks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Database.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = @"select * from tasks where taskIsActive = 1";

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