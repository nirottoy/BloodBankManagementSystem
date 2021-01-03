using BloodBankManagementSystem.Data_Access_Layer;
using BloodBankManagementSystem.Entities;
using System.Collections.Generic;

namespace BloodBankManagementSystem.Business_Logic_Layer
{
    class AdminService
    {
        AdminDataAccess adminDataAccess;
        public AdminService()
        {
            this.adminDataAccess = new AdminDataAccess();
        }

        public List<Admin> GetListOfAdmins()
        {
            return this.adminDataAccess.GetAllAdmins();
        }
        public int AddNewAdmin(string username, string password)
        {
            Admin admin = new Admin();
            {
                admin.AdminUsername = username;
                admin.AdminPassword = password;
            };
            return this.adminDataAccess.InsertAdmin(admin);
        }


        public bool LoginValidation(string username, string password)
        {
            return adminDataAccess.LoginValidation(username, password);
        }
    }
}
