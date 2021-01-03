using BloodBankManagementSystem.Business_Logic_Layer;
using System;
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            adminHome.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void DonorListForAdmin_Load(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();
            donorListForAdminDataGridView.DataSource = donorService.GetAllListOfDoners();
        }
    }
}
