using BloodBankManagementSystem.Data_Access_Layer;
using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;

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

        public List<Employee> GetListOfEmployeesforEmployee()
        {
            return this.employeeDataAccess.GetAllEmployeesForEmployee();
        }
        public int AddNewEmployee(string name, string username, string email, DateTime dateOfBirth, string bloodgroup, string password, string confirmPassword)
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
        public int UpdateEmployee(int id, string name, string username, string email, DateTime dateOfBirth, string bloodgroup)
        {
            Employee employee = new Employee()
            {
                EmployeeId = id,
                Name = name,
                Username = username,
                Email = email,
                DateOfBirth = dateOfBirth,
                BloodGroup = bloodgroup
            };
            return this.employeeDataAccess.UpdateEmployee(employee);
        }

        public int DeleteEmployee(string employeeId)
        {
            return this.employeeDataAccess.DeleteEmployee(Convert.ToInt32(employeeId));
        }
        public bool LoginValidation(string username, string password)
        {
            return employeeDataAccess.LoginValidation(username, password);
        }
    }
}
