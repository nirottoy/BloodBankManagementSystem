using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Entities
{
    class Inventory
    {
        public int InventoryId { get; set; }
        public string BloodGroup { get; set; }
        public int Quantity { get; set; }
    }
}
