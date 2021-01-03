using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BloodBankManagementSystem.Data_Access_Layer
{
    class DonorDataAccess
    {
        DataAccess dataAccess;
        public DonorDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Donor> GetAllDonors()
        {
            string sql = "SELECT * FROM Donors";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Donor> donors = new List<Donor>();
            while (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorId = (int)reader["DonorId"];
                donor.Name = reader["Name"].ToString();
                donor.Age = (int)reader["Age"];
                donor.Weight = (Double)reader["Weight"];
                donor.TempPulse = reader["TempPulse"].ToString();
                donor.Haemoglobin = (Double)reader["Haemoglobin"];
                donor.Address = reader["Address"].ToString();
                donor.PhoneNumber = reader["PhoneNumber"].ToString();
                donor.RhFactor = reader["RhFactor"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                donor.LastDonatedDate = (DateTime)reader["LastDonatedDate"];
                donor.MajorHealthIssue = reader["MajorHealthIssue"].ToString();
                donors.Add(donor);
            }
            return donors;
        }

        //public Donor GetDonor(int id)
        //{
        //    string sql = "SELECT * FROM Categories WHERE EmployeeId=" + id;
        //    SqlDataReader reader = this.dataAccess.GetData(sql);
        //    reader.Read();
        //    Donor donor = new Donor();
        //    donor.DonorId = (int)reader["DonorId"];
        //    donor.Name = reader["Name"].ToString();
        //    donor.Age = (int)reader["Age"];
        //    donor.Weight = (Double)reader["Weight"];
        //    donor.TempPulse = reader["TempPulse"].ToString();
        //    donor.Haemoglobin = (Double)reader["Haemoglobin"];
        //    donor.Address = reader["Address"].ToString();
        //    donor.PhoneNumber = reader["PhoneNumber"].ToString();
        //    donor.RhFactor = reader["RhFactor"].ToString();
        //    donor.BloodGroup = reader["BloodGroup"].ToString();
        //    donor.LastDonatedDate = (DateTime)reader["LastDonatedDate"];
        //    donor.MajorHealthIssue = reader["MajorHealthIssue"].ToString();
        //    return donor;
        //}

        public int InsertDonor(Donor donor)
        {
            string sql = "INSERT INTO Donors(Name,Age,Weight,TempPulse,Haemoglobin,Address,PhoneNumber,RhFactor,BloodGroup,LastDonatedDate,MajorHealthIssue) VALUES('" + donor.Name + "','" + donor.Age + "','" + donor.Weight + "','" + donor.TempPulse + "','" + donor.Haemoglobin + "','" + donor.Address + "','" + donor.PhoneNumber + "','" + donor.RhFactor + "','" + donor.BloodGroup + "','" + donor.LastDonatedDate + "','" + donor.MajorHealthIssue + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateDonor(Donor donor)
        {
            string sql = "UPDATE Donors SET Name = '" + donor.Name + "', Age = '" + donor.Age + "', Weight = '" + donor.Weight + "', TempPulse = '" + donor.TempPulse + "', Haemoglobin = '" + donor.Haemoglobin + "', Address = '" + donor.Address + "', PhoneNumber = '" + donor.PhoneNumber + "', RhFactor = '" + donor.RhFactor + "', BloodGroup = '" + donor.BloodGroup + "', LastDonatedDate = '" + donor.LastDonatedDate + "',MajorHealthIssue = '" + donor.MajorHealthIssue + "' WHERE DonorId = " + donor.DonorId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteDonor(int id)
        {
            string sql = "DELETE FROM Donors WHERE DonorId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<Donor> GetDonorForSearch(string bloodGroup)
        {
            string sql = "SELECT * FROM Donors WHERE BloodGroup LIKE '" + bloodGroup + "'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Donor> donors = new List<Donor>();
            while (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorId = (int)reader["DonorId"];
                donor.Name = reader["Name"].ToString();
                donor.Age = (int)reader["Age"];
                donor.Weight = (double)reader["Weight"];
                donor.TempPulse = reader["TempPulse"].ToString();
                donor.Haemoglobin = (Double)reader["Haemoglobin"];
                donor.Address = reader["Address"].ToString();
                donor.PhoneNumber = reader["PhoneNumber"].ToString();
                donor.MajorHealthIssue = reader["MajorHealthIssue"].ToString();
                donor.RhFactor = reader["RhFactor"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                donor.LastDonatedDate = (DateTime)reader["LastDonatedDate"];
                donors.Add(donor);
            }
            return donors;
        }

        public List<Donor> GetDonorByAddressSearch(string address)
        {
            string sql = "SELECT * FROM Donors WHERE Address LIKE '" + address + "'";
            this.dataAccess = new DataAccess();
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Donor> donors = new List<Donor>();
            while (reader.Read())
            {
                Donor donor = new Donor();
                donor.DonorId = (int)reader["DonorId"];
                donor.Name = reader["Name"].ToString();
                donor.Age = (int)reader["Age"];
                donor.Weight = (double)reader["Weight"];
                donor.TempPulse = reader["TempPulse"].ToString();
                donor.Haemoglobin = (Double)reader["Haemoglobin"];
                donor.Address = reader["Address"].ToString();
                donor.PhoneNumber = reader["PhoneNumber"].ToString();
                donor.MajorHealthIssue = reader["MajorHealthIssue"].ToString();
                donor.RhFactor = reader["RhFactor"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                donor.LastDonatedDate = (DateTime)reader["LastDonatedDate"];
                donors.Add(donor);
            }
            return donors;
        }

        public List<string> GetBloodGroup()
        {
            string sql = "SELECT * FROM Donors";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> bloodGroups = new List<string>();
            while (reader.Read())
            {
                bloodGroups.Add(reader["BloodGroup"].ToString());
            }
            return bloodGroups;
        }

        public List<string> GetAddress()
        {
            string sql = "SELECT * FROM Donors";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> address = new List<string>();
            while (reader.Read())
            {
                address.Add(reader["Address"].ToString());
            }
            return address;
        }
    }
}
