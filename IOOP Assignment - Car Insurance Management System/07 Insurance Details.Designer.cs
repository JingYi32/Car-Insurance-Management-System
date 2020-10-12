namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Insurance_Details
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
            this.lblInsuranceDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVehicle_YOM = new System.Windows.Forms.Label();
            this.lblVehicle_Price = new System.Windows.Forms.Label();
            this.lblVehicle_Model = new System.Windows.Forms.Label();
            this.lblVehicle_Brand = new System.Windows.Forms.Label();
            this.lblVehicle_NO = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIns_Type = new System.Windows.Forms.Label();
            this.lblIns_Status = new System.Windows.Forms.Label();
            this.lblIns_EndDate = new System.Windows.Forms.Label();
            this.lblIns_PurcDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOwner_Gender = new System.Windows.Forms.Label();
            this.lblOwner_IDTypes = new System.Windows.Forms.Label();
            this.lblOwner_Postcode = new System.Windows.Forms.Label();
            this.lblOwner_IDNumber = new System.Windows.Forms.Label();
            this.lblOwner_DOB = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblIns_Total = new System.Windows.Forms.Label();
            this.lblIns_StampDuty = new System.Windows.Forms.Label();
            this.lblIns_SST = new System.Windows.Forms.Label();
            this.lblIns_GrossTotal = new System.Windows.Forms.Label();
            this.btnUpdate_Ins = new System.Windows.Forms.Button();
            this.btnCancel_Ins = new System.Windows.Forms.Button();
            this.btnBack_Cust_Profile = new System.Windows.Forms.Button();
            this.btnRenew_Ins = new System.Windows.Forms.Button();
            this.lblIns_Last_Renewal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInsuranceDetails
            // 
            this.lblInsuranceDetails.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblInsuranceDetails.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsuranceDetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInsuranceDetails.Location = new System.Drawing.Point(362, 28);
            this.lblInsuranceDetails.Name = "lblInsuranceDetails";
            this.lblInsuranceDetails.Size = new System.Drawing.Size(398, 76);
            this.lblInsuranceDetails.TabIndex = 4;
            this.lblInsuranceDetails.Text = "(Insurance ID) \'s Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVehicle_YOM);
            this.groupBox1.Controls.Add(this.lblVehicle_Price);
            this.groupBox1.Controls.Add(this.lblVehicle_Model);
            this.groupBox1.Controls.Add(this.lblVehicle_Brand);
            this.groupBox1.Controls.Add(this.lblVehicle_NO);
            this.groupBox1.Location = new System.Drawing.Point(38, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(592, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Details";
            // 
            // lblVehicle_YOM
            // 
            this.lblVehicle_YOM.AutoSize = true;
            this.lblVehicle_YOM.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle_YOM.Location = new System.Drawing.Point(12, 144);
            this.lblVehicle_YOM.Name = "lblVehicle_YOM";
            this.lblVehicle_YOM.Size = new System.Drawing.Size(141, 35);
            this.lblVehicle_YOM.TabIndex = 4;
            this.lblVehicle_YOM.Text = "Manufacture Year:";
            // 
            // lblVehicle_Price
            // 
            this.lblVehicle_Price.AutoSize = true;
            this.lblVehicle_Price.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle_Price.Location = new System.Drawing.Point(12, 180);
            this.lblVehicle_Price.Name = "lblVehicle_Price";
            this.lblVehicle_Price.Size = new System.Drawing.Size(107, 35);
            this.lblVehicle_Price.TabIndex = 3;
            this.lblVehicle_Price.Text = "Market Price:";
            // 
            // lblVehicle_Model
            // 
            this.lblVehicle_Model.AutoSize = true;
            this.lblVehicle_Model.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle_Model.Location = new System.Drawing.Point(12, 108);
            this.lblVehicle_Model.Name = "lblVehicle_Model";
            this.lblVehicle_Model.Size = new System.Drawing.Size(61, 35);
            this.lblVehicle_Model.TabIndex = 2;
            this.lblVehicle_Model.Text = "Model:";
            // 
            // lblVehicle_Brand
            // 
            this.lblVehicle_Brand.AutoSize = true;
            this.lblVehicle_Brand.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle_Brand.Location = new System.Drawing.Point(12, 72);
            this.lblVehicle_Brand.Name = "lblVehicle_Brand";
            this.lblVehicle_Brand.Size = new System.Drawing.Size(61, 35);
            this.lblVehicle_Brand.TabIndex = 1;
            this.lblVehicle_Brand.Text = "Brand:";
            // 
            // lblVehicle_NO
            // 
            this.lblVehicle_NO.AutoSize = true;
            this.lblVehicle_NO.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicle_NO.Location = new System.Drawing.Point(12, 36);
            this.lblVehicle_NO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicle_NO.Name = "lblVehicle_NO";
            this.lblVehicle_NO.Size = new System.Drawing.Size(217, 35);
            this.lblVehicle_NO.TabIndex = 0;
            this.lblVehicle_NO.Text = "Vehicle Registration Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIns_Last_Renewal);
            this.groupBox2.Controls.Add(this.lblIns_Type);
            this.groupBox2.Controls.Add(this.lblIns_Status);
            this.groupBox2.Controls.Add(this.lblIns_EndDate);
            this.groupBox2.Controls.Add(this.lblIns_PurcDate);
            this.groupBox2.Location = new System.Drawing.Point(657, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(396, 204);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lblIns_Type
            // 
            this.lblIns_Type.AutoSize = true;
            this.lblIns_Type.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIns_Type.Location = new System.Drawing.Point(21, 166);
            this.lblIns_Type.Name = "lblIns_Type";
            this.lblIns_Type.Size = new System.Drawing.Size(49, 35);
            this.lblIns_Type.TabIndex = 8;
            this.lblIns_Type.Text = "Type:";
            // 
            // lblIns_Status
            // 
            this.lblIns_Status.AutoSize = true;
            this.lblIns_Status.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIns_Status.Location = new System.Drawing.Point(21, 26);
            this.lblIns_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_Status.Name = "lblIns_Status";
            this.lblIns_Status.Size = new System.Drawing.Size(63, 35);
            this.lblIns_Status.TabIndex = 5;
            this.lblIns_Status.Text = "Status:";
            // 
            // lblIns_EndDate
            // 
            this.lblIns_EndDate.AutoSize = true;
            this.lblIns_EndDate.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIns_EndDate.Location = new System.Drawing.Point(21, 131);
            this.lblIns_EndDate.Name = "lblIns_EndDate";
            this.lblIns_EndDate.Size = new System.Drawing.Size(82, 35);
            this.lblIns_EndDate.TabIndex = 7;
            this.lblIns_EndDate.Text = "End Date:";
            // 
            // lblIns_PurcDate
            // 
            this.lblIns_PurcDate.AutoSize = true;
            this.lblIns_PurcDate.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIns_PurcDate.Location = new System.Drawing.Point(21, 61);
            this.lblIns_PurcDate.Name = "lblIns_PurcDate";
            this.lblIns_PurcDate.Size = new System.Drawing.Size(127, 35);
            this.lblIns_PurcDate.TabIndex = 6;
            this.lblIns_PurcDate.Text = "Purchased Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblOwner_Gender);
            this.groupBox3.Controls.Add(this.lblOwner_IDTypes);
            this.groupBox3.Controls.Add(this.lblOwner_Postcode);
            this.groupBox3.Controls.Add(this.lblOwner_IDNumber);
            this.groupBox3.Controls.Add(this.lblOwner_DOB);
            this.groupBox3.Location = new System.Drawing.Point(96, 392);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(277, 229);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Owner Details";
            // 
            // lblOwner_Gender
            // 
            this.lblOwner_Gender.AutoSize = true;
            this.lblOwner_Gender.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOwner_Gender.Location = new System.Drawing.Point(20, 150);
            this.lblOwner_Gender.Name = "lblOwner_Gender";
            this.lblOwner_Gender.Size = new System.Drawing.Size(69, 35);
            this.lblOwner_Gender.TabIndex = 9;
            this.lblOwner_Gender.Text = "Gender:";
            // 
            // lblOwner_IDTypes
            // 
            this.lblOwner_IDTypes.AutoSize = true;
            this.lblOwner_IDTypes.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOwner_IDTypes.Location = new System.Drawing.Point(20, 45);
            this.lblOwner_IDTypes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOwner_IDTypes.Name = "lblOwner_IDTypes";
            this.lblOwner_IDTypes.Size = new System.Drawing.Size(69, 35);
            this.lblOwner_IDTypes.TabIndex = 5;
            this.lblOwner_IDTypes.Text = "ID Type:";
            // 
            // lblOwner_Postcode
            // 
            this.lblOwner_Postcode.AutoSize = true;
            this.lblOwner_Postcode.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOwner_Postcode.Location = new System.Drawing.Point(20, 185);
            this.lblOwner_Postcode.Name = "lblOwner_Postcode";
            this.lblOwner_Postcode.Size = new System.Drawing.Size(79, 35);
            this.lblOwner_Postcode.TabIndex = 8;
            this.lblOwner_Postcode.Text = "Postcode:";
            // 
            // lblOwner_IDNumber
            // 
            this.lblOwner_IDNumber.AutoSize = true;
            this.lblOwner_IDNumber.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOwner_IDNumber.Location = new System.Drawing.Point(20, 80);
            this.lblOwner_IDNumber.Name = "lblOwner_IDNumber";
            this.lblOwner_IDNumber.Size = new System.Drawing.Size(95, 35);
            this.lblOwner_IDNumber.TabIndex = 6;
            this.lblOwner_IDNumber.Text = "ID Number:";
            // 
            // lblOwner_DOB
            // 
            this.lblOwner_DOB.AutoSize = true;
            this.lblOwner_DOB.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOwner_DOB.Location = new System.Drawing.Point(20, 115);
            this.lblOwner_DOB.Name = "lblOwner_DOB";
            this.lblOwner_DOB.Size = new System.Drawing.Size(60, 35);
            this.lblOwner_DOB.TabIndex = 7;
            this.lblOwner_DOB.Text = "D.O.B.:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblIns_Total);
            this.groupBox4.Controls.Add(this.lblIns_StampDuty);
            this.groupBox4.Controls.Add(this.lblIns_SST);
            this.groupBox4.Controls.Add(this.lblIns_GrossTotal);
            this.groupBox4.Font = new System.Drawing.Font("Gabriola", 10.8F);
            this.groupBox4.Location = new System.Drawing.Point(509, 392);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(486, 229);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // lblIns_Total
            // 
            this.lblIns_Total.AutoSize = true;
            this.lblIns_Total.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIns_Total.Location = new System.Drawing.Point(18, 177);
            this.lblIns_Total.Name = "lblIns_Total";
            this.lblIns_Total.Size = new System.Drawing.Size(175, 35);
            this.lblIns_Total.TabIndex = 8;
            this.lblIns_Total.Text = "Total Annual Premium:";
            // 
            // lblIns_StampDuty
            // 
            this.lblIns_StampDuty.AutoSize = true;
            this.lblIns_StampDuty.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_StampDuty.Location = new System.Drawing.Point(18, 105);
            this.lblIns_StampDuty.Name = "lblIns_StampDuty";
            this.lblIns_StampDuty.Size = new System.Drawing.Size(89, 35);
            this.lblIns_StampDuty.TabIndex = 7;
            this.lblIns_StampDuty.Text = "Stamp Duty:";
            // 
            // lblIns_SST
            // 
            this.lblIns_SST.AutoSize = true;
            this.lblIns_SST.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_SST.Location = new System.Drawing.Point(18, 69);
            this.lblIns_SST.Name = "lblIns_SST";
            this.lblIns_SST.Size = new System.Drawing.Size(142, 35);
            this.lblIns_SST.TabIndex = 6;
            this.lblIns_SST.Text = "Sales and Service Tax:";
            // 
            // lblIns_GrossTotal
            // 
            this.lblIns_GrossTotal.AutoSize = true;
            this.lblIns_GrossTotal.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_GrossTotal.Location = new System.Drawing.Point(18, 33);
            this.lblIns_GrossTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_GrossTotal.Name = "lblIns_GrossTotal";
            this.lblIns_GrossTotal.Size = new System.Drawing.Size(207, 35);
            this.lblIns_GrossTotal.TabIndex = 5;
            this.lblIns_GrossTotal.Text = "Insurance Premium Gross Total:";
            // 
            // btnUpdate_Ins
            // 
            this.btnUpdate_Ins.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate_Ins.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Ins.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Ins.Location = new System.Drawing.Point(884, 650);
            this.btnUpdate_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate_Ins.Name = "btnUpdate_Ins";
            this.btnUpdate_Ins.Size = new System.Drawing.Size(169, 54);
            this.btnUpdate_Ins.TabIndex = 16;
            this.btnUpdate_Ins.Text = "Update Policy";
            this.btnUpdate_Ins.UseVisualStyleBackColor = false;
            // 
            // btnCancel_Ins
            // 
            this.btnCancel_Ins.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCancel_Ins.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Ins.ForeColor = System.Drawing.Color.White;
            this.btnCancel_Ins.Location = new System.Drawing.Point(602, 650);
            this.btnCancel_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel_Ins.Name = "btnCancel_Ins";
            this.btnCancel_Ins.Size = new System.Drawing.Size(169, 54);
            this.btnCancel_Ins.TabIndex = 15;
            this.btnCancel_Ins.Text = "Cancel Policy";
            this.btnCancel_Ins.UseVisualStyleBackColor = false;
            // 
            // btnBack_Cust_Profile
            // 
            this.btnBack_Cust_Profile.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack_Cust_Profile.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_Cust_Profile.ForeColor = System.Drawing.Color.White;
            this.btnBack_Cust_Profile.Location = new System.Drawing.Point(38, 650);
            this.btnBack_Cust_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack_Cust_Profile.Name = "btnBack_Cust_Profile";
            this.btnBack_Cust_Profile.Size = new System.Drawing.Size(169, 54);
            this.btnBack_Cust_Profile.TabIndex = 14;
            this.btnBack_Cust_Profile.Text = "Back";
            this.btnBack_Cust_Profile.UseVisualStyleBackColor = false;
            // 
            // btnRenew_Ins
            // 
            this.btnRenew_Ins.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRenew_Ins.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew_Ins.ForeColor = System.Drawing.Color.White;
            this.btnRenew_Ins.Location = new System.Drawing.Point(320, 650);
            this.btnRenew_Ins.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenew_Ins.Name = "btnRenew_Ins";
            this.btnRenew_Ins.Size = new System.Drawing.Size(169, 54);
            this.btnRenew_Ins.TabIndex = 17;
            this.btnRenew_Ins.Text = "Renew Policy";
            this.btnRenew_Ins.UseVisualStyleBackColor = false;
            // 
            // lblIns_Last_Renewal
            // 
            this.lblIns_Last_Renewal.AutoSize = true;
            this.lblIns_Last_Renewal.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblIns_Last_Renewal.Location = new System.Drawing.Point(21, 96);
            this.lblIns_Last_Renewal.Name = "lblIns_Last_Renewal";
            this.lblIns_Last_Renewal.Size = new System.Drawing.Size(145, 35);
            this.lblIns_Last_Renewal.TabIndex = 9;
            this.lblIns_Last_Renewal.Text = "Last Renewal Date:";
            // 
            // Insurance_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.btnRenew_Ins);
            this.Controls.Add(this.btnUpdate_Ins);
            this.Controls.Add(this.btnCancel_Ins);
            this.Controls.Add(this.btnBack_Cust_Profile);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblInsuranceDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Insurance_Details";
            this.Text = "Insurance_Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInsuranceDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVehicle_NO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblVehicle_YOM;
        private System.Windows.Forms.Label lblVehicle_Price;
        private System.Windows.Forms.Label lblVehicle_Model;
        private System.Windows.Forms.Label lblVehicle_Brand;
        private System.Windows.Forms.Label lblIns_Type;
        private System.Windows.Forms.Label lblIns_Status;
        private System.Windows.Forms.Label lblIns_EndDate;
        private System.Windows.Forms.Label lblIns_PurcDate;
        private System.Windows.Forms.Label lblOwner_Gender;
        private System.Windows.Forms.Label lblOwner_IDTypes;
        private System.Windows.Forms.Label lblOwner_Postcode;
        private System.Windows.Forms.Label lblOwner_IDNumber;
        private System.Windows.Forms.Label lblOwner_DOB;
        private System.Windows.Forms.Label lblIns_Total;
        private System.Windows.Forms.Label lblIns_StampDuty;
        private System.Windows.Forms.Label lblIns_SST;
        private System.Windows.Forms.Label lblIns_GrossTotal;
        private System.Windows.Forms.Button btnUpdate_Ins;
        private System.Windows.Forms.Button btnCancel_Ins;
        private System.Windows.Forms.Button btnBack_Cust_Profile;
        private System.Windows.Forms.Button btnRenew_Ins;
        private System.Windows.Forms.Label lblIns_Last_Renewal;
    }
}