using BloodBankManagementSystem.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Business_Logic_Layer
{
    class AdminService
    {
        AdminDataAccess adminDataAccess;
        public AdminService()
        {
            this.adminDataAccess = new AdminDataAccess();
        }
        public bool LoginValidation(string username, string password)
        {
            return adminDataAccess.LoginValidation(username, password);
        }
    }
}
