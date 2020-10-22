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
            this.btnMainPage = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMainPage.ForeColor = System.Drawing.Color.White;
            this.btnMainPage.Location = new System.Drawing.Point(98, 649);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(203, 49);
            this.btnMainPage.TabIndex = 4;
            this.btnMainPage.Text = "Back to Main Page";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.txtSearch.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(98, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(924, 58);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Enter  to Search:";
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.AllowUserToAddRows = false;
            this.dgvSearchResult.AllowUserToDeleteRows = false;
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(98, 228);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.ReadOnly = true;
            this.dgvSearchResult.RowHeadersWidth = 51;
            this.dgvSearchResult.RowTemplate.Height = 24;
            this.dgvSearchResult.Size = new System.Drawing.Size(924, 399);
            this.dgvSearchResult.TabIndex = 3;
            this.dgvSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(819, 649);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 49);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Customer ID",
            "Insurance ID"});
            this.cbSelect.Location = new System.Drawing.Point(98, 41);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(457, 63);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.Text = "Select Type of ID to Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click to view the details of selected Insurance.";
            // 
            // Searching_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 757);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSearchResult);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "Searching_Page";
            this.Text = "Searching_Page";
            this.Load += new System.EventHandler(this.Searching_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label1;
    }
}