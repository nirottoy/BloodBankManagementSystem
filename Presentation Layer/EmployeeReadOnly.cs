using BloodBankManagementSystem.Business_Logic_Layer;
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
    public partial class EmployeeReadOnly : Form
    {
        public EmployeeReadOnly()
        {
            InitializeComponent();
        }

        private void EmployeeReadOnly_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeReadOnly_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            dataGridView1.DataSource = employeeService.GetListOfEmployeesforEmployee();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            EmployeeHome employeeHome = new EmployeeHome();
            employeeHome.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
