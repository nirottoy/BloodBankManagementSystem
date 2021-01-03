
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class AdminHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodDonateFAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faqWebBrowser = new System.Windows.Forms.WebBrowser();
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeManagementToolStripMenuItem,
            this.donorsDataToolStripMenuItem,
            this.adminListToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // employeeManagementToolStripMenuItem
            // 
            this.employeeManagementToolStripMenuItem.Name = "employeeManagementToolStripMenuItem";
            this.employeeManagementToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.employeeManagementToolStripMenuItem.Text = "Employee Management";
            this.employeeManagementToolStripMenuItem.Click += new System.EventHandler(this.EmployeeManagementToolStripMenuItem_Click);
            // 
            // donorsDataToolStripMenuItem
            // 
            this.donorsDataToolStripMenuItem.Name = "donorsDataToolStripMenuItem";
            this.donorsDataToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.donorsDataToolStripMenuItem.Text = "Donor\'s Data";
            this.donorsDataToolStripMenuItem.Click += new System.EventHandler(this.DonorsDataToolStripMenuItem_Click);
            // 
            // adminListToolStripMenuItem
            // 
            this.adminListToolStripMenuItem.Name = "adminListToolStripMenuItem";
            this.adminListToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.adminListToolStripMenuItem.Text = "Admin List";
            this.adminListToolStripMenuItem.Click += new System.EventHandler(this.adminListToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloodDonateFAQToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.contactUsToolStripMenuItem.Text = "Help";
            // 
            // bloodDonateFAQToolStripMenuItem
            // 
            this.bloodDonateFAQToolStripMenuItem.Name = "bloodDonateFAQToolStripMenuItem";
            this.bloodDonateFAQToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bloodDonateFAQToolStripMenuItem.Text = "Blood Donate FAQ";
            this.bloodDonateFAQToolStripMenuItem.Click += new System.EventHandler(this.BloodDonateFAQToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.AboutUsToolStripMenuItem_Click);
            // 
            // faqWebBrowser
            // 
            this.faqWebBrowser.Location = new System.Drawing.Point(16, 81);
            this.faqWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.faqWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.faqWebBrowser.Name = "faqWebBrowser";
            this.faqWebBrowser.ScriptErrorsSuppressed = true;
            this.faqWebBrowser.Size = new System.Drawing.Size(1067, 475);
            this.faqWebBrowser.TabIndex = 1;
            this.faqWebBrowser.Url = new System.Uri("https://sites.google.com/view/projectbbms/home", System.UriKind.Absolute);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(961, 33);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(122, 41);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 571);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.faqWebBrowser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsDataToolStripMenuItem;
        private System.Windows.Forms.WebBrowser faqWebBrowser;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodDonateFAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ToolStripMenuItem adminListToolStripMenuItem;
    }
}