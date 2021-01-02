using BloodBankManagementSystem.Business_Logic_Layer;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
            recruitButton.Click += this.RefreshGridView;
            recruitButton.Click += this.ClearFields;
            updateButton.Click += this.RefreshGridView;
            updateButton.Click += this.ClearFields;
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
            uNameTextbox.Text = uUsernameTextBox.Text = uEmailTextBox.Text = uBgcomboBox1.Text = uPasswordTextbox.Text = uConfirmPasswordTextbox.Text = string.Empty;
        }

        private void recruitButton_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();

            if (nameTextbox.Text == "" || usernameTextbox.Text == "" || bgComboBox.Text == "" || passwordTextbox.Text == "" || confirmPasswordTextbox.Text == "")
            {
                MessageBox.Show("Fields can not be empty!");
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
                    MessageBox.Show("Employee added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding employee.");
                }
            }
        }

        private bool IsValidEmail(string text)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
