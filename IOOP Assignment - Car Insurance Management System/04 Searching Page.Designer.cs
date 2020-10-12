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
            this.btnSignin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tlpSearchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.BackColor = System.Drawing.Color.CadetBlue;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLoginWelcome.Location = new System.Drawing.Point(98, 53);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(924, 54);
            this.lblLoginWelcome.TabIndex = 1;
            this.lblLoginWelcome.Text = "Enter Customer ID or Insurance ID to Search:";
            this.lblLoginWelcome.Click += new System.EventHandler(this.lblLoginWelcome_Click);
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
            this.tlpSearchResult.Location = new System.Drawing.Point(98, 149);
            this.tlpSearchResult.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
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
            this.tlpSearchResult.Size = new System.Drawing.Size(924, 463);
            this.tlpSearchResult.TabIndex = 2;
            this.tlpSearchResult.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblBil
            // 
            this.lblBil.Location = new System.Drawing.Point(2, 0);
            this.lblBil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBil.Name = "lblBil";
            this.lblBil.Size = new System.Drawing.Size(44, 46);
            this.lblBil.TabIndex = 0;
            this.lblBil.Text = "Bil";
            this.lblBil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInsuranceID
            // 
            this.lblInsuranceID.Location = new System.Drawing.Point(50, 0);
            this.lblInsuranceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsuranceID.Name = "lblInsuranceID";
            this.lblInsuranceID.Size = new System.Drawing.Size(153, 46);
            this.lblInsuranceID.TabIndex = 1;
            this.lblInsuranceID.Text = "Insurance ID";
            this.lblInsuranceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPurchasedCustomer
            // 
            this.lblPurchasedCustomer.Location = new System.Drawing.Point(207, 0);
            this.lblPurchasedCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasedCustomer.Name = "lblPurchasedCustomer";
            this.lblPurchasedCustomer.Size = new System.Drawing.Size(212, 46);
            this.lblPurchasedCustomer.TabIndex = 2;
            this.lblPurchasedCustomer.Text = "Purchased Customer";
            this.lblPurchasedCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(423, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 46);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPurchasedDate
            // 
            this.lblPurchasedDate.Location = new System.Drawing.Point(582, 0);
            this.lblPurchasedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchasedDate.Name = "lblPurchasedDate";
            this.lblPurchasedDate.Size = new System.Drawing.Size(342, 46);
            this.lblPurchasedDate.TabIndex = 4;
            this.lblPurchasedDate.Text = "Purchased Date";
            this.lblPurchasedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(98, 649);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(203, 49);
            this.btnSignin.TabIndex = 8;
            this.btnSignin.Text = "Back to Main Page";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Customer Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(819, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "View Insurance Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Searching_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.tlpSearchResult);
            this.Controls.Add(this.lblLoginWelcome);
            this.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
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
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}