using BloodBankManagementSystem.Business_Logic_Layer;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class EmployeeManagement : Form
    {
        AdminHome adminHome;
        int id = 0;
        public EmployeeManagement(AdminHome adminHome)
        {
            this.adminHome = adminHome;
            InitializeComponent();
            recruitButton.Click += this.RefreshGridView;
            recruitButton.Click += this.ClearFields;
            UpdateButton.Click += this.RefreshGridView;
            UpdateButton.Click += this.ClearFields;
            deleteEmployeeButton.Click += this.RefreshGridView;
            deleteEmployeeButton.Click += this.ClearFields;
        }

        private void EmployeeManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            employeeDataGridView.DataSource = employeeService.GetListOfEmployees();
        }


        void RefreshGridView(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            employeeDataGridView.DataSource = employeeService.GetListOfEmployees();
        }

        void ClearFields(object sender, EventArgs e)
        {
            nameTextbox.Text = usernameTextbox.Text = emailTextBox.Text = bgComboBox.Text = passwordTextbox.Text = confirmPasswordTextbox.Text = string.Empty;
            uNameTextbox.Text = uUsernameTextBox.Text = uEmailTextBox.Text = uBgcomboBox1.Text = string.Empty;
        }

        private void RecruitButton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();

            if (nameTextbox.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (usernameTextbox.Text == "")
            {
                MessageBox.Show("Username can not be empty");

            }
            else if (bgComboBox.Text == "")
            {
                MessageBox.Show("Select Blood Group");

            }
            else if (passwordTextbox.Text == "")
            {
                MessageBox.Show("Password can not be empty");

            }
            else if (confirmPasswordTextbox.Text == "")
            {
                MessageBox.Show("Confirm Password can not be empty");
            }
            else if (passwordTextbox.Text != confirmPasswordTextbox.Text)
            {
                MessageBox.Show("Password doesn't match!");
            }
            else if (IsValidEmail(emailTextBox.Text) == false)
            {
                MessageBox.Show("Invalid email address.");
            }
            else
            {
                int result = employeeService.AddNewEmployee(nameTextbox.Text,
                                                  usernameTextbox.Text,
                                                  emailTextBox.Text,
                                                  dobDateTimePicker.Value,
                                                  bgComboBox.Text,
                                                  passwordTextbox.Text,
                                                  confirmPasswordTextbox.Text);
                if (result > 0)
                {
                    MessageBox.Show("New Employee Recruited.");
                }
                else
                {
                    MessageBox.Show("Error in adding employee.");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.UpdateEmployee(id, uNameTextbox.Text, uUsernameTextBox.Text, uEmailTextBox.Text, uDobdateTimePicker1.Value, uBgcomboBox1.Text);
            if (result > 0)
            {
                MessageBox.Show("Employee details updated successfully");
            }
            else
            {
                MessageBox.Show("Error in updating employee's details");
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int result = employeeService.DeleteEmployee(deleteEmIdTextbox.Text);
            if (result > 0)
            {
                MessageBox.Show("Employee deleted successfully");
            }
            else
            {
                MessageBox.Show("Error in deleting employee");
            }
        }

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)employeeDataGridView.Rows[e.RowIndex].Cells[0].Value;
            uNameTextbox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            uUsernameTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            uEmailTextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            uBgcomboBox1.Text = employeeDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        

        private void EmployeeHomeButton_Click(object sender, EventArgs e)
        {
            adminHome.Show();
            this.Hide();
        }
    }
}
