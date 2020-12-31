using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                employee.Username = reader["Name"].ToString();
                employee.Email = reader["Name"].ToString();
                employee.Gender = reader["Name"].ToString();
                employee.DateOfBirth = (DateTime)reader["DateOfBirth"];
                employee.BloodGroup = reader["Name"].ToString();
                employee.Password = reader["Name"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            string sql = "SELECT * FROM Categories WHERE EmployeeId=" + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Employee employee = new Employee();
            employee.EmployeeId = (int)reader["EmployeeId"];
            employee.Name = reader["Name"].ToString();
            employee.Username = reader["Name"].ToString();
            employee.Email = reader["Name"].ToString();
            employee.Gender = reader["Name"].ToString();
            employee.DateOfBirth = (DateTime)reader["DateOfBirth"];
            employee.BloodGroup = reader["Name"].ToString();
            employee.Password = reader["Name"].ToString();
            return employee;
        }

        public int InsertEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(Name, Username, Email, Gender, DateOfBirth, BloodGroup, Password) VALUES('" + employee.Name + "','"+employee.Username+"','"+employee.Email+"','"+employee.Gender+"','"+employee.DateOfBirth+"','"+employee.BloodGroup+"','"+employee.Password+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE Employees SET Name = '" + employee.Name + "', Username = '" + employee.Username + "', Email = '" + employee.Email + "', Gender = '" + employee.Gender + "', DateOfBirth = '" + employee.DateOfBirth + "', BloodGroup = '" + employee.BloodGroup + "', Password = '" + employee.Password + "' WHERE EventId = " + employee.EmployeeId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteEmployee(int id)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public List<string> GetEmployeeNames()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> employees = new List<string>();
            while (reader.Read())
            {
                employees.Add(reader["Name"].ToString());
            }
            return employees;
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
