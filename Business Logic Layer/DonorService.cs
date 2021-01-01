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
        public int AddNewDoners(string dnName, string dnGender, int dnAge, int dnWeight, string dnPulse, int dnHimoglobin, string dnSkin, string dnHealthissue, string dnRhfactor, string dnBloodgroup, DateTime dnLastdate)
        {
            Donor doner = new Donor()
            doner.Name = dnName;
            doner.Gender = dnGender;
            doner.Age = dnAge;
            doner.Weight = dnWeight;
            doner.TempPulse = dnPulse;
            doner.Haemoglobin = dnHimoglobin;
            doner.SkinDisease = dnSkin;
            doner.MajorHealthIssue = dnHealthissue;
            doner.BloodGroup = dnBloodgroup;
            doner.RhFactor = dnRhfactor;
            doner.LastDonatedDate = dnLastdate;
        }
    }
}
