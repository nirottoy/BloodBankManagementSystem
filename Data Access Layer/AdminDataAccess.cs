using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Data_Access_Layer
{
    class AdminDataAccess
    {
        DataAccess dataAccess;
        public AdminDataAccess()
        {
            this.dataAccess = new DataAccess();
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
