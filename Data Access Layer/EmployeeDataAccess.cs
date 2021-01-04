using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BloodBankManagementSystem.Data_Access_Layer
{
    class EmployeeDataAccess
    {
        DataAccess dataAccess;
        public EmployeeDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.Name = reader["Name"].ToString();
                employee.Username = reader["Username"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.DateOfBirth = (DateTime)reader["DateOfBirth"];
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Password = reader["Password"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> GetAllEmployeesForEmployee()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.Name = reader["Name"].ToString();
                employee.Username = reader["Username"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.DateOfBirth = (DateTime)reader["DateOfBirth"];
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Password = "***Encrypted***";
                employees.Add(employee);
            }
            return employees;
        }

        public int InsertEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(Name, Username, Email, DateOfBirth, BloodGroup, Password) VALUES('" + employee.Name + "','"+employee.Username+"','"+employee.Email+"','"+employee.DateOfBirth+"','"+employee.BloodGroup+"','"+employee.Password+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE Employees SET Name = '" + employee.Name + "', Username = '" + employee.Username + "', Email = '" + employee.Email + "', DateOfBirth = '" + employee.DateOfBirth + "', BloodGroup = '" + employee.BloodGroup + "' WHERE EmployeeId = " + employee.EmployeeId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteEmployee(int id)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Employees WHERE Username='" + username + "' AND Password='" + password + "'";
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
