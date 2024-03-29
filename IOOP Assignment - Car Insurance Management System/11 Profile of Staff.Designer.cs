﻿namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Profile_of_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_of_Staff));
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.picProfilePicture_MP = new System.Windows.Forms.PictureBox();
            this.btnBack_MP = new System.Windows.Forms.Button();
            this.dgvMP = new System.Windows.Forms.DataGridView();
            this.showStaID = new System.Windows.Forms.Label();
            this.showStaName = new System.Windows.Forms.Label();
            this.showStaGender = new System.Windows.Forms.Label();
            this.showStaPosition = new System.Windows.Forms.Label();
            this.showStaContact = new System.Windows.Forms.Label();
            this.showStaAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture_MP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblMyProfile.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProfile.Location = new System.Drawing.Point(362, 20);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(398, 70);
            this.lblMyProfile.TabIndex = 0;
            this.lblMyProfile.Text = "My Profile";
            this.lblMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(56, 96);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(100, 51);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(56, 147);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(133, 51);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "First Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(56, 198);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(98, 51);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            this.lblGender.Click += new System.EventHandler(this.lblGender_MP_Click);
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobPosition.Location = new System.Drawing.Point(56, 247);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(139, 51);
            this.lblJobPosition.TabIndex = 4;
            this.lblJobPosition.Text = "Job Position:";
            this.lblJobPosition.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(56, 297);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(188, 51);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(56, 348);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(106, 51);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // picProfilePicture_MP
            // 
            this.picProfilePicture_MP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProfilePicture_MP.Image = ((System.Drawing.Image)(resources.GetObject("picProfilePicture_MP.Image")));
            this.picProfilePicture_MP.Location = new System.Drawing.Point(718, 135);
            this.picProfilePicture_MP.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.picProfilePicture_MP.Name = "picProfilePicture_MP";
            this.picProfilePicture_MP.Size = new System.Drawing.Size(321, 214);
            this.picProfilePicture_MP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfilePicture_MP.TabIndex = 7;
            this.picProfilePicture_MP.TabStop = false;
            // 
            // btnBack_MP
            // 
            this.btnBack_MP.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack_MP.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack_MP.Location = new System.Drawing.Point(817, 649);
            this.btnBack_MP.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.btnBack_MP.Name = "btnBack_MP";
            this.btnBack_MP.Size = new System.Drawing.Size(203, 49);
            this.btnBack_MP.TabIndex = 9;
            this.btnBack_MP.Text = "Back";
            this.btnBack_MP.UseVisualStyleBackColor = false;
            this.btnBack_MP.Click += new System.EventHandler(this.btnBack_MP_Click);
            // 
            // dgvMP
            // 
            this.dgvMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMP.Location = new System.Drawing.Point(26, 435);
            this.dgvMP.Name = "dgvMP";
            this.dgvMP.RowHeadersWidth = 51;
            this.dgvMP.RowTemplate.Height = 24;
            this.dgvMP.Size = new System.Drawing.Size(762, 291);
            this.dgvMP.TabIndex = 10;
            // 
            // showStaID
            // 
            this.showStaID.AutoSize = true;
            this.showStaID.Location = new System.Drawing.Point(162, 101);
            this.showStaID.Name = "showStaID";
            this.showStaID.Size = new System.Drawing.Size(118, 45);
            this.showStaID.TabIndex = 11;
            this.showStaID.Text = "Show Staff ID";
            // 
            // showStaName
            // 
            this.showStaName.AutoSize = true;
            this.showStaName.Location = new System.Drawing.Point(195, 152);
            this.showStaName.Name = "showStaName";
            this.showStaName.Size = new System.Drawing.Size(145, 45);
            this.showStaName.TabIndex = 12;
            this.showStaName.Text = "Show First Name";
            // 
            // showStaGender
            // 
            this.showStaGender.AutoSize = true;
            this.showStaGender.Location = new System.Drawing.Point(160, 204);
            this.showStaGender.Name = "showStaGender";
            this.showStaGender.Size = new System.Drawing.Size(116, 45);
            this.showStaGender.TabIndex = 13;
            this.showStaGender.Text = "Show Gender";
            // 
            // showStaPosition
            // 
            this.showStaPosition.AutoSize = true;
            this.showStaPosition.Location = new System.Drawing.Point(195, 252);
            this.showStaPosition.Name = "showStaPosition";
            this.showStaPosition.Size = new System.Drawing.Size(151, 45);
            this.showStaPosition.TabIndex = 14;
            this.showStaPosition.Text = "Show Job Position";
            // 
            // showStaContact
            // 
            this.showStaContact.AutoSize = true;
            this.showStaContact.Location = new System.Drawing.Point(250, 297);
            this.showStaContact.Name = "showStaContact";
            this.showStaContact.Size = new System.Drawing.Size(188, 45);
            this.showStaContact.TabIndex = 15;
            this.showStaContact.Text = "Show Contact Number";
            // 
            // showStaAddress
            // 
            this.showStaAddress.AutoSize = true;
            this.showStaAddress.Location = new System.Drawing.Point(168, 348);
            this.showStaAddress.Name = "showStaAddress";
            this.showStaAddress.Size = new System.Drawing.Size(123, 45);
            this.showStaAddress.TabIndex = 16;
            this.showStaAddress.Text = "Show Address";
            // 
            // Profile_of_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.showStaAddress);
            this.Controls.Add(this.showStaContact);
            this.Controls.Add(this.showStaPosition);
            this.Controls.Add(this.showStaGender);
            this.Controls.Add(this.showStaName);
            this.Controls.Add(this.showStaID);
            this.Controls.Add(this.dgvMP);
            this.Controls.Add(this.btnBack_MP);
            this.Controls.Add(this.picProfilePicture_MP);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblJobPosition);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblMyProfile);
            this.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "Profile_of_Staff";
            this.Text = "Profile_of_Staff";
            this.Load += new System.EventHandler(this.Profile_of_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture_MP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox picProfilePicture_MP;
        private System.Windows.Forms.Button btnBack_MP;
        private System.Windows.Forms.DataGridView dgvMP;
        private System.Windows.Forms.Label showStaID;
        private System.Windows.Forms.Label showStaName;
        private System.Windows.Forms.Label showStaGender;
        private System.Windows.Forms.Label showStaPosition;
        private System.Windows.Forms.Label showStaContact;
        private System.Windows.Forms.Label showStaAddress;
    }
}