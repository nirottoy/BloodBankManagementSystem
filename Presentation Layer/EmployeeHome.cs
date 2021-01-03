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

        private void ManageDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorManagement donorManagement = new DonorManagement(this);
            donorManagement.Show();
            this.Hide();
        }

        private void FaqBloodDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sites.google.com/view/projectbbms/home";
            faqWebBrowser.Navigate(url);
        }

        private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://sites.google.com/view/aboutusbbms/home";
            faqWebBrowser.Navigate(url);
        }

        private void SearchDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonor searchDonor = new SearchDonor(this);
            searchDonor.Show();
            this.Hide();
        }

        private void emManagementButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
