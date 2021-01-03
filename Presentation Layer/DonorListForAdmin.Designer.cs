
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class DonorListForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorListForAdmin));
            this.homeButton = new System.Windows.Forms.Button();
            this.donorListForAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.donorListForAdminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(1802, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(90, 33);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // donorListForAdminDataGridView
            // 
            this.donorListForAdminDataGridView.AllowUserToAddRows = false;
            this.donorListForAdminDataGridView.AllowUserToDeleteRows = false;
            this.donorListForAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donorListForAdminDataGridView.Location = new System.Drawing.Point(331, 112);
            this.donorListForAdminDataGridView.Name = "donorListForAdminDataGridView";
            this.donorListForAdminDataGridView.ReadOnly = true;
            this.donorListForAdminDataGridView.RowHeadersWidth = 51;
            this.donorListForAdminDataGridView.Size = new System.Drawing.Size(1242, 600);
            this.donorListForAdminDataGridView.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1802, 924);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(90, 33);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // DonorListForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.donorListForAdminDataGridView);
            this.Controls.Add(this.homeButton);
            this.Name = "DonorListForAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management System - Donor List (Read-Only)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DonorListForAdmin_FormClosing);
            this.Load += new System.EventHandler(this.DonorListForAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donorListForAdminDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.DataGridView donorListForAdminDataGridView;
        private System.Windows.Forms.Button logoutButton;
    }
}