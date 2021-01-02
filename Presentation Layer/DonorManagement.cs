using System;
using System.Windows.Forms;
using BloodBankManagementSystem.Business_Logic_Layer;

namespace BloodBankManagementSystem.Presentation_Layer
{
    public partial class DonorManagement : Form
    {
        int id = 0;
        public DonorManagement()
        {
            InitializeComponent();
            doner_insert_button.Click += this.RefreshGridView;
            doner_insert_button.Click += this.ClearFields;
            donor_update_button.Click += this.RefreshGridView;
            donor_update_button.Click += this.ClearFields;
            delete_Doner_button.Click += this.RefreshGridView;
            delete_Doner_button.Click += this.ClearFields;
        }


        void ClearFields(object sender, EventArgs e)
        {
            addNametxt.Text = addAgetxt.Text = addWeighttxt.Text = addPulsetxt.Text = addHimoglobintxt.Text = addAddresscombo.Text = addPntxt.Text = addHealthtxt.Text = addRhcombo.Text = addBgcombo.Text = string.Empty;
            dnrNametxt.Text = dnrAgetxt.Text = dnrWeighttxt.Text = dnrPulsetxt.Text = dnrHimoglobintxt.Text = dnrAddresscombo.Text = dnrPntxt.Text = dnrHealthtxt.Text = dnrRhcombo.Text = dnrBgcombo.Text = string.Empty;
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

        private void doner_insert_button_Click(object sender, EventArgs e)
        {
            DonorService ds = new DonorService();
            int result = ds.AddNewDonor(addNametxt.Text, Convert.ToInt32(addAgetxt.Text), Convert.ToDouble(addWeighttxt.Text), addPulsetxt.Text, Convert.ToDouble(addHimoglobintxt.Text), addAddresscombo.Text, addPntxt.Text, addHealthtxt.Text, addRhcombo.Text, addBgcombo.Text, dateTimePicker1.Value);
            if (result > 0)
            {
                MessageBox.Show("Donor added successfully");
            }
            else if (addNametxt.Text == "")
            {
                MessageBox.Show("Name is required.");
            }

            else if (addAgetxt.Text == "")
            {
                MessageBox.Show("Age is required.");
            }

            else if (addWeighttxt.Text == "")
            {
                MessageBox.Show("Weight is required.");
            }

            else if (addPulsetxt.Text == "")
            {
                MessageBox.Show("Pulse is required.");
            }

            else if (addHimoglobintxt.Text == "")
            {
                MessageBox.Show("Haemoglobin is required.");
            }

            else if (addAddresscombo.Text == "")
            {
                MessageBox.Show("Address is required.");
            }

            else if (addPntxt.Text == "")
            {
                MessageBox.Show("Phone Number is Required");
            }

            else if (addHealthtxt.Text == "")
            {
                MessageBox.Show("Comment needed on major health issues.");
            }

            else if (addRhcombo.Text == "")
            {
                MessageBox.Show("Select Rh.");
            }

            else if (addBgcombo.Text == "")
            {
                MessageBox.Show("Select Blood Group");
            }

            else
            {
                MessageBox.Show("Error in adding donor");
            }
        }

        private void donor_update_button_Click(object sender, EventArgs e)
        {

            DonorService ds = new DonorService();
            int result = ds.UpdateDonor(id, dnrNametxt.Text, Convert.ToInt32(dnrAgetxt.Text), Convert.ToDouble(dnrWeighttxt.Text), dnrPulsetxt.Text, Convert.ToDouble(dnrHimoglobintxt.Text), dnrAddresscombo.Text, dnrPntxt.Text, dnrHealthtxt.Text, dnrRhcombo.Text, dnrBgcombo.Text, dateTimePicker2.Value);
            if (result > 0)
            {
                MessageBox.Show("Donor updated successfully");
            }
            else
            {
                MessageBox.Show("Error in updating donor");
            }
        }

        private void delete_Doner_button_Click(object sender, EventArgs e)
        {
            DonorService ds = new DonorService();
            int result = ds.DeleteEvent(deleteIdtxt.Text);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            dnrNametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dnrAgetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dnrWeighttxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dnrPulsetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dnrHimoglobintxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dnrAddresscombo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dnrPntxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dnrHealthtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            dnrRhcombo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            dnrBgcombo.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
