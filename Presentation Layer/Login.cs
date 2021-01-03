using BloodBankManagementSystem.Business_Logic_Layer;
using BloodBankManagementSystem.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginFlatButton_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                AdminService adminService = new AdminService();
                bool resultAdmin = adminService.LoginValidation(usernameTextbox.Text, passwordTextBox.Text);
                if (resultAdmin)
                {
                    AdminHome adminHome = new AdminHome();
                    adminHome.Show();
                    this.Hide();
                }
                else
                {
                    EmployeeService employeeService = new EmployeeService();
                    bool resultEmployee = employeeService.LoginValidation(usernameTextbox.Text, passwordTextBox.Text);
                    if (resultEmployee)
                    {
                        EmployeeHome employeeHome = new EmployeeHome();
                        employeeHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Credentials");
                    }
                }
            }
        }
    }
}
