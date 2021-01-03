﻿using System;

namespace BloodBankManagementSystem.Entities
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }   
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Password { get; set; }
    }
}
