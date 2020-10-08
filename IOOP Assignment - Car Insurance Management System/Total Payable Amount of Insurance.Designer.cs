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
            this.lblCustomerID_TA = new System.Windows.Forms.Label();
            this.lblCustomerName_TA = new System.Windows.Forms.Label();
            this.ButtonSave_TA = new System.Windows.Forms.Button();
            this.btnBack_TA = new System.Windows.Forms.Button();
            this.tlpTotal_TA = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalAmount.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(309, 20);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(141, 51);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblCustomerID_TA
            // 
            this.lblCustomerID_TA.AutoSize = true;
            this.lblCustomerID_TA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCustomerID_TA.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID_TA.Location = new System.Drawing.Point(48, 104);
            this.lblCustomerID_TA.Name = "lblCustomerID_TA";
            this.lblCustomerID_TA.Size = new System.Drawing.Size(98, 37);
            this.lblCustomerID_TA.TabIndex = 1;
            this.lblCustomerID_TA.Text = "Customer ID:";
            // 
            // lblCustomerName_TA
            // 
            this.lblCustomerName_TA.AutoSize = true;
            this.lblCustomerName_TA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCustomerName_TA.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName_TA.Location = new System.Drawing.Point(434, 104);
            this.lblCustomerName_TA.Name = "lblCustomerName_TA";
            this.lblCustomerName_TA.Size = new System.Drawing.Size(119, 37);
            this.lblCustomerName_TA.TabIndex = 2;
            this.lblCustomerName_TA.Text = "Customer Name:";
            // 
            // ButtonSave_TA
            // 
            this.ButtonSave_TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave_TA.Location = new System.Drawing.Point(665, 368);
            this.ButtonSave_TA.Name = "ButtonSave_TA";
            this.ButtonSave_TA.Size = new System.Drawing.Size(75, 33);
            this.ButtonSave_TA.TabIndex = 3;
            this.ButtonSave_TA.Text = "Save";
            this.ButtonSave_TA.UseVisualStyleBackColor = true;
            this.ButtonSave_TA.Click += new System.EventHandler(this.ButtonSave_TA_Click);
            // 
            // btnBack_TA
            // 
            this.btnBack_TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack_TA.Location = new System.Drawing.Point(554, 367);
            this.btnBack_TA.Name = "btnBack_TA";
            this.btnBack_TA.Size = new System.Drawing.Size(75, 34);
            this.btnBack_TA.TabIndex = 4;
            this.btnBack_TA.Text = "Back";
            this.btnBack_TA.UseVisualStyleBackColor = true;
            // 
            // tlpTotal_TA
            // 
            this.tlpTotal_TA.ColumnCount = 2;
            this.tlpTotal_TA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal_TA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal_TA.Location = new System.Drawing.Point(111, 169);
            this.tlpTotal_TA.Name = "tlpTotal_TA";
            this.tlpTotal_TA.RowCount = 5;
            this.tlpTotal_TA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal_TA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal_TA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpTotal_TA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpTotal_TA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpTotal_TA.Size = new System.Drawing.Size(418, 205);
            this.tlpTotal_TA.TabIndex = 5;
            // 
            // Total_Payable_Amount_of_Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpTotal_TA);
            this.Controls.Add(this.btnBack_TA);
            this.Controls.Add(this.ButtonSave_TA);
            this.Controls.Add(this.lblCustomerName_TA);
            this.Controls.Add(this.lblCustomerID_TA);
            this.Controls.Add(this.lblTotalAmount);
            this.Name = "Total_Payable_Amount_of_Insurance";
            this.Text = "Total_Payable_Amount_of_Insurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblCustomerID_TA;
        private System.Windows.Forms.Label lblCustomerName_TA;
        private System.Windows.Forms.Button ButtonSave_TA;
        private System.Windows.Forms.Button btnBack_TA;
        private System.Windows.Forms.TableLayoutPanel tlpTotal_TA;
    }
}