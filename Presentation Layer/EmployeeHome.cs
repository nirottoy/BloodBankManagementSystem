using System;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void EmployeeHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorManagement donorManagement = new DonorManagement(this);
            donorManagement.Show();
            this.Hide();
        }

        private void faqBloodDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sites.google.com/view/projectbbms/home";
            faqWebBrowser.Navigate(url);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sites.google.com/view/aboutusbbms/home";
            faqWebBrowser.Navigate(url);
        }
    }
}
