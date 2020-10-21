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
            this.lblCUST_ID = new System.Windows.Forms.Label();
            this.lblCUST_Name = new System.Windows.Forms.Label();
            this.lblCUST_IC = new System.Windows.Forms.Label();
            this.lblCUST_Gender = new System.Windows.Forms.Label();
            this.lblCUST_Email = new System.Windows.Forms.Label();
            this.lblCUST_Address = new System.Windows.Forms.Label();
            this.lblCUST_Phone = new System.Windows.Forms.Label();
            this.lblCUST_History = new System.Windows.Forms.Label();
            this.tlpHistory = new System.Windows.Forms.TableLayoutPanel();
            this.lblEnddate = new System.Windows.Forms.Label();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.lblBil = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.tlpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblProfile.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProfile.Location = new System.Drawing.Point(362, 28);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(398, 76);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Mr./Mrs.____\'s Profile";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            // 
            // lblCUST_ID
            // 
            this.lblCUST_ID.AutoSize = true;
            this.lblCUST_ID.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_ID.Location = new System.Drawing.Point(98, 106);
            this.lblCUST_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_ID.Name = "lblCUST_ID";
            this.lblCUST_ID.Size = new System.Drawing.Size(119, 45);
            this.lblCUST_ID.TabIndex = 2;
            this.lblCUST_ID.Text = "Customer ID:";
            // 
            // lblCUST_Name
            // 
            this.lblCUST_Name.AutoSize = true;
            this.lblCUST_Name.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_Name.Location = new System.Drawing.Point(98, 143);
            this.lblCUST_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_Name.Name = "lblCUST_Name";
            this.lblCUST_Name.Size = new System.Drawing.Size(155, 45);
            this.lblCUST_Name.TabIndex = 3;
            this.lblCUST_Name.Text = "Customer\'s Name:";
            // 
            // lblCUST_IC
            // 
            this.lblCUST_IC.AutoSize = true;
            this.lblCUST_IC.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_IC.Location = new System.Drawing.Point(98, 181);
            this.lblCUST_IC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_IC.Name = "lblCUST_IC";
            this.lblCUST_IC.Size = new System.Drawing.Size(107, 45);
            this.lblCUST_IC.TabIndex = 4;
            this.lblCUST_IC.Text = "IC Number:";
            // 
            // lblCUST_Gender
            // 
            this.lblCUST_Gender.AutoSize = true;
            this.lblCUST_Gender.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_Gender.Location = new System.Drawing.Point(98, 256);
            this.lblCUST_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_Gender.Name = "lblCUST_Gender";
            this.lblCUST_Gender.Size = new System.Drawing.Size(77, 45);
            this.lblCUST_Gender.TabIndex = 5;
            this.lblCUST_Gender.Text = "Gender:";
            // 
            // lblCUST_Email
            // 
            this.lblCUST_Email.AutoSize = true;
            this.lblCUST_Email.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_Email.Location = new System.Drawing.Point(98, 332);
            this.lblCUST_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_Email.Name = "lblCUST_Email";
            this.lblCUST_Email.Size = new System.Drawing.Size(132, 45);
            this.lblCUST_Email.TabIndex = 6;
            this.lblCUST_Email.Text = "Email Address:";
            // 
            // lblCUST_Address
            // 
            this.lblCUST_Address.AutoSize = true;
            this.lblCUST_Address.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_Address.Location = new System.Drawing.Point(98, 219);
            this.lblCUST_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_Address.Name = "lblCUST_Address";
            this.lblCUST_Address.Size = new System.Drawing.Size(84, 45);
            this.lblCUST_Address.TabIndex = 7;
            this.lblCUST_Address.Text = "Address:";
            // 
            // lblCUST_Phone
            // 
            this.lblCUST_Phone.AutoSize = true;
            this.lblCUST_Phone.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_Phone.Location = new System.Drawing.Point(98, 293);
            this.lblCUST_Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_Phone.Name = "lblCUST_Phone";
            this.lblCUST_Phone.Size = new System.Drawing.Size(149, 45);
            this.lblCUST_Phone.TabIndex = 8;
            this.lblCUST_Phone.Text = "Contact Number:";
            // 
            // lblCUST_History
            // 
            this.lblCUST_History.AutoSize = true;
            this.lblCUST_History.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUST_History.Location = new System.Drawing.Point(98, 369);
            this.lblCUST_History.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUST_History.Name = "lblCUST_History";
            this.lblCUST_History.Size = new System.Drawing.Size(150, 45);
            this.lblCUST_History.TabIndex = 9;
            this.lblCUST_History.Text = "Purchase History:";
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
            this.tlpHistory.Location = new System.Drawing.Point(98, 417);
            this.tlpHistory.Margin = new System.Windows.Forms.Padding(2);
            this.tlpHistory.Name = "tlpHistory";
            this.tlpHistory.RowCount = 5;
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHistory.Size = new System.Drawing.Size(924, 211);
            this.tlpHistory.TabIndex = 10;
            this.tlpHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpHistory_Paint);
            // 
            // lblEnddate
            // 
            this.lblEnddate.BackColor = System.Drawing.Color.Transparent;
            this.lblEnddate.Font = new System.Drawing.Font("Gabriola", 14F);
            this.lblEnddate.ForeColor = System.Drawing.Color.Azure;
            this.lblEnddate.Location = new System.Drawing.Point(705, 0);
            this.lblEnddate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnddate.Name = "lblEnddate";
            this.lblEnddate.Size = new System.Drawing.Size(217, 39);
            this.lblEnddate.TabIndex = 4;
            this.lblEnddate.Text = "End-date";
            this.lblEnddate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartdate
            // 
            this.lblStartdate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartdate.Font = new System.Drawing.Font("Gabriola", 14F);
            this.lblStartdate.ForeColor = System.Drawing.Color.Azure;
            this.lblStartdate.Location = new System.Drawing.Point(486, 0);
            this.lblStartdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(215, 39);
            this.lblStartdate.TabIndex = 3;
            this.lblStartdate.Text = "Start-date";
            this.lblStartdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Gabriola", 14F);
            this.lblStatus.ForeColor = System.Drawing.Color.Azure;
            this.lblStatus.Location = new System.Drawing.Point(267, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(215, 39);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.BackColor = System.Drawing.Color.Transparent;
            this.lblInsuranceID.Font = new System.Drawing.Font("Gabriola", 14F);
            this.lblInsuranceID.ForeColor = System.Drawing.Color.Azure;
            this.lblInsuranceID.Location = new System.Drawing.Point(48, 0);
            this.lblInsuranceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(215, 39);
            this.lblInsuranceID.TabIndex = 1;
            this.lblInsuranceID.Text = "Insurance ID";
            this.lblInsuranceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBil
            // 
            this.lblBil.BackColor = System.Drawing.Color.Transparent;
            this.lblBil.Font = new System.Drawing.Font("Gabriola", 14F);
            this.lblBil.ForeColor = System.Drawing.Color.Azure;
            this.lblBil.Location = new System.Drawing.Point(2, 0);
            this.lblBil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBil.Name = "lblBil";
            this.lblBil.Size = new System.Drawing.Size(42, 39);
            this.lblBil.TabIndex = 0;
            this.lblBil.Text = "Bil";
            this.lblBil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(98, 649);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 49);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEdit.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(583, 649);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(203, 49);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPurchase.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(817, 649);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(203, 49);
            this.btnPurchase.TabIndex = 13;
            this.btnPurchase.Text = "Purchase New Insurance";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(98, 417);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(924, 211);
            this.dgvHistory.TabIndex = 14;
            // 
            // Customer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCUST_History);
            this.Controls.Add(this.lblCUST_Phone);
            this.Controls.Add(this.lblCUST_Address);
            this.Controls.Add(this.lblCUST_Email);
            this.Controls.Add(this.lblCUST_Gender);
            this.Controls.Add(this.lblCUST_IC);
            this.Controls.Add(this.lblCUST_Name);
            this.Controls.Add(this.lblCUST_ID);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.tlpHistory);
            this.Font = new System.Drawing.Font("Gabriola", 15F);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.Name = "Customer_Profile";
            this.Text = "Customer_Profile";
            this.tlpHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblCUST_ID;
        private System.Windows.Forms.Label lblCUST_Name;
        private System.Windows.Forms.Label lblCUST_IC;
        private System.Windows.Forms.Label lblCUST_Gender;
        private System.Windows.Forms.Label lblCUST_Email;
        private System.Windows.Forms.Label lblCUST_Address;
        private System.Windows.Forms.Label lblCUST_Phone;
        private System.Windows.Forms.Label lblCUST_History;
        private System.Windows.Forms.TableLayoutPanel tlpHistory;
        private System.Windows.Forms.Label lblEnddate;
        private System.Windows.Forms.Label lblStartdate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInsuranceID;
        private System.Windows.Forms.Label lblBil;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}