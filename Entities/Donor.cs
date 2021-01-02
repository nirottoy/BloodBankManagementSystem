using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Entities
{
    class Donor
    {
        public int DonorId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string TempPulse { get; set; }
        public double Haemoglobin { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MajorHealthIssue { get; set; }
        public string RhFactor { get; set; }
        public string BloodGroup { get; set; }
        public DateTime LastDonatedDate { get; set; }
    }
}
