using BloodBankManagementSystem.Data_Access_Layer;
using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Business_Logic_Layer
{
    class EmployeeService
    {
        EmployeeDataAccess employeeDataAccess;
        public EmployeeService()
        {
            this.employeeDataAccess = new EmployeeDataAccess();
        }

        public List<Employee> GetListOfEmployees()
        {
            return this.employeeDataAccess.GetAllEmployees();
        }

        public int AddNewEmployee(string name, string username, string email, DateTime dateOfBirth, string bloodgroup, string password)
        {
            Employee employee = new Employee()
            {
                Name = name,
                Username = username,
                Email = email,
                DateOfBirth = dateOfBirth,
                BloodGroup = bloodgroup,
                Password = password
            };
            return this.employeeDataAccess.InsertEmployee(employee);
        }
        public int UpdateEmployee(int employeeId, string name, string username, string email, DateTime dateOfBirth, string bloodgroup, string password)
        {
            Employee employee = new Employee()
            {
                //EmployeeId = employeeId,
                Name = name,
                Username = username,
                Email = email,
                DateOfBirth = dateOfBirth,
                BloodGroup = bloodgroup,
                Password = password


            };
            return this.employeeDataAccess.UpdateEmployee(employee);
        }

        public int DeleteEmployee(string employeeId)
        {
            return this.employeeDataAccess.DeleteEmployee(Convert.ToInt32(employeeId));
        }
    }
}
