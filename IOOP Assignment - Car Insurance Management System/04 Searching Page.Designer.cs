namespace IOOP_Assignment___Car_Insurance_Management_System
{
    partial class Searching_Page
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
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.tlpSearchResult = new System.Windows.Forms.TableLayoutPanel();
            this.lblBil = new System.Windows.Forms.Label();
            this.lblInsuranceID = new System.Windows.Forms.Label();
            this.lblPurchasedCustomer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPurchasedDate = new System.Windows.Forms.Label();
            this.tlpSearchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.Location = new System.Drawing.Point(158, 118);
            this.lblLoginWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(896, 58);
            this.lblLoginWelcome.TabIndex = 1;
            this.lblLoginWelcome.Text = "Enter Customer ID or Insurance ID to Search:";
            // 
            // tlpSearchResult
            // 
            this.tlpSearchResult.ColumnCount = 5;
            this.tlpSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearchResult.Controls.Add(this.lblBil, 0, 0);
            this.tlpSearchResult.Controls.Add(this.lblInsuranceID, 1, 0);
            this.tlpSearchResult.Controls.Add(this.lblPurchasedCustomer, 2, 0);
            this.tlpSearchResult.Controls.Add(this.lblStatus, 3, 0);
            this.tlpSearchResult.Controls.Add(this.lblPurchasedDate, 4, 0);
            this.tlpSearchResult.Location = new System.Drawing.Point(159, 196);
            this.tlpSearchResult.Name = "tlpSearchResult";
            this.tlpSearchResult.RowCount = 10;
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpSearchResult.Size = new System.Drawing.Size(883, 387);
            this.tlpSearchResult.TabIndex = 2;
            this.tlpSearchResult.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblBil
            // 
            this.lblBil.Location = new System.Drawing.Point(3, 0);
            this.lblBil.Name = "lblBil";
            this.lblBil.Size = new System.Drawing.Size(46, 37);
            this.lblBil.TabIndex = 0;
            this.lblBil.Text = "Bil";
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.Location = new System.Drawing.Point(55, 0);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(165, 38);
            this.lblInsuranceID.TabIndex = 1;
            this.lblInsuranceID.Text = "Insurance ID";
            // 
            // lblPurchasedCustomer
            // 
            this.lblPurchasedCustomer.Location = new System.Drawing.Point(226, 0);
            this.lblPurchasedCustomer.Name = "lblPurchasedCustomer";
            this.lblPurchasedCustomer.Size = new System.Drawing.Size(239, 38);
            this.lblPurchasedCustomer.TabIndex = 2;
            this.lblPurchasedCustomer.Text = "Purchased Customer";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(471, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 37);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblPurchasedDate
            // 
            this.lblPurchasedDate.Location = new System.Drawing.Point(588, 0);
            this.lblPurchasedDate.Name = "lblPurchasedDate";
            this.lblPurchasedDate.Size = new System.Drawing.Size(283, 37);
            this.lblPurchasedDate.TabIndex = 4;
            this.lblPurchasedDate.Text = "Purchased Date";
            // 
            // Searching_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 759);
            this.Controls.Add(this.tlpSearchResult);
            this.Controls.Add(this.lblLoginWelcome);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Searching_Page";
            this.Text = "Searching_Page";
            this.tlpSearchResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoginWelcome;
        private System.Windows.Forms.TableLayoutPanel tlpSearchResult;
        private System.Windows.Forms.Label lblBil;
        private System.Windows.Forms.Label lblInsuranceID;
        private System.Windows.Forms.Label lblPurchasedCustomer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPurchasedDate;
    }
}