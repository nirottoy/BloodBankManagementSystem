using System;
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
        private void EmployeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement(this);
            employeeManagement.Show();
            this.Hide();
        }
        private void DonorsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorListForAdmin donorListForAdmin = new DonorListForAdmin(this);
            donorListForAdmin.Show();
            this.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BloodDonateFAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sites.google.com/view/projectbbms/home";
            faqWebBrowser.Navigate(url);
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sites.google.com/view/aboutusbbms/home";
            faqWebBrowser.Navigate(url);
        }
    }
}
