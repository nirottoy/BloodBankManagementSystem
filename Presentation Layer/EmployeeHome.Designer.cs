
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class EmployeeHome
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
            this.manageDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faqBloodDonationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faqWebBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDonorToolStripMenuItem,
            this.SearchDonorToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // manageDonorToolStripMenuItem
            // 
            this.manageDonorToolStripMenuItem.Name = "manageDonorToolStripMenuItem";
            this.manageDonorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageDonorToolStripMenuItem.Text = "Manage Donor";
            this.manageDonorToolStripMenuItem.Click += new System.EventHandler(this.ManageDonorToolStripMenuItem_Click);
            // 
            // SearchDonorToolStripMenuItem
            // 
            this.SearchDonorToolStripMenuItem.Name = "SearchDonorToolStripMenuItem";
            this.SearchDonorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SearchDonorToolStripMenuItem.Text = "Search Donor";
            this.SearchDonorToolStripMenuItem.Click += new System.EventHandler(this.SearchDonorToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faqBloodDonationToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // faqBloodDonationToolStripMenuItem
            // 
            this.faqBloodDonationToolStripMenuItem.Name = "faqBloodDonationToolStripMenuItem";
            this.faqBloodDonationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.faqBloodDonationToolStripMenuItem.Text = "Blood Donate FAQ";
            this.faqBloodDonationToolStripMenuItem.Click += new System.EventHandler(this.FaqBloodDonationToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.AboutUsToolStripMenuItem_Click);
            // 
            // faqWebBrowser
            // 
            this.faqWebBrowser.Location = new System.Drawing.Point(12, 47);
            this.faqWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.faqWebBrowser.Name = "faqWebBrowser";
            this.faqWebBrowser.ScriptErrorsSuppressed = true;
            this.faqWebBrowser.Size = new System.Drawing.Size(800, 405);
            this.faqWebBrowser.TabIndex = 2;
            this.faqWebBrowser.Url = new System.Uri("https://sites.google.com/view/projectbbms/home", System.UriKind.Absolute);
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 464);
            this.Controls.Add(this.faqWebBrowser);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EmployeeHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeHome_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.WebBrowser faqWebBrowser;
        private System.Windows.Forms.ToolStripMenuItem faqBloodDonationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}