using System;
using System.Configuration;
using System.Data.SqlClient;

namespace BloodBankManagementSystem.Data_Access_Layer
{

    class DataAccess : IDisposable
    {
        SqlConnection connection;
        SqlCommand command;
        public DataAccess()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BBMS"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            SqlDataReader reader = this.command.ExecuteReader();
            return reader;
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            int result = this.command.ExecuteNonQuery();
            this.connection.Close();
            return result;
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}

