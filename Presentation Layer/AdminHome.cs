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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }
        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(this);
            employeeManagement.Show();
            this.Hide();
        }
        private void donorsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorListForAdmin donorListForAdmin = new DonorListForAdmin(this);
            donorListForAdmin.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
