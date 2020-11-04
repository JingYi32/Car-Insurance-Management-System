namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Total_Payable_Amount_of_Insurance
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
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpTotalAmount = new System.Windows.Forms.TableLayoutPanel();
            this.lblRM10 = new System.Windows.Forms.Label();
            this.lblIns_GrossTotal = new System.Windows.Forms.Label();
            this.lblIns_NCD = new System.Windows.Forms.Label();
            this.lblIns_StampDuty = new System.Windows.Forms.Label();
            this.lblIns_SST = new System.Windows.Forms.Label();
            this.lblSSTCount = new System.Windows.Forms.Label();
            this.lblRMtotal = new System.Windows.Forms.Label();
            this.lblIns_Total = new System.Windows.Forms.Label();
            this.lblRMInsuranceTotal = new System.Windows.Forms.Label();
            this.lblRM_NCD = new System.Windows.Forms.Label();
            this.tlpTotalAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalAmount.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalAmount.Location = new System.Drawing.Point(362, 28);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(398, 76);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCustomerID.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCustomerID.Location = new System.Drawing.Point(98, 145);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(350, 51);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCustomerName.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCustomerName.Location = new System.Drawing.Point(670, 145);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(350, 51);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Insurance ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBack.Location = new System.Drawing.Point(98, 649);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_TA_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSave.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(817, 649);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_TA_Click);
            // 
            // tlpTotalAmount
            // 
            this.tlpTotalAmount.ColumnCount = 2;
            this.tlpTotalAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotalAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotalAmount.Controls.Add(this.lblRM10, 1, 2);
            this.tlpTotalAmount.Controls.Add(this.lblIns_GrossTotal, 0, 0);
            this.tlpTotalAmount.Controls.Add(this.lblIns_NCD, 0, 3);
            this.tlpTotalAmount.Controls.Add(this.lblIns_StampDuty, 0, 2);
            this.tlpTotalAmount.Controls.Add(this.lblIns_SST, 0, 1);
            this.tlpTotalAmount.Controls.Add(this.lblSSTCount, 1, 1);
            this.tlpTotalAmount.Controls.Add(this.lblRMtotal, 1, 4);
            this.tlpTotalAmount.Controls.Add(this.lblIns_Total, 0, 4);
            this.tlpTotalAmount.Controls.Add(this.lblRMInsuranceTotal, 1, 0);
            this.tlpTotalAmount.Controls.Add(this.lblRM_NCD, 1, 3);
            this.tlpTotalAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tlpTotalAmount.Location = new System.Drawing.Point(186, 237);
            this.tlpTotalAmount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tlpTotalAmount.Name = "tlpTotalAmount";
            this.tlpTotalAmount.RowCount = 5;
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTotalAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTotalAmount.Size = new System.Drawing.Size(745, 329);
            this.tlpTotalAmount.TabIndex = 5;
            // 
            // lblRM10
            // 
            this.lblRM10.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRM10.Location = new System.Drawing.Point(374, 130);
            this.lblRM10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRM10.Name = "lblRM10";
            this.lblRM10.Size = new System.Drawing.Size(369, 65);
            this.lblRM10.TabIndex = 6;
            this.lblRM10.Text = "RM 10.00";
            this.lblRM10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIns_GrossTotal
            // 
            this.lblIns_GrossTotal.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_GrossTotal.Location = new System.Drawing.Point(2, 0);
            this.lblIns_GrossTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_GrossTotal.Name = "lblIns_GrossTotal";
            this.lblIns_GrossTotal.Size = new System.Drawing.Size(368, 65);
            this.lblIns_GrossTotal.TabIndex = 0;
            this.lblIns_GrossTotal.Text = "Insurance Premium Gross Total:";
            this.lblIns_GrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIns_NCD
            // 
            this.lblIns_NCD.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_NCD.Location = new System.Drawing.Point(2, 195);
            this.lblIns_NCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_NCD.Name = "lblIns_NCD";
            this.lblIns_NCD.Size = new System.Drawing.Size(368, 65);
            this.lblIns_NCD.TabIndex = 8;
            this.lblIns_NCD.Text = "No-Claim Discount (NCD):";
            this.lblIns_NCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIns_StampDuty
            // 
            this.lblIns_StampDuty.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_StampDuty.Location = new System.Drawing.Point(2, 130);
            this.lblIns_StampDuty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_StampDuty.Name = "lblIns_StampDuty";
            this.lblIns_StampDuty.Size = new System.Drawing.Size(368, 65);
            this.lblIns_StampDuty.TabIndex = 7;
            this.lblIns_StampDuty.Text = "Stamp Duty:";
            this.lblIns_StampDuty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIns_SST
            // 
            this.lblIns_SST.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_SST.Location = new System.Drawing.Point(2, 65);
            this.lblIns_SST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_SST.Name = "lblIns_SST";
            this.lblIns_SST.Size = new System.Drawing.Size(368, 65);
            this.lblIns_SST.TabIndex = 6;
            this.lblIns_SST.Text = "SST (6%):";
            this.lblIns_SST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSSTCount
            // 
            this.lblSSTCount.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSTCount.Location = new System.Drawing.Point(374, 65);
            this.lblSSTCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSTCount.Name = "lblSSTCount";
            this.lblSSTCount.Size = new System.Drawing.Size(369, 65);
            this.lblSSTCount.TabIndex = 10;
            this.lblSSTCount.Text = "RM 00.00";
            this.lblSSTCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRMtotal
            // 
            this.lblRMtotal.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMtotal.Location = new System.Drawing.Point(374, 260);
            this.lblRMtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRMtotal.Name = "lblRMtotal";
            this.lblRMtotal.Size = new System.Drawing.Size(369, 69);
            this.lblRMtotal.TabIndex = 13;
            this.lblRMtotal.Text = "RM 00.00";
            this.lblRMtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIns_Total
            // 
            this.lblIns_Total.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns_Total.Location = new System.Drawing.Point(2, 260);
            this.lblIns_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIns_Total.Name = "lblIns_Total";
            this.lblIns_Total.Size = new System.Drawing.Size(368, 69);
            this.lblIns_Total.TabIndex = 9;
            this.lblIns_Total.Text = "Total Annual Premium:";
            this.lblIns_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRMInsuranceTotal
            // 
            this.lblRMInsuranceTotal.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMInsuranceTotal.Location = new System.Drawing.Point(374, 0);
            this.lblRMInsuranceTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRMInsuranceTotal.Name = "lblRMInsuranceTotal";
            this.lblRMInsuranceTotal.Size = new System.Drawing.Size(369, 65);
            this.lblRMInsuranceTotal.TabIndex = 6;
            this.lblRMInsuranceTotal.Text = "RM 00.00";
            this.lblRMInsuranceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRM_NCD
            // 
            this.lblRM_NCD.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRM_NCD.Location = new System.Drawing.Point(374, 195);
            this.lblRM_NCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRM_NCD.Name = "lblRM_NCD";
            this.lblRM_NCD.Size = new System.Drawing.Size(369, 65);
            this.lblRM_NCD.TabIndex = 10;
            this.lblRM_NCD.Text = "RM 00.00";
            this.lblRM_NCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total_Payable_Amount_of_Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.tlpTotalAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Gabriola", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Total_Payable_Amount_of_Insurance";
            this.Text = "Total_Payable_Amount_of_Insurance";
            this.Load += new System.EventHandler(this.Total_Payable_Amount_of_Insurance_Load);
            this.tlpTotalAmount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpTotalAmount;
        private System.Windows.Forms.Label lblIns_Total;
        private System.Windows.Forms.Label lblIns_GrossTotal;
        private System.Windows.Forms.Label lblIns_NCD;
        private System.Windows.Forms.Label lblIns_StampDuty;
        private System.Windows.Forms.Label lblIns_SST;
        private System.Windows.Forms.Label lblRM10;
        private System.Windows.Forms.Label lblSSTCount;
        private System.Windows.Forms.Label lblRMtotal;
        private System.Windows.Forms.Label lblRMInsuranceTotal;
        private System.Windows.Forms.Label lblRM_NCD;
    }
}