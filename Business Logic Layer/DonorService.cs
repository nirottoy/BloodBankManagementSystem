using BloodBankManagementSystem.Data_Access_Layer;
using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;

namespace BloodBankManagementSystem.Business_Logic_Layer
{
    class DonorService
    {
        DonorDataAccess donorAccess;

        public DonorService()
        {
            this.donorAccess = new DonorDataAccess();
        }
        public List<Donor> GetAllListOfDoners()
        {
            return this.donorAccess.GetAllDonors();
        }

        public int AddNewDonor(string name, int age, double weight, string temp, double haemoglobin, string address, string phoneNumber, string rhF, string bloodGroup, DateTime lastDonatedDate, string majorHealthIssue)
        {
            Donor donor = new Donor();

            donor.Name = name;
            donor.Age = age;
            donor.Weight = weight;
            donor.TempPulse = temp;
            donor.Haemoglobin = haemoglobin;
            donor.Address = address;
            donor.PhoneNumber = phoneNumber;
            donor.RhFactor = rhF;
            donor.BloodGroup = bloodGroup;
            donor.LastDonatedDate = lastDonatedDate;
            donor.MajorHealthIssue = majorHealthIssue;

            return this.donorAccess.InsertDonor(donor);
        }

        public int UpdateDonor(int id, string uName, int uAge, double uWeight, string uTemp, double uHaemoglobin, string uAddress, string uPhoneNumber, string uRhf, string uBg, DateTime uLDD, string uMHI)
        {

            Donor donor = new Donor()
            {
                DonorId = id,
                Name = uName,
                Age = uAge,
                Weight = uWeight,
                TempPulse = uTemp,
                Haemoglobin = uHaemoglobin,
                Address = uAddress,
                PhoneNumber = uPhoneNumber,
                RhFactor = uRhf,
                BloodGroup = uBg,
                LastDonatedDate = uLDD,
                MajorHealthIssue = uMHI
            };
            return this.donorAccess.UpdateDonor(donor);

        }
        public int DeleteDonor(string donorID)
        {
            return this.donorAccess.DeleteDonor(Convert.ToInt32(donorID));

        }

        public List<string> GetBloodGroupList()
        {
            return this.donorAccess.GetBloodGroup();
        }

        public List<string> GetAddressList()
        {
            return this.donorAccess.GetAddress();
        }

        public List<Donor> GetBloodGroupListForSearch(string bg)
        {
            return donorAccess.GetDonorForSearch(bg);
        }

        public List<Donor> GetDnrByAddressSearch(string address)
        {
            return donorAccess.GetDonorByAddressSearch(address);
        }
    }
}
