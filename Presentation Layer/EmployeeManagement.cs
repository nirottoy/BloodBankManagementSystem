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
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
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


            int result = employeeService.AddNewEmployee(nameTextbox.Text,
                                                  usernameTextbox.Text,
                                                  emailTextBox.Text,
                                                  dobDateTimePicker.Value,
                                                  bgComboBox.Text,
                                                  passwordTextbox.Text);
            if (result > 0)
            {
                MessageBox.Show("Employee added successfully");
            }
            else
            {
                MessageBox.Show("Error in adding employee.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //EmployeeService employeeService = new EmployeeService();


            //int result = employeeService.UpdateEmployee(id, uNameTextbox.Text,);
            //if (result > 0)
            //{
            //    MessageBox.Show("Employee added successfully");
            //}
            //else
            //{
            //    MessageBox.Show("Error in adding employee.");
            //}
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)employeeDataGridView.Rows[e.RowIndex].Cells[0].Value;
            updateEventNameTextBox.Text = LoadEventsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            UpdateImportanceComboBox.Text = LoadEventsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            UpdateNoteTextBox.Text = LoadEventsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            updateDateTimePicker.Value = (DateTime)LoadEventsDataGridView.Rows[e.RowIndex].Cells[5].Value;
        }
    }
}
