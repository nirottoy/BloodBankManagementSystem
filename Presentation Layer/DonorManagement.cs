using System;
using System.Windows.Forms;
using BloodBankManagementSystem.Business_Logic_Layer;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class DonorManagement : Form
    {
        EmployeeHome employeeHome;
        int id = 0;
        public DonorManagement(EmployeeHome employeeHome)
        {
            this.employeeHome = employeeHome;
            InitializeComponent();
            DonorInsertButton.Click += this.RefreshGridView;
            DonorInsertButton.Click += this.ClearFields;
            DonorUpdateButton.Click += this.RefreshGridView;
            DonorUpdateButton.Click += this.ClearFields;
            DonorDeleteButton.Click += this.RefreshGridView;
            DonorDeleteButton.Click += this.ClearFields;
        }
        void ClearFields(object sender, EventArgs e)
        {
            addNametxt.Text = addAgetxt.Text = addWeighttxt.Text = addPulsetxt.Text = addHimoglobintxt.Text = addAddresscombo.Text = addPntxt.Text = addHealthtxt.Text = addRhcombo.Text = addBgcombo.Text = string.Empty;
            uNameTextbox.Text = uAgeTextbox.Text = uWeightTextbox.Text = uTempPulseTextbox.Text = uHaemoglobinTextbox.Text = uDivisionComboBox.Text = uPhoneNumberTextBox.Text = uMHITextBox.Text = uRhCombobox.Text = uBGCombo.Text = string.Empty;
        }
        private void DonorManagement_Load(object sender, EventArgs e)
        {
            DonorService ds = new DonorService();
            dataGridView1.DataSource = ds.GetAllListOfDoners();
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            DonorService ds = new DonorService();
            dataGridView1.DataSource = ds.GetAllListOfDoners();
        }
        private void DonorInsertButton_Click(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();

            if (addNametxt.Text == "")
            {
                MessageBox.Show("Name can not be empty");
            }
            else if (Convert.ToInt32(addAgetxt.Text) <= 18)
            {
                MessageBox.Show("Age must be at least 18.");
            }
            else if (Convert.ToDouble(addWeighttxt.Text) <= 50)
            {
                MessageBox.Show("Weight must be at least 50kg.");
            }
            else if (addPulsetxt.Text == "")
            {
                MessageBox.Show("Pulse can not be empty");
            }
            else if (addHimoglobintxt.Text == "")
            {
                MessageBox.Show("Haemoglobin Rate can not be empty");
            }
            else if (addPntxt.Text == "")
            {
                MessageBox.Show("Insert Phone Number");
            }
            else if (addAddresscombo.Text == "")
            {
                MessageBox.Show("Insert Address");
            }
            else if (addHealthtxt.Text == "")
            {
                MessageBox.Show("Comment on health issues");
            }
            else if (addRhcombo.Text == "")
            {
                MessageBox.Show("Select Rh-Factor");
            }
            else if (addBgcombo.Text == "")
            {
                MessageBox.Show("Select Blood Group");
            }
            else
            {
                int result = donorService.AddNewDonor(addNametxt.Text,
                                                        Convert.ToInt32(addAgetxt.Text),
                                                        Convert.ToDouble(addWeighttxt.Text),
                                                        addPulsetxt.Text,
                                                        Convert.ToDouble(addHimoglobintxt.Text),
                                                        addAddresscombo.Text,
                                                        addPntxt.Text,
                                                        addRhcombo.Text,
                                                        addBgcombo.Text,
                                                        dateTimePicker1.Value,
                                                        addHealthtxt.Text);

                if (result > 0)
                {
                    MessageBox.Show("Donor Added Successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding donor.");
                }
            }
        }
        private void DonorUpdateButton_Click(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();
            int result = donorService.UpdateDonor(id,
                                                  uNameTextbox.Text,
                                                  Convert.ToInt32(uAgeTextbox.Text),
                                                  Convert.ToDouble(uWeightTextbox.Text),
                                                  uTempPulseTextbox.Text,
                                                  Convert.ToDouble(uHaemoglobinTextbox.Text),
                                                  uDivisionComboBox.Text,
                                                  uPhoneNumberTextBox.Text,
                                                  uRhCombobox.Text,
                                                  uBGCombo.Text,
                                                  uLDDDatetimePicker.Value,
                                                  uMHITextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Donor's details updated successfully");
            }
            else
            {
                MessageBox.Show("Error in updating donor's details");
            }
        }
        private void DonorDeleteButton_Click(object sender, EventArgs e)
        {
            DonorService donorService = new DonorService();
            int result = donorService.DeleteDonor(deleteIdtxt.Text);
            if (result > 0)
            {
                MessageBox.Show("Donor deleted successfully");
            }
            else
            {
                MessageBox.Show("Error in deleting Donor");
            }
        }
        private void DonorManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            uNameTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            uAgeTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            uWeightTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            uTempPulseTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            uHaemoglobinTextbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            uDivisionComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            uPhoneNumberTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            uMHITextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            uRhCombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            uBGCombo.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();   
        }

        private void EmployeeHomeButtton_Click(object sender, EventArgs e)
        {
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
