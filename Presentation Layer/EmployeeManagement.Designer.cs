
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.recruitButton = new System.Windows.Forms.Button();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bgComboBox = new System.Windows.Forms.ComboBox();
            this.confirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmIdTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uDobdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uBgcomboBox1 = new System.Windows.Forms.ComboBox();
            this.uEmailTextBox = new System.Windows.Forms.TextBox();
            this.uUsernameTextBox = new System.Windows.Forms.TextBox();
            this.uNameTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.employeeHomeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(953, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "List of Emloyees";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(200, 315);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(123, 31);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // recruitButton
            // 
            this.recruitButton.Location = new System.Drawing.Point(200, 478);
            this.recruitButton.Name = "recruitButton";
            this.recruitButton.Size = new System.Drawing.Size(123, 31);
            this.recruitButton.TabIndex = 17;
            this.recruitButton.Text = "Recruit";
            this.recruitButton.UseVisualStyleBackColor = true;
            this.recruitButton.Click += new System.EventHandler(this.RecruitButton_Click);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(147, 214);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(176, 18);
            this.dobDateTimePicker.TabIndex = 14;
            this.dobDateTimePicker.Value = new System.DateTime(2000, 1, 2, 0, 0, 0, 0);
            // 
            // bgComboBox
            // 
            this.bgComboBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgComboBox.FormattingEnabled = true;
            this.bgComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bgComboBox.Location = new System.Drawing.Point(147, 268);
            this.bgComboBox.Name = "bgComboBox";
            this.bgComboBox.Size = new System.Drawing.Size(176, 28);
            this.bgComboBox.TabIndex = 13;
            // 
            // confirmPasswordTextbox
            // 
            this.confirmPasswordTextbox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextbox.Location = new System.Drawing.Point(147, 394);
            this.confirmPasswordTextbox.Name = "confirmPasswordTextbox";
            this.confirmPasswordTextbox.PasswordChar = '*';
            this.confirmPasswordTextbox.Size = new System.Drawing.Size(176, 25);
            this.confirmPasswordTextbox.TabIndex = 12;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(147, 330);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(176, 25);
            this.passwordTextbox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(147, 163);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(176, 25);
            this.emailTextBox.TabIndex = 10;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(147, 107);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(176, 25);
            this.usernameTextbox.TabIndex = 9;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(147, 55);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(176, 25);
            this.nameTextbox.TabIndex = 8;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(200, 120);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(123, 31);
            this.deleteEmployeeButton.TabIndex = 20;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // deleteEmIdTextbox
            // 
            this.deleteEmIdTextbox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmIdTextbox.Location = new System.Drawing.Point(147, 36);
            this.deleteEmIdTextbox.Name = "deleteEmIdTextbox";
            this.deleteEmIdTextbox.Size = new System.Drawing.Size(176, 25);
            this.deleteEmIdTextbox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.deleteEmployeeButton);
            this.groupBox2.Controls.Add(this.deleteEmIdTextbox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(347, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 157);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Employee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Blood Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.GridColor = System.Drawing.SystemColors.Info;
            this.employeeDataGridView.Location = new System.Drawing.Point(684, 59);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.Size = new System.Drawing.Size(674, 460);
            this.employeeDataGridView.TabIndex = 22;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.recruitButton);
            this.groupBox1.Controls.Add(this.dobDateTimePicker);
            this.groupBox1.Controls.Add(this.bgComboBox);
            this.groupBox1.Controls.Add(this.confirmPasswordTextbox);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.usernameTextbox);
            this.groupBox1.Controls.Add(this.nameTextbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 515);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recruit Employee";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.UpdateButton);
            this.groupBox3.Controls.Add(this.uDobdateTimePicker1);
            this.groupBox3.Controls.Add(this.uBgcomboBox1);
            this.groupBox3.Controls.Add(this.uEmailTextBox);
            this.groupBox3.Controls.Add(this.uUsernameTextBox);
            this.groupBox3.Controls.Add(this.uNameTextbox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(347, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 352);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Information";
            // 
            // uDobdateTimePicker1
            // 
            this.uDobdateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uDobdateTimePicker1.Location = new System.Drawing.Point(147, 193);
            this.uDobdateTimePicker1.MaxDate = new System.DateTime(2002, 12, 31, 0, 0, 0, 0);
            this.uDobdateTimePicker1.Name = "uDobdateTimePicker1";
            this.uDobdateTimePicker1.Size = new System.Drawing.Size(176, 18);
            this.uDobdateTimePicker1.TabIndex = 14;
            this.uDobdateTimePicker1.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // uBgcomboBox1
            // 
            this.uBgcomboBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uBgcomboBox1.FormattingEnabled = true;
            this.uBgcomboBox1.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.uBgcomboBox1.Location = new System.Drawing.Point(147, 238);
            this.uBgcomboBox1.Name = "uBgcomboBox1";
            this.uBgcomboBox1.Size = new System.Drawing.Size(176, 28);
            this.uBgcomboBox1.TabIndex = 13;
            // 
            // uEmailTextBox
            // 
            this.uEmailTextBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uEmailTextBox.Location = new System.Drawing.Point(147, 143);
            this.uEmailTextBox.Name = "uEmailTextBox";
            this.uEmailTextBox.Size = new System.Drawing.Size(176, 25);
            this.uEmailTextBox.TabIndex = 10;
            // 
            // uUsernameTextBox
            // 
            this.uUsernameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uUsernameTextBox.Location = new System.Drawing.Point(147, 90);
            this.uUsernameTextBox.Name = "uUsernameTextBox";
            this.uUsernameTextBox.Size = new System.Drawing.Size(176, 25);
            this.uUsernameTextBox.TabIndex = 9;
            // 
            // uNameTextbox
            // 
            this.uNameTextbox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameTextbox.Location = new System.Drawing.Point(147, 46);
            this.uNameTextbox.Name = "uNameTextbox";
            this.uNameTextbox.Size = new System.Drawing.Size(176, 25);
            this.uNameTextbox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Blood Group";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "Date of Birth";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 22);
            this.label16.TabIndex = 2;
            this.label16.Text = "E-mail";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Username";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 22);
            this.label18.TabIndex = 0;
            this.label18.Text = "Name";
            // 
            // employeeHomeButton
            // 
            this.employeeHomeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeHomeButton.Location = new System.Drawing.Point(1268, 12);
            this.employeeHomeButton.Name = "employeeHomeButton";
            this.employeeHomeButton.Size = new System.Drawing.Size(90, 31);
            this.employeeHomeButton.TabIndex = 25;
            this.employeeHomeButton.Text = "Home";
            this.employeeHomeButton.UseVisualStyleBackColor = true;
            this.employeeHomeButton.Click += new System.EventHandler(this.EmployeeHomeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1268, 704);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(90, 33);
            this.logoutButton.TabIndex = 26;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.employeeHomeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management System - Employee Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button recruitButton;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.ComboBox bgComboBox;
        private System.Windows.Forms.TextBox confirmPasswordTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.TextBox deleteEmIdTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker uDobdateTimePicker1;
        private System.Windows.Forms.ComboBox uBgcomboBox1;
        private System.Windows.Forms.TextBox uEmailTextBox;
        private System.Windows.Forms.TextBox uUsernameTextBox;
        private System.Windows.Forms.TextBox uNameTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button employeeHomeButton;
        private System.Windows.Forms.Button logoutButton;
    }
}