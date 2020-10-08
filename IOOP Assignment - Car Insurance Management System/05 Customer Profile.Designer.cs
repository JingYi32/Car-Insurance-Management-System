namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Customer_Profile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerIDN = new System.Windows.Forms.Label();
            this.lblCustomerGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.tlpHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblBil = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.lblEnddate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.tlpHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblProfile.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProfile.Location = new System.Drawing.Point(951, 19);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(476, 76);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Mr./Mrs.____\'s Profile";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(41, 112);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(148, 55);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(39, 169);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(193, 55);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer\'s Name:";
            // 
            // lblCustomerIDN
            // 
            this.lblCustomerIDN.AutoSize = true;
            this.lblCustomerIDN.Location = new System.Drawing.Point(39, 226);
            this.lblCustomerIDN.Name = "lblCustomerIDN";
            this.lblCustomerIDN.Size = new System.Drawing.Size(134, 55);
            this.lblCustomerIDN.TabIndex = 4;
            this.lblCustomerIDN.Text = "ID Number:";
            // 
            // lblCustomerGender
            // 
            this.lblCustomerGender.AutoSize = true;
            this.lblCustomerGender.Location = new System.Drawing.Point(38, 283);
            this.lblCustomerGender.Name = "lblCustomerGender";
            this.lblCustomerGender.Size = new System.Drawing.Size(97, 55);
            this.lblCustomerGender.TabIndex = 5;
            this.lblCustomerGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 454);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(166, 55);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(38, 340);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(106, 55);
            this.lblCustomerAddress.TabIndex = 7;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(39, 397);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(184, 55);
            this.lblCustomerPhone.TabIndex = 8;
            this.lblCustomerPhone.Text = "Contact Number:";
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(39, 511);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(186, 55);
            this.lblHistory.TabIndex = 9;
            this.lblHistory.Text = "Purchase History:";
            // 
            // tlpHistory
            // 
            this.tlpHistory.BackColor = System.Drawing.Color.CadetBlue;
            this.tlpHistory.ColumnCount = 5;
            this.tlpHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75F));
            this.tlpHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75F));
            this.tlpHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75F));
            this.tlpHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75F));
            this.tlpHistory.Controls.Add(this.lblEnddate, 4, 0);
            this.tlpHistory.Controls.Add(this.lblStartdate, 3, 0);
            this.tlpHistory.Controls.Add(this.lblStatus, 2, 0);
            this.tlpHistory.Controls.Add(this.lblInsuranceID, 1, 0);
            this.tlpHistory.Controls.Add(this.lblBil, 0, 0);
            this.tlpHistory.Location = new System.Drawing.Point(48, 570);
            this.tlpHistory.Name = "tlpHistory";
            this.tlpHistory.RowCount = 8;
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpHistory.Size = new System.Drawing.Size(1379, 379);
            this.tlpHistory.TabIndex = 10;
            this.tlpHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpHistory_Paint);
            // 
            // lblBil
            // 
            this.lblBil.BackColor = System.Drawing.Color.Transparent;
            this.lblBil.ForeColor = System.Drawing.Color.Azure;
            this.lblBil.Location = new System.Drawing.Point(3, 0);
            this.lblBil.Name = "lblBil";
            this.lblBil.Size = new System.Drawing.Size(62, 47);
            this.lblBil.TabIndex = 0;
            this.lblBil.Text = "Bil";
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.BackColor = System.Drawing.Color.Transparent;
            this.lblInsuranceID.ForeColor = System.Drawing.Color.Azure;
            this.lblInsuranceID.Location = new System.Drawing.Point(71, 0);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(321, 47);
            this.lblInsuranceID.TabIndex = 1;
            this.lblInsuranceID.Text = "Insurance ID";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Azure;
            this.lblStatus.Location = new System.Drawing.Point(398, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(321, 47);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblStartdate
            // 
            this.lblStartdate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartdate.ForeColor = System.Drawing.Color.Azure;
            this.lblStartdate.Location = new System.Drawing.Point(725, 0);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(321, 47);
            this.lblStartdate.TabIndex = 3;
            this.lblStartdate.Text = "Start-date";
            // 
            // lblEnddate
            // 
            this.lblEnddate.BackColor = System.Drawing.Color.Transparent;
            this.lblEnddate.ForeColor = System.Drawing.Color.Azure;
            this.lblEnddate.Location = new System.Drawing.Point(1052, 0);
            this.lblEnddate.Name = "lblEnddate";
            this.lblEnddate.Size = new System.Drawing.Size(324, 47);
            this.lblEnddate.TabIndex = 4;
            this.lblEnddate.Text = "End-date";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(48, 994);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 49);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(935, 994);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(203, 49);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(1224, 994);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(203, 49);
            this.btnPurchase.TabIndex = 13;
            this.btnPurchase.Text = "Purchase New Insurance";
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // Customer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tlpHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCustomerGender);
            this.Controls.Add(this.lblCustomerIDN);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblProfile);
            this.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.Name = "Customer_Profile";
            this.Text = "Customer_Profile";
            this.tlpHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerIDN;
        private System.Windows.Forms.Label lblCustomerGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.TableLayoutPanel tlpHistory;
        private System.Windows.Forms.Label lblEnddate;
        private System.Windows.Forms.Label lblStartdate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInsuranceID;
        private System.Windows.Forms.Label lblBil;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPurchase;
    }
}