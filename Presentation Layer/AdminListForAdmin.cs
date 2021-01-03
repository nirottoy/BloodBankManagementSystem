using BloodBankManagementSystem.Business_Logic_Layer;
using System;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class AdminListForAdmin : Form
    {
        public AdminListForAdmin()
        {
            InitializeComponent();
            addAdminButton.Click += this.RefreshGridView;
            addAdminButton.Click += this.ClearFields;
        }

        void RefreshGridView(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();
            dataGridView1.DataSource = adminService.GetListOfAdmins();
        }

        void ClearFields(object sender, EventArgs e)
        {
            addAdminUsernameTextbox.Text = addAdminPasswordTextbox.Text = string.Empty;
        }

        private void AdminListForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void AdminListForAdmin_Load(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();
            dataGridView1.DataSource = adminService.GetListOfAdmins();
        }

        private void addAdminButton_Click(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();

            if (addAdminUsernameTextbox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (addAdminPasswordTextbox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                int result = adminService.AddNewAdmin(addAdminUsernameTextbox.Text, addAdminPasswordTextbox.Text);
                if (result > 0)
                {
                    MessageBox.Show("New Admin Added.");
                }
                else
                {
                    MessageBox.Show("Error in adding admin.");
                }
            }
        }
    }
}
