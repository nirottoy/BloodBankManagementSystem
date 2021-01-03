using BloodBankManagementSystem.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BloodBankManagementSystem.Data_Access_Layer
{
    class AdminDataAccess
    {
        DataAccess dataAccess;
        public AdminDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Admin> GetAllAdmins()
        {
            string sql = "SELECT * FROM Admins";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Admin> admins = new List<Admin>();
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.AdminId = (int)reader["AdminId"];
                admin.AdminUsername = reader["AdminUsername"].ToString();
                admins.Add(admin);
            }
            return admins;
        }
        public int InsertAdmin(Admin admin)
        {
            string sql = "INSERT INTO Admins(AdminUsername, AdminPassword) VALUES('" + admin.AdminUsername + "','" + admin.AdminPassword + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Admins WHERE AdminUsername='" + username + "' AND AdminPassword='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
