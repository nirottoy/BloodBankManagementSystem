using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                donor.SkinDisease = reader["SkinDisease"].ToString();
                donor.MajorHealthIssue = reader["MajorHealthIssue"].ToString();
                donor.RhFactor = reader["RhFactor"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                donor.LastDonatedDate = (DateTime)reader["LastDonatedDate"];
                donors.Add(donor);
            }
            return donors;
        }

        public Donor GetDonor(int id)
        {
            string sql = "SELECT * FROM Categories WHERE EmployeeId=" + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Donor donor = new Donor();
            donor.DonorId = (int)reader["DonorId"];
            donor.Name = reader["Name"].ToString();
            donor.Age = (int)reader["Age"];
            donor.Weight = (Double)reader["Weight"];
            donor.TempPulse = reader["TempPulse"].ToString();
            donor.Haemoglobin = (Double)reader["Haemoglobin"];
            donor.SkinDisease = reader["SkinDisease"].ToString();
            donor.MajorHealthIssue = reader["MajorHealthIssue"].ToString();
            donor.RhFactor = reader["RhFactor"].ToString();
            donor.BloodGroup = reader["BloodGroup"].ToString();
            donor.LastDonatedDate = (DateTime)reader["LastDonatedDate"];
            return donor;
        }

        public int InsertDonor(Donor donor)
        {
            string sql = "INSERT INTO Donors(Name,Age,Weight,TempPulse,Haemoglobin,SkinDisease,MajorHealthIssues,RhFactor,BloodGroup,LastDonatedDate) VALUES('" + donor.Name + "','" + donor.Age + "','" + donor.Weight + "','" + donor.TempPulse + "','" + donor.Haemoglobin + "','" + donor.SkinDisease + "','" + donor.MajorHealthIssue + "','" + donor.RhFactor + "','" + donor.BloodGroup + "','" + donor.LastDonatedDate + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateDonor(Donor donor)
        {
            string sql = "UPDATE Donors SET Name = '" + donor.Name + "', Age = '" + donor.Age + "', Weight = '" + donor.Weight + "', TempPulse = '" + donor.TempPulse + "', Haemoglobin = '" + donor.Haemoglobin + "', SkinDisease = '" + donor.SkinDisease + "', MajorHealthIssue = '" + donor.MajorHealthIssue + "', RhFactor = '" + donor.RhFactor + "', BloodGroup = '" + donor.BloodGroup + "', LastDonatedDate = '" + donor.LastDonatedDate + "' WHERE EventId = " + donor.DonorId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteDonor(int id)
        {
            string sql = "DELETE FROM Donors WHERE DonorId=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        

    }
}
