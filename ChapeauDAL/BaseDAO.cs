using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ChapeauModel;
using System.IO;

namespace ChapeauDAL
{
    public  class BaseDAO
    {
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        public BaseDAO()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db_retake1"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                {
                    connection.Open();
                }
            }
            catch 
            {
                throw;
            }
            return connection;
        }

        private void CloseConnection()
        {
            connection.Close();
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        protected int ReadCountData(DataTable dataTable)
        {
            int number = 0;

            foreach (DataRow dr in dataTable.Rows)
            {
                number = (int)dr["result"];
            }
            return number;
        }

        protected void WriteToErrorLog(string messege)
        {
            StreamWriter sw = File.AppendText("..\\..\\..\\Error Log.txt");
            sw.WriteLine($"Error occured at: {DateTime.Now}:");
            sw.WriteLine($"{messege}\n");
            sw.Close();
        }
    }

}


