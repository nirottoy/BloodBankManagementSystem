using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class DonorListForAdmin : Form
    {
        AdminHome adminHome;
        public DonorListForAdmin(AdminHome adminHome)
        {
            this.adminHome = adminHome;
            InitializeComponent();
        }

        private void DonorListForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            adminHome.Show();
            this.Hide();
        }
    }
}
