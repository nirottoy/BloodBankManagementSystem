
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class DonorManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorManagement));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DonorDeleteButton = new System.Windows.Forms.Button();
            this.deleteIdtxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.uDivisionComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.uPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.uMHITextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.DonorUpdateButton = new System.Windows.Forms.Button();
            this.uLDDDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.uRhCombobox = new System.Windows.Forms.ComboBox();
            this.uBGCombo = new System.Windows.Forms.ComboBox();
            this.uAgeTextbox = new System.Windows.Forms.TextBox();
            this.uWeightTextbox = new System.Windows.Forms.TextBox();
            this.uHaemoglobinTextbox = new System.Windows.Forms.TextBox();
            this.uTempPulseTextbox = new System.Windows.Forms.TextBox();
            this.uNameTextbox = new System.Windows.Forms.TextBox();
            this.addAddresscombo = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.addPntxt = new System.Windows.Forms.TextBox();
            this.DonorInsertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.addHealthtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addRhcombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addBgcombo = new System.Windows.Forms.ComboBox();
            this.addAgetxt = new System.Windows.Forms.TextBox();
            this.addWeighttxt = new System.Windows.Forms.TextBox();
            this.addHimoglobintxt = new System.Windows.Forms.TextBox();
            this.addPulsetxt = new System.Windows.Forms.TextBox();
            this.addNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.employeeHomeButtton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(814, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 596);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // DonorDeleteButton
            // 
            this.DonorDeleteButton.Location = new System.Drawing.Point(236, 120);
            this.DonorDeleteButton.Name = "DonorDeleteButton";
            this.DonorDeleteButton.Size = new System.Drawing.Size(129, 33);
            this.DonorDeleteButton.TabIndex = 27;
            this.DonorDeleteButton.Text = "Delete Donor";
            this.DonorDeleteButton.UseVisualStyleBackColor = true;
            this.DonorDeleteButton.Click += new System.EventHandler(this.DonorDeleteButton_Click);
            // 
            // deleteIdtxt
            // 
            this.deleteIdtxt.Location = new System.Drawing.Point(126, 63);
            this.deleteIdtxt.Name = "deleteIdtxt";
            this.deleteIdtxt.Size = new System.Drawing.Size(239, 26);
            this.deleteIdtxt.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.DonorDeleteButton);
            this.groupBox3.Controls.Add(this.deleteIdtxt);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(408, 519);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 159);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Donor";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 22);
            this.label21.TabIndex = 1;
            this.label21.Text = "Donor ID";
            // 
            // uDivisionComboBox
            // 
            this.uDivisionComboBox.FormattingEnabled = true;
            this.uDivisionComboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Barishal",
            "Mymensingh",
            "Khulna",
            "Rajshahi",
            "Rangpur",
            "Sylhet"});
            this.uDivisionComboBox.Location = new System.Drawing.Point(165, 215);
            this.uDivisionComboBox.Name = "uDivisionComboBox";
            this.uDivisionComboBox.Size = new System.Drawing.Size(197, 30);
            this.uDivisionComboBox.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.uPhoneNumberTextBox);
            this.groupBox2.Controls.Add(this.uMHITextBox);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.uDivisionComboBox);
            this.groupBox2.Controls.Add(this.DonorUpdateButton);
            this.groupBox2.Controls.Add(this.uLDDDatetimePicker);
            this.groupBox2.Controls.Add(this.uRhCombobox);
            this.groupBox2.Controls.Add(this.uBGCombo);
            this.groupBox2.Controls.Add(this.uAgeTextbox);
            this.groupBox2.Controls.Add(this.uWeightTextbox);
            this.groupBox2.Controls.Add(this.uHaemoglobinTextbox);
            this.groupBox2.Controls.Add(this.uTempPulseTextbox);
            this.groupBox2.Controls.Add(this.uNameTextbox);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 501);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Donor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Division";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 22);
            this.label11.TabIndex = 44;
            this.label11.Text = "Last Donate Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 41;
            this.label13.Text = "Phone Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 22);
            this.label14.TabIndex = 36;
            this.label14.Text = "Blood Group";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 22);
            this.label15.TabIndex = 43;
            this.label15.Text = "Rh Factor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 22);
            this.label16.TabIndex = 40;
            this.label16.Text = "Haemoglobin Rate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 419);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 22);
            this.label17.TabIndex = 42;
            this.label17.Text = "Major Health Issues";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 22);
            this.label18.TabIndex = 39;
            this.label18.Text = "Pulse Rate";
            // 
            // uPhoneNumberTextBox
            // 
            this.uPhoneNumberTextBox.Location = new System.Drawing.Point(165, 255);
            this.uPhoneNumberTextBox.Name = "uPhoneNumberTextBox";
            this.uPhoneNumberTextBox.Size = new System.Drawing.Size(197, 26);
            this.uPhoneNumberTextBox.TabIndex = 32;
            // 
            // uMHITextBox
            // 
            this.uMHITextBox.Location = new System.Drawing.Point(166, 419);
            this.uMHITextBox.Multiline = true;
            this.uMHITextBox.Name = "uMHITextBox";
            this.uMHITextBox.Size = new System.Drawing.Size(197, 26);
            this.uMHITextBox.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 22);
            this.label19.TabIndex = 37;
            this.label19.Text = "Age";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 22);
            this.label20.TabIndex = 38;
            this.label20.Text = "Weight";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 22);
            this.label23.TabIndex = 35;
            this.label23.Text = "Name";
            // 
            // DonorUpdateButton
            // 
            this.DonorUpdateButton.Location = new System.Drawing.Point(218, 462);
            this.DonorUpdateButton.Name = "DonorUpdateButton";
            this.DonorUpdateButton.Size = new System.Drawing.Size(144, 33);
            this.DonorUpdateButton.TabIndex = 26;
            this.DonorUpdateButton.Text = "Update Donor";
            this.DonorUpdateButton.UseVisualStyleBackColor = true;
            this.DonorUpdateButton.Click += new System.EventHandler(this.DonorUpdateButton_Click);
            // 
            // uLDDDatetimePicker
            // 
            this.uLDDDatetimePicker.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uLDDDatetimePicker.Location = new System.Drawing.Point(165, 381);
            this.uLDDDatetimePicker.MaxDate = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.uLDDDatetimePicker.Name = "uLDDDatetimePicker";
            this.uLDDDatetimePicker.Size = new System.Drawing.Size(200, 20);
            this.uLDDDatetimePicker.TabIndex = 18;
            this.uLDDDatetimePicker.Value = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            // 
            // uRhCombobox
            // 
            this.uRhCombobox.FormattingEnabled = true;
            this.uRhCombobox.Items.AddRange(new object[] {
            "Rh+",
            "Rh-"});
            this.uRhCombobox.Location = new System.Drawing.Point(165, 289);
            this.uRhCombobox.Name = "uRhCombobox";
            this.uRhCombobox.Size = new System.Drawing.Size(197, 30);
            this.uRhCombobox.TabIndex = 14;
            // 
            // uBGCombo
            // 
            this.uBGCombo.FormattingEnabled = true;
            this.uBGCombo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.uBGCombo.Location = new System.Drawing.Point(165, 329);
            this.uBGCombo.Name = "uBGCombo";
            this.uBGCombo.Size = new System.Drawing.Size(197, 30);
            this.uBGCombo.TabIndex = 14;
            // 
            // uAgeTextbox
            // 
            this.uAgeTextbox.Location = new System.Drawing.Point(166, 65);
            this.uAgeTextbox.Name = "uAgeTextbox";
            this.uAgeTextbox.Size = new System.Drawing.Size(197, 26);
            this.uAgeTextbox.TabIndex = 23;
            // 
            // uWeightTextbox
            // 
            this.uWeightTextbox.Location = new System.Drawing.Point(166, 99);
            this.uWeightTextbox.Name = "uWeightTextbox";
            this.uWeightTextbox.Size = new System.Drawing.Size(197, 26);
            this.uWeightTextbox.TabIndex = 22;
            // 
            // uHaemoglobinTextbox
            // 
            this.uHaemoglobinTextbox.Location = new System.Drawing.Point(166, 180);
            this.uHaemoglobinTextbox.Name = "uHaemoglobinTextbox";
            this.uHaemoglobinTextbox.Size = new System.Drawing.Size(197, 26);
            this.uHaemoglobinTextbox.TabIndex = 16;
            // 
            // uTempPulseTextbox
            // 
            this.uTempPulseTextbox.Location = new System.Drawing.Point(166, 138);
            this.uTempPulseTextbox.Name = "uTempPulseTextbox";
            this.uTempPulseTextbox.Size = new System.Drawing.Size(197, 26);
            this.uTempPulseTextbox.TabIndex = 15;
            // 
            // uNameTextbox
            // 
            this.uNameTextbox.Location = new System.Drawing.Point(165, 28);
            this.uNameTextbox.Name = "uNameTextbox";
            this.uNameTextbox.Size = new System.Drawing.Size(198, 26);
            this.uNameTextbox.TabIndex = 14;
            // 
            // addAddresscombo
            // 
            this.addAddresscombo.FormattingEnabled = true;
            this.addAddresscombo.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Barishal",
            "Mymensingh",
            "Khulna",
            "Rajshahi",
            "Rangpur",
            "Sylhet"});
            this.addAddresscombo.Location = new System.Drawing.Point(174, 207);
            this.addAddresscombo.Name = "addAddresscombo";
            this.addAddresscombo.Size = new System.Drawing.Size(197, 30);
            this.addAddresscombo.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 215);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 22);
            this.label22.TabIndex = 29;
            this.label22.Text = "Division";
            // 
            // addPntxt
            // 
            this.addPntxt.Location = new System.Drawing.Point(175, 253);
            this.addPntxt.Name = "addPntxt";
            this.addPntxt.Size = new System.Drawing.Size(197, 26);
            this.addPntxt.TabIndex = 28;
            // 
            // DonorInsertButton
            // 
            this.DonorInsertButton.Location = new System.Drawing.Point(240, 462);
            this.DonorInsertButton.Name = "DonorInsertButton";
            this.DonorInsertButton.Size = new System.Drawing.Size(131, 33);
            this.DonorInsertButton.TabIndex = 27;
            this.DonorInsertButton.Text = "Register Donor";
            this.DonorInsertButton.UseVisualStyleBackColor = true;
            this.DonorInsertButton.Click += new System.EventHandler(this.DonorInsertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.addAddresscombo);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.addPntxt);
            this.groupBox1.Controls.Add(this.DonorInsertButton);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.addHealthtxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.addRhcombo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.addBgcombo);
            this.groupBox1.Controls.Add(this.addAgetxt);
            this.groupBox1.Controls.Add(this.addWeighttxt);
            this.groupBox1.Controls.Add(this.addHimoglobintxt);
            this.groupBox1.Controls.Add(this.addPulsetxt);
            this.groupBox1.Controls.Add(this.addNametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 501);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donor Registration";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 379);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Last Donate Date";
            // 
            // addHealthtxt
            // 
            this.addHealthtxt.Location = new System.Drawing.Point(174, 422);
            this.addHealthtxt.Multiline = true;
            this.addHealthtxt.Name = "addHealthtxt";
            this.addHealthtxt.Size = new System.Drawing.Size(197, 26);
            this.addHealthtxt.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone Number";
            // 
            // addRhcombo
            // 
            this.addRhcombo.FormattingEnabled = true;
            this.addRhcombo.Items.AddRange(new object[] {
            "Rh+",
            "Rh-"});
            this.addRhcombo.Location = new System.Drawing.Point(175, 289);
            this.addRhcombo.Name = "addRhcombo";
            this.addRhcombo.Size = new System.Drawing.Size(197, 30);
            this.addRhcombo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Major Health Issues";
            // 
            // addBgcombo
            // 
            this.addBgcombo.FormattingEnabled = true;
            this.addBgcombo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.addBgcombo.Location = new System.Drawing.Point(175, 329);
            this.addBgcombo.Name = "addBgcombo";
            this.addBgcombo.Size = new System.Drawing.Size(197, 30);
            this.addBgcombo.TabIndex = 14;
            // 
            // addAgetxt
            // 
            this.addAgetxt.Location = new System.Drawing.Point(175, 62);
            this.addAgetxt.Name = "addAgetxt";
            this.addAgetxt.Size = new System.Drawing.Size(197, 26);
            this.addAgetxt.TabIndex = 23;
            // 
            // addWeighttxt
            // 
            this.addWeighttxt.Location = new System.Drawing.Point(175, 95);
            this.addWeighttxt.Name = "addWeighttxt";
            this.addWeighttxt.Size = new System.Drawing.Size(197, 26);
            this.addWeighttxt.TabIndex = 22;
            // 
            // addHimoglobintxt
            // 
            this.addHimoglobintxt.Location = new System.Drawing.Point(175, 169);
            this.addHimoglobintxt.Name = "addHimoglobintxt";
            this.addHimoglobintxt.Size = new System.Drawing.Size(197, 26);
            this.addHimoglobintxt.TabIndex = 16;
            // 
            // addPulsetxt
            // 
            this.addPulsetxt.Location = new System.Drawing.Point(175, 129);
            this.addPulsetxt.Name = "addPulsetxt";
            this.addPulsetxt.Size = new System.Drawing.Size(197, 26);
            this.addPulsetxt.TabIndex = 15;
            // 
            // addNametxt
            // 
            this.addNametxt.Location = new System.Drawing.Point(174, 25);
            this.addNametxt.Name = "addNametxt";
            this.addNametxt.Size = new System.Drawing.Size(198, 26);
            this.addNametxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blood Group";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Rh Factor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Haemoglobin Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pulse Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(1338, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 35);
            this.label24.TabIndex = 45;
            this.label24.Text = "Donor List";
            // 
            // employeeHomeButtton
            // 
            this.employeeHomeButtton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeHomeButtton.Location = new System.Drawing.Point(1765, 32);
            this.employeeHomeButtton.Name = "employeeHomeButtton";
            this.employeeHomeButtton.Size = new System.Drawing.Size(127, 33);
            this.employeeHomeButtton.TabIndex = 31;
            this.employeeHomeButtton.Text = "Home";
            this.employeeHomeButtton.UseVisualStyleBackColor = true;
            this.employeeHomeButtton.Click += new System.EventHandler(this.EmployeeHomeButtton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1802, 950);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(90, 33);
            this.logoutButton.TabIndex = 46;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // DonorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.employeeHomeButtton);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DonorManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management System - Doonor Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonorManagement_FormClosing);
            this.Load += new System.EventHandler(this.DonorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DonorDeleteButton;
        private System.Windows.Forms.TextBox deleteIdtxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox uDivisionComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uPhoneNumberTextBox;
        private System.Windows.Forms.Button DonorUpdateButton;
        private System.Windows.Forms.DateTimePicker uLDDDatetimePicker;
        private System.Windows.Forms.ComboBox uRhCombobox;
        private System.Windows.Forms.ComboBox uBGCombo;
        private System.Windows.Forms.TextBox uAgeTextbox;
        private System.Windows.Forms.TextBox uWeightTextbox;
        private System.Windows.Forms.TextBox uMHITextBox;
        private System.Windows.Forms.TextBox uHaemoglobinTextbox;
        private System.Windows.Forms.TextBox uTempPulseTextbox;
        private System.Windows.Forms.TextBox uNameTextbox;
        private System.Windows.Forms.ComboBox addAddresscombo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox addPntxt;
        private System.Windows.Forms.Button DonorInsertButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox addRhcombo;
        private System.Windows.Forms.ComboBox addBgcombo;
        private System.Windows.Forms.TextBox addAgetxt;
        private System.Windows.Forms.TextBox addWeighttxt;
        private System.Windows.Forms.TextBox addHealthtxt;
        private System.Windows.Forms.TextBox addHimoglobintxt;
        private System.Windows.Forms.TextBox addPulsetxt;
        private System.Windows.Forms.TextBox addNametxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button employeeHomeButtton;
        private System.Windows.Forms.Button logoutButton;
    }
}