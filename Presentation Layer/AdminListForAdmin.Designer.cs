﻿
namespace BloodBankManagementSystem.Presentation_Layer
{
    partial class AdminListForAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logoutButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAdminPasswordTextbox = new System.Windows.Forms.TextBox();
            this.addAdminUsernameTextbox = new System.Windows.Forms.TextBox();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(547, 428);
            this.dataGridView1.TabIndex = 5;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(892, 498);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(140, 41);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(927, 15);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(105, 41);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addAdminPasswordTextbox);
            this.groupBox1.Controls.Add(this.addAdminUsernameTextbox);
            this.groupBox1.Controls.Add(this.addAdminButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Admin";
            // 
            // addAdminPasswordTextbox
            // 
            this.addAdminPasswordTextbox.Location = new System.Drawing.Point(195, 100);
            this.addAdminPasswordTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addAdminPasswordTextbox.Name = "addAdminPasswordTextbox";
            this.addAdminPasswordTextbox.PasswordChar = '*';
            this.addAdminPasswordTextbox.Size = new System.Drawing.Size(257, 31);
            this.addAdminPasswordTextbox.TabIndex = 11;
            // 
            // addAdminUsernameTextbox
            // 
            this.addAdminUsernameTextbox.Location = new System.Drawing.Point(195, 48);
            this.addAdminUsernameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addAdminUsernameTextbox.Name = "addAdminUsernameTextbox";
            this.addAdminUsernameTextbox.Size = new System.Drawing.Size(257, 31);
            this.addAdminUsernameTextbox.TabIndex = 10;
            // 
            // addAdminButton
            // 
            this.addAdminButton.Location = new System.Drawing.Point(303, 158);
            this.addAdminButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(150, 39);
            this.addAdminButton.TabIndex = 9;
            this.addAdminButton.Text = "Add Admin";
            this.addAdminButton.UseVisualStyleBackColor = true;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // AdminListForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.homeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminListForAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminListForAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminListForAdmin_FormClosing);
            this.Load += new System.EventHandler(this.AdminListForAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addAdminPasswordTextbox;
        private System.Windows.Forms.TextBox addAdminUsernameTextbox;
        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}