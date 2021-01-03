using BloodBankManagementSystem.Business_Logic_Layer;
using System;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class SearchDonor : Form
    {
        EmployeeHome employeeHome;
        public SearchDonor(EmployeeHome employeeHome)
        {
            this.employeeHome = employeeHome;
            InitializeComponent();
        }
        private void SearchDonor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchDonor_Load(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();
            dataGridView1.DataSource = donorService.GetAllListOfDoners();
            donorService = new DonorService();
            DonorByBloodGroupComboBox.DataSource = donorService.GetBloodGroupList();
            donorService = new DonorService();
            DonorByDivisionComboBox.DataSource = donorService.GetAddressList();
        }

        private void DonorByBloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();
            dataGridView1.DataSource = donorService.GetBloodGroupListForSearch(DonorByBloodGroupComboBox.Text);
        }

        private void DonorByDivisionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();
            dataGridView2.DataSource = donorService.GetDnrByAddressSearch(DonorByDivisionComboBox.Text);
        }

        private void searchDonorHomeButton_Click(object sender, EventArgs e)
        {
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
            this.Hide();
        }

        private void searchDonorLogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
