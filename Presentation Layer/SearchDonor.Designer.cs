
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class SearchDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DonorByDivisionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DonorByBloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchDonorHomeButton = new System.Windows.Forms.Button();
            this.searchDonorLogoutButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.DonorByDivisionComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(711, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 474);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donors By Division";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 132);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(635, 336);
            this.dataGridView2.TabIndex = 2;
            // 
            // DonorByDivisionComboBox
            // 
            this.DonorByDivisionComboBox.FormattingEnabled = true;
            this.DonorByDivisionComboBox.Location = new System.Drawing.Point(116, 56);
            this.DonorByDivisionComboBox.Name = "DonorByDivisionComboBox";
            this.DonorByDivisionComboBox.Size = new System.Drawing.Size(519, 30);
            this.DonorByDivisionComboBox.TabIndex = 1;
            this.DonorByDivisionComboBox.SelectedIndexChanged += new System.EventHandler(this.DonorByDivisionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Division";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Group";
            // 
            // DonorByBloodGroupComboBox
            // 
            this.DonorByBloodGroupComboBox.FormattingEnabled = true;
            this.DonorByBloodGroupComboBox.Location = new System.Drawing.Point(116, 56);
            this.DonorByBloodGroupComboBox.Name = "DonorByBloodGroupComboBox";
            this.DonorByBloodGroupComboBox.Size = new System.Drawing.Size(519, 30);
            this.DonorByBloodGroupComboBox.TabIndex = 1;
            this.DonorByBloodGroupComboBox.SelectedIndexChanged += new System.EventHandler(this.DonorByBloodGroupComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 336);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.DonorByBloodGroupComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Donors By Blood Group";
            // 
            // searchDonorHomeButton
            // 
            this.searchDonorHomeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDonorHomeButton.Location = new System.Drawing.Point(1268, 12);
            this.searchDonorHomeButton.Name = "searchDonorHomeButton";
            this.searchDonorHomeButton.Size = new System.Drawing.Size(90, 35);
            this.searchDonorHomeButton.TabIndex = 3;
            this.searchDonorHomeButton.Text = "Home";
            this.searchDonorHomeButton.UseVisualStyleBackColor = true;
            this.searchDonorHomeButton.Click += new System.EventHandler(this.searchDonorHomeButton_Click);
            // 
            // searchDonorLogoutButton
            // 
            this.searchDonorLogoutButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDonorLogoutButton.Location = new System.Drawing.Point(1268, 704);
            this.searchDonorLogoutButton.Name = "searchDonorLogoutButton";
            this.searchDonorLogoutButton.Size = new System.Drawing.Size(90, 33);
            this.searchDonorLogoutButton.TabIndex = 4;
            this.searchDonorLogoutButton.Text = "Logout";
            this.searchDonorLogoutButton.UseVisualStyleBackColor = true;
            this.searchDonorLogoutButton.Click += new System.EventHandler(this.searchDonorLogoutButton_Click);
            // 
            // SearchDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.searchDonorLogoutButton);
            this.Controls.Add(this.searchDonorHomeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SearchDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management System - Search Donor by Blood Group & Area";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDonor_FormClosing);
            this.Load += new System.EventHandler(this.SearchDonor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox DonorByDivisionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DonorByBloodGroupComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchDonorHomeButton;
        private System.Windows.Forms.Button searchDonorLogoutButton;
    }
}