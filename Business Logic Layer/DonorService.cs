using BloodBankManagementSystem.Data_Access_Layer;
using BloodBankManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int AddNewDonor(string dnrName, int dnrAge, double dnrWeight, string dnrTemp, double dnrHimoglobin, string dnrAddress, string dnrPn, string dnrRhf, string dnrBg, DateTime dnrLast, string dnrHealth)
        {
            Donor dnr = new Donor();

            dnr.Name = dnrName;
            dnr.Age = dnrAge;
            dnr.Weight = dnrWeight;
            dnr.TempPulse = dnrTemp;
            dnr.Haemoglobin = dnrHimoglobin;
            dnr.Address = dnrAddress;
            dnr.PhoneNumber = dnrPn;
            dnr.RhFactor = dnrRhf;
            dnr.BloodGroup = dnrBg;
            dnr.LastDonatedDate = dnrLast;
            dnr.MajorHealthIssue = dnrHealth;

            return this.donorAccess.InsertDonor(dnr);
        }

        public int UpdateDonor(int id, string dnrName, int dnrAge, double dnrWeight, string dnrTemp, double dnrHimoglobin, string dnrAddress, string dnrPn, string dnrRhf, string dnrBg, DateTime dnrLast, string dnrHealth)
        {

            Donor donor = new Donor()
            {
                DonorId = id,
                Name = dnrName,
                Age = dnrAge,
                Weight = dnrWeight,
                TempPulse = dnrTemp,
                Haemoglobin = dnrHimoglobin,
                Address = dnrAddress,
                PhoneNumber = dnrPn,
                RhFactor = dnrRhf,
                BloodGroup = dnrBg,
                LastDonatedDate = dnrLast,
                MajorHealthIssue = dnrHealth
            };
            return this.donorAccess.UpdateDonor(donor);

        }
        public int DeleteDonor(string dnrId)
        {
            return this.donorAccess.DeleteDonor(Convert.ToInt32(dnrId));

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
